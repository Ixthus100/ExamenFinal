using System;
using System.Collections.Generic;
using System.Linq;

namespace Ulatina.PrograAvanzada.AW.Wcf.Repositorio
{
	internal class SalesOrderHeader
	{
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();


        public SalesOrderHeader()
		{
		}
		// consulta A
		public IList<Model.SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime fecha1 , DateTime fecha2)
		{
            var lasOrdenes = _Contexto.SalesOrderHeader.Where(p => fecha1 >= p.OrderDate && p.OrderDate <= fecha2).ToList();
            return lasOrdenes;
		}
		// consulta B
		public IList<Model.SalesOrderHeader> RangoDeTotal(decimal total1, decimal total2)
		{
            var lasOrdenes = _Contexto.SalesOrderDetail.Where(p => total1 >= p.LineTotal && p.LineTotal <= total2).ToList();
            return lasOrdenes;
        }
		// consulta C
		public IList<Model.SalesOrderHeader> ListaFacturaPorDetalleYDescuento(decimal descuento)
		{
            var LasOrdenes = _Contexto.SalesOrderDetail.Where(p => descuento >= p.Discount).ToList();
            return LasOrdenes;
        }
        // consulta D
        public IList<Model.SalesOrderHeader> ListaDeFacturasPorRango(int Cantidad1, int cantidad2)
        {
            var lasOrdenes = _Contexto.SalesOrderDetail.Where(p => Cantidad1 >= p.OrderQty && p.OrderQty <= cantidad2).ToList();
            return lasOrdenes;
        }

        // consulta E
        public IList<Model.SalesOrderHeader> ListaGeneroEspecificoVendedor(string genero)
		{
            var LasOrdenes = _Contexto.Employee.Where(p => p.Gender.Contains(genero)).ToList();
            return LasOrdenes;
        }
		
		// consulta F
        public IList<Model.SalesOrderHeader> ListaDeFacturasPorEdad(int edad1, int edad2)
		{

            var LasOrdenes = _Contexto.SalesOrderHeader.Include("SalesPerson").Include("Employee").Where(p => edad1 >= p.SalesPerson.Employee.EmployeeAge && p.SalesPerson.Employee.EmployeeAge<= edad2).ToList();
            return LasOrdenes;
        }
        // consulta G
        public IList<Model.SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(int antiguedad1, int antiguedad2)
        {
            var LasOrdenes = _Contexto.SalesOrderHeader.Include("SalesPerson").Include("Employee").Where(p => antiguedad1 >= p.SalesPerson.Employee.YearsContracted && p.SalesPerson.Employee.YearsContracted <= antiguedad2).ToList();
            return LasOrdenes;
        }
        // consulta H
        public IList<Model.SalesOrderHeader> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string palabra)
        {

            var LasOrdenes = _Contexto.SalesOrderHeader.Include("SalesPerson").Include("Employee").Include("Person").Include("Employee").Where(p => p.SalesPerson.Employee.Person.FullName.Contains(palabra)).ToList();
            return LasOrdenes;
        }

    }
}