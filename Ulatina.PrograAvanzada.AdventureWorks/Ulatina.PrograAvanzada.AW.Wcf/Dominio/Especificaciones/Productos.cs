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

        //JOSE CHAVES
        /// 1.  Lista de artículos que contienen una hilera determinada en el nombre.
        public IList<Model.Product> EncontrarProductoPorHileraNombre(string laHilera)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductoPorHileraNombre(laHilera);
            return elProducto;
        }

        //STHIF ARCE GUERRERO
        /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
		public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime laFechaVencimiento)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarProductoFechaVencimiento(laFechaVencimiento);
            return losProductos;
        }

        //PAULO FERNANDEZ
        /// 3.  Lista de artículos de un color determinado
        public IList<Model.Product> EncontarProductoPorColorDeterminado(string elColor)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProducto = elRepositorio.EncontarProductoPorColorDeterminado(elColor);
            return losProducto;
        }

        //JOSE CHAVES 
        /// 4.  Lista de artículos cuyo nombre de la subcategoria contenga una hilera determinada
        public IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            var elRepositorio = new Repositorio.Productos();
            var elProducto = elRepositorio.EncontrarProductosPorHileraSubcategoria(laHilera);
            return elProducto;
        }

        //STHIF ARCE GUERRERO
        /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
        public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			var elRepositorio = new Repositorio.Productos();
			var losProductos = elRepositorio.BuscarProductoNombreCategoria(elCategoria);
			return losProductos;
		}

        //PABLO FERNANDEZ
        /// 6.  Lista de artículos cuyo nombre de la modelo contenga una hilera determinada
        public IList<Model.Product> BuscarProductosPorModelo(string laHilera)
        {
            var elRepositorio = new Repositorio.Productos();
            var losProductos = elRepositorio.BuscarPorductosPorModelo(laHilera);
            return losProductos;
        }


        //STHIF ARCE GUERRERO
        /// 7.  lista de artículos que contengan al menos un review.
        public IList<Model.Product> BuscarProductoContengaReview()
		{
			var elRepositorio = new Repositorio.Productos();
			var losProductos = elRepositorio.BuscarProductoContengaReview();
			return losProductos;
		}

        
    }
}