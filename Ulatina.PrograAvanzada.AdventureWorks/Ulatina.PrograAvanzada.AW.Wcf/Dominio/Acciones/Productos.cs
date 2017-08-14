using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Acciones
{
    public class Productos
    {
        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        //JOSE CHAVES
        /// 1.  Lista de artículos que contienen una hilera determinada en el nombre.
        public IList<Model.Product> EncontrarProductoPorHileraNombre(string laHilera)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductoPorHileraNombre(laHilera);
            return elProducto;
        }

        //STHIF ARCE GUERRERO
        /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
		public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime laFechaVencimiento)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductoFechaVencimiento(laFechaVencimiento);
            return losProductos;
        }

        //PAULO FERNANDEZ
        /// 3.  Lista de artículos de un color determinado
        public IList<Model.Product> EncontarProductoPorColorDeterminado(string elColor)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProducto = laEspecificacion.EncontarProductoPorColorDeterminado(elColor);
            return losProducto;
        }

        //JOSE CHAVES 
        /// 4.  Lista de artículos cuyo nombre de la subcategoria contenga una hilera determinada
        public IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var elProducto = laEspecificacion.EncontrarProductosPorHileraSubcategoria(laHilera);
            return elProducto;
        }

        //STHIF ARCE GUERRERO
        /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
        public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			var laEspecificacion = new Especificaciones.Productos();
			var losProductos = laEspecificacion.BuscarProductoNombreCategoria(elCategoria);
			return losProductos;
		}

        //PABLO FERNANDEZ
        /// 6.  Lista de artículos cuyo nombre de la modelo contenga una hilera determinada
        public IList<Model.Product> EncontarProductosPorModelo(string laHilera)
        {
            var laEspecificacion = new Especificaciones.Productos();
            var losProductos = laEspecificacion.BuscarProductosPorModelo(laHilera);
            return losProductos;
        }


        //STHIF ARCE GUERRERO
        /// 7.  lista de artículos que contengan al menos un review.
        public IList<Model.Product> BuscarProductoContengaReview()
		{
			var laEspecificacion = new Especificaciones.Productos();
			var losProductos = laEspecificacion.BuscarProductoContengaReview();
			return losProductos;

		}

        // *****************************examen final***************************
        // numero 1

        public IList<Model.Product> RangoDeFechaDeLaOrden(DateTime _laFecha)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.RangoDeFechaDeLaOrden(_laFecha);
            return LosProductos;
        }
        // numero 2

        public IList<Model.Product> RangoDeTotal(decimal _total)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.RangoDeTotal(_total);
            return LosProductos;
        }

        // consulta c 
        public IList<Model.Product>ListaFacturasPorDetalleYDescuento(decimal _descuento)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.ListaFacturaPorDetalleYDescuento(_descuento);
            return LosProductos;
        }

        // consulta d
        public IList<Model.Product> ListaDeFacturasPorRango(string _detalle)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.ListaDeFacturasPorRango(_detalle);
            return LosProductos;

        }

        // Consulta e

        public IList<Model.Product> ListaGeneroEspecificoVendedor(string _genero)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.ListaGeneroEspecificoVendedor(_genero);
            return LosProductos;
        }

        // consulta F
        public IList<Model.Product> ListaFacturasDeVendedorPorEdad(decimal _edad)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.ListaFacturasDeVendedorPorEdad(_edad);
            return LosProductos;
        }


        // consulta G
        public IList<Model.Product> ListaFacturasDeVendedoresRangoAntiguedad(DateTime _fecha)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.ListaFacturasDeVendedoresRangoAntiguedad( _fecha);
            return LosProductos;
        }

        public IList<Model.Product> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string _palabra)
        {
            var LaEspecificacion = new Especificaciones.Productos();
            var LosProductos = LaEspecificacion.ListaFacturasVendedoresTextoEspecificoApellidoNombre(_palabra);
            return LosProductos;
        }
    }
}