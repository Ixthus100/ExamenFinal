using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Repositorio
{
	internal class SalesOrderHeader
	{
		public SalesOrderHeader()
		{
		}
		// consulta A
		public IList<Model.SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime fecha1 , DateTime fecha2)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta B
		public IList<Model.SalesOrderHeader> RangoDeTotal(decimal total1, decimal total2)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta C
		public IList<Model.SalesOrderHeader> ListaFacturaPorDetalleYDescuento(decimal descuento)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta D
		public IList<Model.SalesOrderHeader> ListaGeneroEspecificoVendedor(string genero)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta E
		public IList<Model.SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(int antiguedad1, int antiguedad2)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta F
		public IList<Model.SalesOrderHeader> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string palabra)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta G

		public IList<Model.SalesOrderHeader> ListaDeFacturasPorEdad(int edad1, int edad2)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
		// consulta H
		public IList<Model.SalesOrderHeader> ListaDeFacturasPorRango(int Cantidad1, int cantidad2)
		{
			//var LosProductos = _Contexto.SalesOrderHeader.Where(p => _fecha <= p.DiscontinuedDate).ToList();
			return null;
		}
	}
}