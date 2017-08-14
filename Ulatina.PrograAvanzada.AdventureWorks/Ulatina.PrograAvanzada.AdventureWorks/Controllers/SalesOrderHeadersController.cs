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
    public class SalesOrderHeadersController : Controller
    {
        private AdventureWorks2014Entities db = new AdventureWorks2014Entities();

        // Consulta A
        public ActionResult RangoDeFechaDeLaOrdenIndex()
        {
            var fechaInicial = Convert.ToDateTime("2011-07-20");
            var fechaFinal = Convert.ToDateTime("2011-07-21");
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.RangoDeFechaDeLaOrden(fechaInicial, fechaFinal);
            return View(facturas.ToList());
        }

        // Consulta B
        public ActionResult RangoDeTotal()
        {
            decimal totalInicial = 10000;
            decimal totalFinal = (decimal)14999.99;
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.RangoDeTotal(totalInicial, totalFinal);
            return View(facturas.ToList());
        }

        // Consulta C
        public ActionResult ListaFacturasPorDetalleYDescuento()
        {
            decimal descuentoTotal = (decimal)399.99;
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.ListaFacturasPorDetalleYDescuento(descuentoTotal);
            return View(facturas.ToList());
        }

        // Consulta D
        public ActionResult ListaDeFacturasPorRango()
        {
            int cantidadMenor = 10;
            int cantidadMayor = 15;
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.ListaDeFacturasPorRango(cantidadMenor, cantidadMayor);
            return View(facturas.ToList());
        }

        // Consulta E
        public ActionResult ListaGeneroEspecificoVendedor()
        {
            string genero = "F";
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.ListaGeneroEspecificoVendedor(genero);
            return View(facturas.ToList());
        }

        // Consulta F
        public ActionResult ListaFacturasDeVendedorPorEdad()
        {
            int edadMenor = 30;
            int edadMayor = 40;
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.ListaFacturasDeVendedorPorEdad(edadMenor, edadMayor);
            return View(facturas.ToList());
        }

        // Consulta F
        public ActionResult ListaFacturasDeVendedoresRangoAntiguedad()
        {
            int antiguedadMayor = 2;
            int antiguedadMenor = 5;
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.ListaFacturasDeVendedoresRangoAntiguedad(antiguedadMenor, antiguedadMayor);
            return View(facturas.ToList());
        }

        // Consulta H
        public ActionResult ListaFacturasVendedoresTextoEspecificoApellidoNombre()
        {
            string laHilera  = "Miller";
            var laAccion = new AW.Wcf.Acciones.SalesOrderHeader();
            var facturas = laAccion.ListaFacturasVendedoresTextoEspecificoApellidoNombre(laHilera);
            return View(facturas.ToList());
        }
        
        // GET: SalesOrderHeaders
        public ActionResult Index()
        {
            var salesOrderHeader = db.SalesOrderHeader.Include(s => s.SalesPerson);
            return View(salesOrderHeader.ToList());
        }

        // GET: SalesOrderHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Create
        public ActionResult Create()
        {
            ViewBag.SalesPersonID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID");
            return View();
        }

        // POST: SalesOrderHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,SalesPersonID,TerritoryID,BillToAddressID,ShipToAddressID,ShipMethodID,CreditCardID,CreditCardApprovalCode,CurrencyRateID,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")] SalesOrderHeader salesOrderHeader)
        {
            if (ModelState.IsValid)
            {
                db.SalesOrderHeader.Add(salesOrderHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SalesPersonID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID", salesOrderHeader.SalesPersonID);
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            ViewBag.SalesPersonID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID", salesOrderHeader.SalesPersonID);
            return View(salesOrderHeader);
        }

        // POST: SalesOrderHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,SalesPersonID,TerritoryID,BillToAddressID,ShipToAddressID,ShipMethodID,CreditCardID,CreditCardApprovalCode,CurrencyRateID,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")] SalesOrderHeader salesOrderHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesOrderHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SalesPersonID = new SelectList(db.SalesPerson, "BusinessEntityID", "BusinessEntityID", salesOrderHeader.SalesPersonID);
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // POST: SalesOrderHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeader.Find(id);
            db.SalesOrderHeader.Remove(salesOrderHeader);
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
