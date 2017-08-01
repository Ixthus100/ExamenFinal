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

		//STHIF ARCE GUERRERO
		public IList<Model.Product> BuscarProductoFechaVencimiento(DateTime LaFechaVencimiento)
		{
			var laAccion = new Acciones.Productos();
			var losProductos = laAccion.BuscarProductoFechaVencimiento(LaFechaVencimiento);
			return losProductos;
		}
		public IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria)
		{
			var laAccion = new Acciones.Productos();
			var losProductos = laAccion.BuscarProductoNombreCategoria(elCategoria);
			return losProductos;
		}

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
