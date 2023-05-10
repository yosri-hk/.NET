using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class FlightController : Controller
    {
        IServiceFlight sf;
        IServicePlane sp;
        // GET: FlightController
        public FlightController(IServiceFlight sf, IServicePlane sp)
        {
            this.sf = sf;
            this.sp = sp;
        }
        public ActionResult Index(DateTime? DateDepart)
        {
            if (DateDepart == null)
            return View(sf.GetAll());
            else
                return View(sf.GetMany(f=>f.FlightDate.Date.Equals(DateDepart)));

        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {

            return View(sf.GetById(id));
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.PlaneId = new SelectList(sp.GetAll(), "PlaneId", "Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection,IFormFile AireLine)
        {
            try
            {
                if (AireLine != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(),

                    "wwwroot", "Uploads", AireLine.FileName);

                    Stream stream = new FileStream(path, FileMode.Create);
                    AireLine.CopyTo(stream);
                    collection.AireLine = AireLine.FileName;
                }
                sf.Add(collection);
                sf.SubmitChanges();

                return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight collection)
        {
            try
            {
                sf.Update(collection);
                sf.SubmitChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(sf.GetById(id));
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Flight collection)
        {
            try
            {
                sf.Delete(collection);
                sf.SubmitChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
