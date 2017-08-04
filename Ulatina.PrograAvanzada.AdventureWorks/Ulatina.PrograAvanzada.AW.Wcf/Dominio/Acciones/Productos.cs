﻿using System;
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

        //PABLO FERNANDEZ
        /// 3.  Lista de artículos de un color determinado



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



        //STHIF ARCE GUERRERO
        /// 7.  lista de artículos que contengan al menos un review.
        public IList<Model.Product> BuscarProductoContengaReview()
		{
			var laEspecificacion = new Especificaciones.Productos();
			var losProductos = laEspecificacion.BuscarProductoContengaReview();
			return losProductos;

		}




	}
}