
using ClassLibrary1.Repository;
using ClassLibrary1.Repository.Entity;
using ClassLibrary1.Service;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Example1.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext db=new EmployeeContext();
        private readonly IEmployeeService employeeservice;
        public HomeController(IEmployeeService employeeservice)
        {
            this.employeeservice = employeeservice;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.StateList = db.State;
            var model = new Employee2();
            return View(model);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee2 emp = db.Employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City,Image")] Employee2 emp)
        {
            
            if (ModelState.IsValid)
            {
               
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee2 employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] Employee2 employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee2 emp = db.Employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee2 product = db.Employees.Find(id);
            db.Employees.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FillCity(int state)
        {
            var cities = db.City.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}