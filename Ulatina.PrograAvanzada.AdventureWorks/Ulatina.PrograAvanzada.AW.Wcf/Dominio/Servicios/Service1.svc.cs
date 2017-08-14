using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    //public class Service1
    public class Service1 : IService1

	{
		//public Model.Product EncontrarProductoPorNumero(string elNumero)
		//{
		//	var laAccion = new Acciones.Product();
		//	var elProducto = laAccion.EncontrarProductoPorNumero(elNumero);
		//	return elProducto;
		//}

		//public IList<Model.Product> ListarTodos()
		//{
		//	decimal elPrecioInferior = 10, elPrecioSuperior = 20;
		//	var laAccion = new Acciones.Product();
		//	var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
		//	return losProductos;
		//}

		//public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
		//{
		//	var laAccion = new Acciones.Product();
		//	var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
		//	return losProductos;
		//}

		////JOSE CHAVES
		///// 1.  Lista de artículos que contienen una hilera determinada en el nombre.
		//public IList<Product> EncontrarProductosPorHileraNombre(string laHilera)
		//{
		//	var laAccion = new Acciones.Product();
		//	var elProducto = laAccion.EncontrarProductoPorHileraNombre(laHilera);
		//	return elProducto;
		//}

		////STHIF ARCE GUERRERO
		///// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
		//public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime LaFechaVencimiento)
		//{
		//	var laAccion = new Acciones.Product();
		//	var losProductos = laAccion.BuscarProductoFechaVencimiento(LaFechaVencimiento);
		//	return losProductos;
		//}
		////PAULO FERNANDEZ
		///// 3.  Lista de artículos de un color determinado
		//public IList<Product> BuscarProductoPorColorDeterminado(string _elColor)
		//{
		//	var laAccion = new Acciones.SalesOrderDetail();
		//	var losProductos = laAccion.EncontarProductoPorColorDeterminado(_elColor);
		//	return losProductos;
		//}


		////JOSE CHAVES 
		///// 4.  Lista de artículos cuyo nombre de la subcategoria contenga una hilera determinada
		//public IList<Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
		//{
		//	var laAccion = new Acciones.SalesOrderDetail();
		//	var elProducto = laAccion.EncontrarProductosPorHileraSubcategoria(laHilera);
		//	return elProducto;
		//}

		////STHIF ARCE GUERRERO
		///// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
		//public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		//{
		//	var laAccion = new Acciones.SalesOrderDetail();
		//	var losProductos = laAccion.BuscarProductoNombreCategoria(elCategoria);
		//	return losProductos;
		//}

		////PAULO FERNANDEZ
		///// 6.  Lista de artículos cuyo nombre de la modelo contenga una hilera determinada
		//public IList<Model.Product> EncontrarProductosPorModelo(string _laHilera)
		//{
		//	var laAccion = new Acciones.Product();
		//	var losProductos = laAccion.EncontarProductosPorModelo(_laHilera);
		//	return losProductos;


		//}



		////STHIF ARCE GUERRERO
		///// 7.  lista de artículos que contengan al menos un review.
		//public IList<Model.Product> BuscarProductoContengaReview()
		//{
		//	var laAccion = new Acciones.Product();
		//	var losProductos = laAccion.BuscarProductoContengaReview();
		//	return losProductos;
		//}


		// *****************************examen final***************************
		// consulta A

		public IList<SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime fecha1, DateTime fecha2)
		{
			var LaAccion = new Acciones.SalesOrderHeader();
			var lasSalesOrden = LaAccion.RangoDeFechaDeLaOrden(fecha1,fecha2);
			return lasSalesOrden;
		}

		// consulta B
		public IList<Model.SalesOrderHeader> RangoDeTotal(decimal total1 , decimal total2)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.RangoDeTotal(total1,total2);
            return lasSalesOrden;
        }

        // consulta c
        public IList<Model.SalesOrderHeader> ListaFacturasPorDetalleYDescuento(decimal _descuento)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.ListaFacturasPorDetalleYDescuento(_descuento);
            return lasSalesOrden;
        }

        // CONSULTA D

        public IList<Model.SalesOrderHeader> ListaFacturasPorRango(int Cantidad1 , int cantidad2)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.ListaDeFacturasPorRango(Cantidad1,cantidad2);
            return lasSalesOrden;

        }

        // consulta e 

        public IList<Model.SalesOrderHeader> ListaGeneroEspecificoVendedor(string genero)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.ListaGeneroEspecificoVendedor(genero);
            return lasSalesOrden;

        }

        // consulta F
        public IList<Model.SalesOrderHeader> ListaFacturasDeVendedorPorEdad(int edad1 , int edad2)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.ListaFacturasDeVendedorPorEdad(edad1,edad2);
            return lasSalesOrden;
        }
        // consulta g
        public IList<Model.SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(int antiguedad1 , int antiguedad2)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.ListaFacturasDeVendedoresRangoAntiguedad(antiguedad1,antiguedad2);
            return lasSalesOrden;
        }
        // consulta H
        public IList<Model.SalesOrderHeader> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string _palabra)
        {
            var LaAccion = new Acciones.SalesOrderHeader();
            var lasSalesOrden = LaAccion.ListaFacturasVendedoresTextoEspecificoApellidoNombre(_palabra);
            return lasSalesOrden;
        }




        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

		public IList<Product> BuscarProductoContegaReview()
		{
			throw new NotImplementedException();
		}

		public Product EncontrarProductoPorNumero(string elNumero)
		{
			throw new NotImplementedException();
		}

		public IList<Product> ListarTodos()
		{
			throw new NotImplementedException();
		}

		public IList<Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
		{
			throw new NotImplementedException();
		}

		public IList<Product> EncontrarProductosPorHileraNombre(string laHilera)
		{
			throw new NotImplementedException();
		}

		public IList<Product> BuscarProductoFechaVencimiento(DateTime elFechaVencimiento)
		{
			throw new NotImplementedException();
		}

		public IList<Product> BuscarProductoPorColorDeterminado(string _elColor)
		{
			throw new NotImplementedException();
		}

		public IList<Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
		{
			throw new NotImplementedException();
		}

		public IList<Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			throw new NotImplementedException();
		}

		public IList<Product> EncontrarProductosPorModelo(string _laHilera)
		{
			throw new NotImplementedException();
		}

		public IList<SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime _fecha)
		{
			throw new NotImplementedException();
		}

		public IList<SalesOrderHeader> RangoDeTotal(decimal _total)
		{
			throw new NotImplementedException();
		}

		public IList<SalesOrderHeader> ListaFacturasPorRango(string _detalle)
		{
			throw new NotImplementedException();
		}

		public IList<SalesOrderHeader> ListaFacturasDeVendedorPorEdad(decimal _edad)
		{
			throw new NotImplementedException();
		}

		public IList<SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(DateTime _fecha)
		{
			throw new NotImplementedException();
		}
	}
}
