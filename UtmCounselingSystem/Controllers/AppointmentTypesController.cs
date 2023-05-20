using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UtmCounselingSystem.Contracts;
using UtmCounselingSystem.Data;
using UtmCounselingSystem.Models;

namespace UtmCounselingSystem.Controllers
{
    public class AppointmentTypesController : Controller
    {
        private readonly IAppointmentTypeRepository appointmentTypeRepository;
        private readonly IMapper mapper;

        public AppointmentTypesController(IAppointmentTypeRepository appointmentTypeRepository, IMapper mapper)
        {
            this.appointmentTypeRepository = appointmentTypeRepository;
            this.mapper = mapper;
        }

        // GET: AppointmentTypes
        public async Task<IActionResult> Index()
        {
            var appointmentTypes = mapper.Map<List<AppointmentTypeVM>>(await appointmentTypeRepository.GetAllAsync());
            return View(appointmentTypes);
        }

        // GET: AppointmentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var appointmentType = await appointmentTypeRepository.GetAsync(id);
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
                await appointmentTypeRepository.AddAsync(appointmentType);
                return RedirectToAction(nameof(Index));
            }
            return View(appointmentTypeVM);
        }

        // GET: AppointmentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var appointmentType = await appointmentTypeRepository.GetAsync(id);
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
                    await appointmentTypeRepository.UpdateAsync(appointmentType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await appointmentTypeRepository.Exists(appointmentTypeVM.Id))
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

        // POST: AppointmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await appointmentTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
