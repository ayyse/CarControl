using CarControl.Business.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CarControl.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CarContext _context;
        private readonly IBaseRepository<Customer> _repository;
        public CustomerController(IBaseRepository<Customer> repository, CarContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var data = _repository.GetList();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = _repository.Get(id);
            return View(data);
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(int id, Customer entity)
        {
            var data = _repository.Save(entity);
            return RedirectToAction("Create", "Car");
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Customer entity)
        {
            var data = _repository.Update(id, entity);
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id, Customer entity)
        {
            var data = _repository.Delete(id, entity);
            return View(data);
        }
    }
}
