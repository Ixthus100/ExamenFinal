using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AdventureWorks.Controllers
{
    public class EmployeesController : Controller
    {
        private AdventureWorks2014Entities db = new AdventureWorks2014Entities();

        // GET: Employees
        public ActionResult Index()
        {
            var employee = db.Employee.Include(e => e.Person).Include(e => e.SalesPerson);
            return View(employee.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.BusinessEntityID = new SelectList(db.Person, "BusinessEntityID", "PersonType");
            ViewBag.BusinessEntityID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusinessEntityID,NationalIDNumber,LoginID,OrganizationLevel,JobTitle,BirthDate,MaritalStatus,Gender,HireDate,SalariedFlag,VacationHours,SickLeaveHours,CurrentFlag,rowguid,ModifiedDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessEntityID = new SelectList(db.Person, "BusinessEntityID", "PersonType", employee.BusinessEntityID);
            ViewBag.BusinessEntityID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID", employee.BusinessEntityID);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessEntityID = new SelectList(db.Person, "BusinessEntityID", "PersonType", employee.BusinessEntityID);
            ViewBag.BusinessEntityID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID", employee.BusinessEntityID);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusinessEntityID,NationalIDNumber,LoginID,OrganizationLevel,JobTitle,BirthDate,MaritalStatus,Gender,HireDate,SalariedFlag,VacationHours,SickLeaveHours,CurrentFlag,rowguid,ModifiedDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessEntityID = new SelectList(db.Person, "BusinessEntityID", "PersonType", employee.BusinessEntityID);
            ViewBag.BusinessEntityID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID", employee.BusinessEntityID);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employee.Find(id);
            db.Employee.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
