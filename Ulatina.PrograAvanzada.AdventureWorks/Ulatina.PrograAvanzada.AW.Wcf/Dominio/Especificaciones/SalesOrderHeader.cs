using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Especificaciones
{
	internal class SalesOrderHeader
	{
		public SalesOrderHeader()
		{
		}

		// consulta A

		public IList<Model.SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime fecha1, DateTime fecha2)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.RangoDeFechaDeLaOrden(fecha1,fecha2);
            return lasSalesOrden;
		}
		// consulta B
		public IList<Model.SalesOrderHeader> RangoDeTotal(decimal total1, decimal total2)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.RangoDeTotal(total1,total2);
			return lasSalesOrden;
		}
		// consulta C
		public IList<Model.SalesOrderHeader> ListaFacturaPorDetalleYDescuento(decimal descuento)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.ListaFacturaPorDetalleYDescuento(descuento);
			return lasSalesOrden;
		}
		// consulta D
		public IList<Model.SalesOrderHeader> ListaDeFacturasPorRango(int Cantidad1, int cantidad2)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.ListaDeFacturasPorRango(Cantidad1,cantidad2);
			return lasSalesOrden;
		}
		// consulta E
		public IList<Model.SalesOrderHeader> ListaGeneroEspecificoVendedor(string genero)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.ListaGeneroEspecificoVendedor(genero);
			return lasSalesOrden;
		}
		// consulta F
		public IList<Model.SalesOrderHeader> ListaFacturasDeVendedorPorEdad(int edad1, int edad2)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.ListaDeFacturasPorEdad(edad1,edad2);
			return lasSalesOrden;
		}
		// consulta G
		public IList<Model.SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(int antiguedad1, int antiguedad2)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.ListaFacturasDeVendedoresRangoAntiguedad(antiguedad1,antiguedad2);
			return lasSalesOrden;
		}
		// consulta H
		public IList<Model.SalesOrderHeader> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string palabra)
		{
			var ElRepositorio = new Repositorio.SalesOrderHeader();
			var lasSalesOrden = ElRepositorio.ListaFacturasVendedoresTextoEspecificoApellidoNombre(palabra);
			return lasSalesOrden;
		}
	}
}