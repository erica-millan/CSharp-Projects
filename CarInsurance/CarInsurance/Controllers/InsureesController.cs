using CarInsurance.Data;
using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly CarInsuranceContext _context;

        public InsureesController(CarInsuranceContext context)
        {
            _context = context;
        }

        // get insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // get insurees details
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
                return NotFound();

            var insuree = await _context.Insurees.FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
                return NotFound();

            return View(insuree);
        }

        // get insurees create
        public IActionResult Create()
        {
            return View();
        }

        // port insurees create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();

                decimal quote = 50;

                // calculating the age of user
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

                // if age is less than or equal to 18
                if (age <= 18)
                    quote += 100;
                //or between 19 and 25 add 50
                else if (age >= 19 && age <= 25)
                    quote += 50;
                else
                    quote += 25;

                // gettgin quote for car year
                if (insuree.CarYear < 2000)
                    quote += 25;
                if (insuree.CarYear > 2015)
                    quote += 25;

                // adding 25 if car is porche and if its 911 carrera add 25
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25;

                    if (insuree.CarModel.ToLower() == "911 carrera")
                        quote += 25;
                }

                // quote for speeding ticket
                quote += insuree.SpeedingTickets * 10;

                // quote for dui
                if (insuree.DUI)
                    quote *= 1.25m;

                // full coverage quote add 50% to total
                if (insuree.CoverageType.ToLower() == "full")
                    quote *= 1.50m;

                insuree.Quote = quote;

                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(insuree);
        }

        // get insuree edid
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
                return NotFound();

            return View(insuree);
        }

        // port insuree edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Insuree insuree)
        {
            if (id != insuree.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Insurees.Any(e => e.Id == insuree.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // get insuree delete
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var insuree = await _context.Insurees.FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
                return NotFound();

            return View(insuree);
        }

        // port insuree delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // admin view
        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insurees.ToListAsync());
        }
    }
}
