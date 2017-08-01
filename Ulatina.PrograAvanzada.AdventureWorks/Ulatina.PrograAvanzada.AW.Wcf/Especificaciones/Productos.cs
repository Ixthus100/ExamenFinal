using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.Wcf.Especificaciones
{
    internal class Productos
    {
        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }



		//STHIF ARCE GUERRERO


		public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			var elRepositorio = new Repositorio.Productos();
			var losProductos = elRepositorio.BuscarProductoNombreCategoria(elCategoria);
			return losProductos;
		}
		public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime laFechaVencimiento)
		{
			var elRepositorio = new Repositorio.Productos();
			var losProductos = elRepositorio.BuscarProductoFechaVencimiento(laFechaVencimiento);
			return losProductos;
		}

		public IList<Model.Product> BuscarProductoContengaReview()
		{
			var elRepositorio = new Repositorio.Productos();
			var losProductos = elRepositorio.BuscarProductoContengaReview();
			return losProductos;
		}



	}
}