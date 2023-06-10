using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UtmCounselingSystem.Constants;
using UtmCounselingSystem.Data;
using UtmCounselingSystem.Models;

namespace UtmCounselingSystem.Controllers
{
    public class ClientsController : Controller
    {
        private readonly UserManager<Client> userManager;
        private readonly IMapper mapper;

        public ClientsController(UserManager<Client> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        // GET: ClientsController
        public async Task<IActionResult> IndexAsync()
        {
            var clients = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<ClientListVM>>(clients);
            return View(model);
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
