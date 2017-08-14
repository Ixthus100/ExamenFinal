using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        Model.Product EncontrarProductoPorNumero(string elNumero);

        [OperationContract]
        IList<Model.Product> ListarTodos();

        [OperationContract]
        IList <Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior);

            //JOSE CHAVES
            /// 1.  Lista de artículos que contienen una hilera determinada en el nombre.
        [OperationContract]
        IList<Model.Product> EncontrarProductosPorHileraNombre(string laHilera);

        //STHIF ARCE GUERRERO
        /// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.
        [OperationContract]
		IList<Model.Product> BuscarProductoFechaVencimiento(DateTime elFechaVencimiento);

        //PAULO FERNANDEZ
        /// 3.  Lista de artículos de un color determinado
        [OperationContract]
        IList<Model.Product> BuscarProductoPorColorDeterminado(string _elColor);


        //JOSE CHAVES 
        /// 4.  Lista de artículos cuyo nombre de la subcategoria contenga una hilera determinada
        [OperationContract]
        IList<Model.Product> EncontrarProductosPorHileraSubcategoria(string laHilera);

        //STHIF ARCE GUERRERO
        /// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
        [OperationContract]
		IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria);

        //PAULO FERNANDEZ
        /// 6.  Lista de artículos cuyo nombre de la modelo contenga una hilera determinada
        [OperationContract]
        IList<Model.Product> EncontrarProductosPorModelo(string _laHilera);

        //STHIF ARCE GUERRERO
        /// 7.  lista de artículos que contengan al menos un review.
        [OperationContract]
		IList<Model.Product> BuscarProductoContegaReview();


        // *****************************examen final***************************
        
            
        // consulta A
        [OperationContract]
        IList<Model.SalesOrderHeader> RangoDeFechaDeLaOrden(DateTime _fecha);

        // consulta B
        [OperationContract]
        IList<Model.SalesOrderHeader> RangoDeTotal(decimal _total);


        // consulta C
        [OperationContract]
        IList<Model.SalesOrderHeader> ListaFacturasPorDetalleYDescuento(decimal _descuento);

        // consulta D
        [OperationContract]
        IList<Model.SalesOrderHeader> ListaFacturasPorRango(string _detalle);

        // consulta E
        [OperationContract]
        IList<Model.SalesOrderHeader> ListaGeneroEspecificoVendedor(string _genero);

        // consulta F
        [OperationContract]
        IList<Model.SalesOrderHeader> ListaFacturasDeVendedorPorEdad(int edad1, int edad2);

        // consulta G 
        [OperationContract]
        IList<Model.SalesOrderHeader> ListaFacturasDeVendedoresRangoAntiguedad(DateTime _fecha);

        // consulta H 
        [OperationContract]
        IList<Model.SalesOrderHeader> ListaFacturasVendedoresTextoEspecificoApellidoNombre(string _palabra);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
