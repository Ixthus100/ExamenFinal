﻿using System;
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

        // *****************************examen final***************************
        // numero 1

        public IList<Model.Product>RangoDeFechaDeLaOrden(DateTime _fecha)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.RangoDeFechaDeLaOrden(_fecha);

            return LosProductos;
        }

        // numero 2
        public IList<Model.Product> RangoDeTotal(decimal _total)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.RangoDeTotal(_total);
            return LosProductos;
            ;
        }

        //consulta c
        public IList<Model.Product> ListaFacturaPorDetalleYDescuento(decimal _descuento)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.ListaFacturaPorDetalleYDescuento(_descuento);
            return LosProductos;
        }

        //consulta d 


        public IList<Model.Product> ListaDeFacturasPorRango(string _detalle)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.ListaDeFacturasPorRango(_detalle);
            return LosProductos;
            ;
        }

       

        // consulta E 

        public IList<Model.Product> ListaGeneroEspecificoVendedor(string _genero)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.ListaGeneroEspecificoVendedor(_genero);
            return LosProductos;
        }


        // consulta F
        public IList<Model.Product> ListaFacturasDeVendedorPorEdad(decimal _edad)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.ListaDeFacturasPorEdad(_edad);
            return LosProductos;
        }
        // consulta G
        public IList<Model.Product> ListaFacturasDeVendedoresRangoAntiguedad(DateTime _fecha)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.ListaFacturasDeVendedoresRangoAntiguedad(_fecha);
            return LosProductos;
        }
        // consulta H
        public IList<Model.Product> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string _palabra)
        {
            var ElRepositorio = new Repositorio.Productos();
            var LosProductos = ElRepositorio.ListaFacturasVendedoresTextoEspecificoApellidoNombre(_palabra);
            return LosProductos;
        }
    }
}