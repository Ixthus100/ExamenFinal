using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Acciones
{
	internal class SalesOrderHeader
	{
		public SalesOrderHeader()
		{
		}


		// *****************************examen final***************************
		// consulta A

		public IList<Model.SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime fecha1, DateTime fecha2)
		{
			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.RangoDeFechaDeLaOrden(fecha1,fecha2);
			return lasSalesOrden;
		}

		// consulta B
		public IList<Model.SalesOrderHeader> RangoDeTotal(decimal total1, decimal total2)
		{
			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.RangoDeTotal(total1,total2);
			return lasSalesOrden;
		}

		// consulta C
		public IList<Model.SalesOrderHeader> ListaFacturasPorDetalleYDescuento(decimal descuento)
		{

			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.ListaFacturaPorDetalleYDescuento(descuento);
			return lasSalesOrden;
		}
		// consulta D
		public IList<Model.SalesOrderHeader> ListaDeFacturasPorRango(int Cantidad1, int cantidad2)
		{
			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.ListaDeFacturasPorRango(Cantidad1,cantidad2);
			return lasSalesOrden;
		}
		// consulta E
		public IList<Model.SalesOrderHeader> ListaGeneroEspecificoVendedor(string genero)
		{
			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.ListaGeneroEspecificoVendedor(genero);
			return lasSalesOrden;
		}
		// consulta F
		public IList<Model.SalesOrderHeader> ListaFacturasDeVendedorPorEdad(int edad1, int edad2)
		{

			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.ListaFacturasDeVendedorPorEdad(edad1,edad2);
			return lasSalesOrden;
		}
		// consulta G
		public IList<Model.SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(int antiguedad1, int antiguedad2)
		{
			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.ListaFacturasDeVendedoresRangoAntiguedad(antiguedad1,antiguedad2);
			return lasSalesOrden;
		}
		// consulta G
		public IList<Model.SalesOrderHeader> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string palabra)
		{
			var LaEspecificacion = new Especificaciones.SalesOrderHeader();
			var lasSalesOrden = LaEspecificacion.ListaFacturasVendedoresTextoEspecificoApellidoNombre(palabra);
			return lasSalesOrden;
		}
	}
}