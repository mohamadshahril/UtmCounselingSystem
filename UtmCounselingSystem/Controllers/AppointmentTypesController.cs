using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UtmCounselingSystem.Data;
using UtmCounselingSystem.Models;

namespace UtmCounselingSystem.Controllers
{
    public class AppointmentTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public AppointmentTypesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: AppointmentTypes
        public async Task<IActionResult> Index()
        {
            var appointmentTypes = mapper.Map<List<AppointmentTypeVM>>(await _context.AppointmentTypes.ToListAsync());
            return View(appointmentTypes);
        }

        // GET: AppointmentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AppointmentTypes == null)
            {
                return NotFound();
            }

            var appointmentType = await _context.AppointmentTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointmentType == null)
            {
                return NotFound();
            }
            var appointmentTypeVM = mapper.Map<AppointmentTypeVM>(appointmentType);
            return View(appointmentTypeVM);
        }

        // GET: AppointmentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppointmentTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AppointmentTypeVM appointmentTypeVM)
        {
            if (ModelState.IsValid)
            {
                var appointmentType = mapper.Map<AppointmentType>(appointmentTypeVM);
                _context.Add(appointmentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointmentTypeVM);
        }

        // GET: AppointmentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentType = await _context.AppointmentTypes.FindAsync(id);
            if (appointmentType == null)
            {
                return NotFound();
            }

            var appointmentTypeVM = mapper.Map<AppointmentTypeVM>(appointmentType);
            return View(appointmentTypeVM);
        }

        // POST: AppointmentTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AppointmentTypeVM appointmentTypeVM)
        {
            if (id != appointmentTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var appointmentType = mapper.Map<AppointmentType>(appointmentTypeVM);
                    _context.Update(appointmentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentTypeExists(appointmentTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appointmentTypeVM);
        }

        // GET: AppointmentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointmentType = await _context.AppointmentTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointmentType == null)
            {
                return NotFound();
            }

            return View(appointmentType);
        }

        // POST: AppointmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointmentType = await _context.AppointmentTypes.FindAsync(id);
            _context.AppointmentTypes.Remove(appointmentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentTypeExists(int id)
        {
            return _context.AppointmentTypes.Any(e => e.Id == id);
        }
    }
}
