using CarControl.Business.Abstract;
using CarControl.Business.Concrete;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CarControl.Controllers
{
    public class CarController : Controller
    {
        private readonly IBaseRepository<Car> _repository;
        public CarController(IBaseRepository<Car> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var data = _repository.GetAll();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = _repository.Get(id);
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Car entity)
        {
            var recordNum = _repository.GetAll().Count(); 
            if (recordNum < 6)
            {
                _repository.Add(entity);
                return View("Index");
            }
            return View("Create");
        }

        public ActionResult Edit(int id)
        {
            var data = _repository.Get(id);
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Car entity)
        {
            _repository.Update(entity);
            return RedirectToAction("Edit");
        }

        public async Task<ActionResult> Delete(Car entity)
        {
            _repository.Remove(entity);
            return RedirectToAction("Index");
        }
    }
}
