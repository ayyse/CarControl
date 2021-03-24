using CarControl.Business.Abstract;
using CarControl.Entities.DataAccess;
using CarControl.Entities.DataContext;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CarControl.Controllers
{
    public class CarController : Controller
    {
        private readonly CarContext _context;
        private readonly IBaseRepository<Car> _repository;
        public CarController(IBaseRepository<Car> repository, CarContext context)
        {
            _repository = repository;
            _context = context;
        }

        public ActionResult Index()
        {
            var data = _repository.GetList();
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
            var recordNum = _context.Cars.ToList().Count();
            if (recordNum < 6)
            {
                var data = _repository.Save(entity);
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
        public async Task<ActionResult> Edit(int id, Car entity)
        {
            var data = _repository.Update(id, entity);
            return View(data);
        }

        public async Task<ActionResult> Delete(int id, Car entity)
        {
            var data = _repository.Delete(id, entity);
            return RedirectToAction("Index");
        }
    }
}
