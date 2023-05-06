using Housing_Reservation_System.DataAccess;
using Housing_Reservation_System.DataAccess.Repository.IRepository;
using Housing_Reservation_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Housing_Reservation_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HouseTypeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public HouseTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<HouseType> objHouseTypeList = _unitOfWork.HouseType.GetAll();
            return View(objHouseTypeList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HouseType obj)
        {
            
            if (ModelState.IsValid)
            {
                _unitOfWork.HouseType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "HouseType created successfully";
                return RedirectToAction("Index");

            }
            return View(obj);

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var houseTypeFromDb = _db.HouseType.Find(id);
            var houseTypeFromDbFirst = _unitOfWork.HouseType.GetFirstOrDefault(u => u.Id == id);

            if (houseTypeFromDbFirst == null)
            {
                return NotFound();
            }
            return View(houseTypeFromDbFirst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HouseType obj)
        {
            
            if (ModelState.IsValid)
            {
                _unitOfWork.HouseType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "HouseType updated successfully";
                return RedirectToAction("Index");

            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var houseTypeFromDbFirst = _unitOfWork.HouseType.GetFirstOrDefault(u => u.Id == id);

            if (houseTypeFromDbFirst == null)
            {
                return NotFound();
            }
            return View(houseTypeFromDbFirst);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.HouseType.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.HouseType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "HouseType deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
