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


		//STHIF ARCE GUERRERO

		public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			var laEspecificacion = new Especificaciones.Productos();
			var losProductos = laEspecificacion.BuscarProductoNombreCategoria(elCategoria);
			return losProductos;
		}

		public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime laFechaVencimiento)
		{
			var laEspecificacion = new Especificaciones.Productos();
			var losProductos = laEspecificacion.BuscarProductoFechaVencimiento(laFechaVencimiento);
			return losProductos;
		}

		public IList<Model.Product> BuscarProductoContengaReview()
		{
			var laEspecificacion = new Especificaciones.Productos();
			var losProductos = laEspecificacion.BuscarProductoContengaReview();
			return losProductos;

		}




	}
}