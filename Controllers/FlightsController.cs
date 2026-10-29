using GBC_Travel_Group_48.Data;
using GBC_Travel_Group_48.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBC_Travel_Group_48.Controllers
{
    public class FlightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Flights
        // GET: Flights
        public async Task<IActionResult> Index(string searchString)
        {
            var flights = from f in _context.Flights
                select f;

            if (!String.IsNullOrEmpty(searchString))
            {
                flights = flights.Where(s => s.Destination.Contains(searchString) || s.Origin.Contains(searchString) || s.Airline.Contains(searchString));
            }

            return View(await flights.ToListAsync());
        }
        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.FlightId == id);
            
            if (flight == null) return NotFound();

            return View(flight);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flights/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlightId,Airline,FlightNumber,Origin,Destination,DepartureTime,ArrivalTime,Price,SeatsAvailable")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                // Ensure DateTime is UTC for PostgreSQL compatibility
                flight.DepartureTime = DateTime.SpecifyKind(flight.DepartureTime, DateTimeKind.Utc);
                flight.ArrivalTime = DateTime.SpecifyKind(flight.ArrivalTime, DateTimeKind.Utc);

                _context.Add(flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flight);
        }
        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var flight = await _context.Flights.FindAsync(id);
            if (flight == null) return NotFound();

            return View(flight);
        }

        // POST: Flights/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlightId,Airline,FlightNumber,Origin,Destination,DepartureTime,ArrivalTime,Price,SeatsAvailable")] Flight flight)
        {
            if (id != flight.FlightId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Ensure DateTime is UTC for PostgreSQL compatibility
                    flight.DepartureTime = DateTime.SpecifyKind(flight.DepartureTime, DateTimeKind.Utc);
                    flight.ArrivalTime = DateTime.SpecifyKind(flight.ArrivalTime, DateTimeKind.Utc);

                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Flights.Any(e => e.FlightId == flight.FlightId)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(flight);
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.FlightId == id);
            if (flight == null) return NotFound();

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flight = await _context.Flights.FindAsync(id);
            if (flight != null)
            {
                _context.Flights.Remove(flight);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}