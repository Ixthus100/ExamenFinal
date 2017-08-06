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
    public class Service1 : IService1
    {
        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorNumero(elNumero);
            return elProducto;
        }

        public IList<Model.Product> ListarTodos()
        {
            decimal elPrecioInferior = 10, elPrecioSuperior = 20;
            var laAccion = new Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var laAccion = new Acciones.Productos();
            var losProductos = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            return losProductos;
        }

        //JOSE CHAVES
        /// 1.  Lista de artículos que contienen una hilera determinada en el nombre.
        public IList<Product> EncontrarProductosPorHileraNombre(string laHilera)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductoPorHileraNombre(laHilera);
            return elProducto;
        }

        //STHIF ARCE GUERRERO
        /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
        public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime LaFechaVencimiento)
		{
			var laAccion = new Acciones.Productos();
			var losProductos = laAccion.BuscarProductoFechaVencimiento(LaFechaVencimiento);
			return losProductos;
		}
        //PAULO FERNANDEZ
        /// 3.  Lista de artículos de un color determinado
        public IList<Product> BuscarProductoPorColorDeterminado(string _elColor)
        {
            var laAccion = new Acciones.Productos();
            var losProductos = laAccion.EncontarProductoPorColorDeterminado(_elColor);
            return losProductos;
        }


        //JOSE CHAVES 
        /// 4.  Lista de artículos cuyo nombre de la subcategoria contenga una hilera determinada
        public IList<Product> EncontrarProductosPorHileraSubcategoria(string laHilera)
        {
            var laAccion = new Acciones.Productos();
            var elProducto = laAccion.EncontrarProductosPorHileraSubcategoria(laHilera);
            return elProducto;
        }

        //STHIF ARCE GUERRERO
        /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
        public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			var laAccion = new Acciones.Productos();
			var losProductos = laAccion.BuscarProductoNombreCategoria(elCategoria);
			return losProductos;
		}

        //PAULO FERNANDEZ
        /// 6.  Lista de artículos cuyo nombre de la modelo contenga una hilera determinada
        public IList<Model.Product> EncontrarProductosPorModelo(string _laHilera)
        {
            var laAccion = new Acciones.Productos();
            var losProductos = laAccion.EncontarProductosPorModelo(_laHilera);
            return losProductos;


        }



        //STHIF ARCE GUERRERO
        /// 7.  lista de artículos que contengan al menos un review.
        public IList<Model.Product> BuscarProductoContengaReview()
		{
			var laAccion = new Acciones.Productos();
			var losProductos = laAccion.BuscarProductoContengaReview();
			return losProductos;
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
	}
}
