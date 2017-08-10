using System;
using System.Collections.Generic;
using System.Linq;

namespace Ulatina.PrograAvanzada.AW.Wcf.Repositorio
{


    /// <summary>
    /// tarea moral
    /// genere el código en linq para las siguientes consultas:
    /// 1.  lista de artículos que contienen una hilera determinada en el nombre.
    /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
    /// 3.  lista de artículos de un color determinado.
    /// 4.  lista de artículos cuyo nombre de la subcategoría contenga una hilera determinada.
    /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
    /// 6.  lista de artículos cuyo nombre de modelo contenga una hilera determinada.
    /// 7.  lista de artículos que contengan al menos un review.

    /// </summary>
    internal class Productos
    {
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();

        public Productos()
        {
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            Model.Product elProducto = new Model.Product();
            elProducto = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault();
            return elProducto;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }


        //JOSE CHAVES
        /// 1.  Lista de artículos que contienen una hilera determinada en el nombre.
        public IList<Model.Product> EncontrarProductoPorHileraNombre(string laHilera)
        {
            var losProductos = _Contexto.Product.Where(p => p.Name.Contains(laHilera)).ToList();
            return losProductos;
        }
           
        //STHIF ARCE GUERRERO
        /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
        public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime laFechaVencimiento)
        {
            var losProductos = _Contexto.Product.Where(p => laFechaVencimiento <= p.DiscontinuedDate).ToList();
            return losProductos;
        }

        //PAULO FERNANDEZ
        /// 3.  Lista de artículos de un color determinado
        public IList<Model.Product> EncontarProductoPorColorDeterminado(string elColor)
        {
            // Model.Product elProducto = new Model.Product();
            var LosProductos = _Contexto.Product.Where(p => p.Color.Contains(elColor)).ToList();
            //elProducto = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.p);
            return LosProductos;

        }

        //JOSE CHAVES 
        /// 4.  Lista de artículos cuyo nombre de la subcategoria contenga una hilera determinada
        public IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            /*var losProductos = _Contexto.Product.Join(_Contexto.ProductSubcategory, product => product.ProductSubcategoryID, subcategory => subcategory.ProductSubcategoryID, (product, subcategory) => product).Where(products => products.ProductSubcategory.Name.Contains(laHilera)).ToList(); */
            var losProductos = _Contexto.Product.Include("ProductSubcategory").Include("ProductModel").Include("ProductReview").Include("ProductSubcategory.ProductCategory").Where(p => p.ProductSubcategory.Name.Contains(laHilera)).ToList();
            return losProductos;
        }


        //STHIF ARCE GUERRERO
        /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
        public IList<Model.Product> BuscarProductoNombreCategoria(string laCategoria)
		{

			var LosProductos = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductSubcategory.ProductCategory.Name.Contains(laCategoria)).ToList();
			return LosProductos;

		}

        //PABLO FERNANDEZ
        /// 6.  Lista de artículos cuyo nombre de la modelo contenga una hilera determinada
        public IList<Model.Product> BuscarPorductosPorModelo(string _modelo)
        {
            //var LosProductos = _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include(" ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductSubcategory.ProductCategory.Name.Contains(_modelo)).ToList();
            var LosProductos = _Contexto.Product.Include("productSubCategory").Include("ProductModel").Where(p => p.ProductModel.Name.Contains(_modelo)).ToList();
            return LosProductos;
        }


        //STHIF ARCE GUERRERO
        /// 7.  lista de artículos que contengan al menos un review
        public IList<Model.Product> BuscarProductoContengaReview()

		{
            var losProductos = _Contexto.Product.Join(_Contexto.ProductReview, product => product.ProductID, review => review.ProductID, (product, review) => product).ToList();
			return losProductos;

		}


	}
}