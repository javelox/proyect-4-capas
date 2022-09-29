using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibConexionBD;
using LibLlenarGrid;
using System.Windows.Forms;

namespace LibLNfactura
{
    public class Factura
    {
        #region Atributos
        private string id_factura;
        private string fecha;
        private string id_cliente;
        private string id_vendedor;
        private string id_producto;
        private string nombre_producto;
        private double valor_producto;
        private double subtotal;
        private double iva;
        private double total;
        private double valor_total;
        private int cantidad_producto;
        private string error;
        private SqlDataReader reader;
        #endregion
        #region Propiedades
        public string Id_factura { get => id_factura; set => id_factura = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Id_vendedor { get => id_vendedor; set => id_vendedor = value; }
        public string Id_producto { get => id_producto; set => id_producto = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Iva { get => iva; set => iva = value; }
        public double Total { get => total; set => total = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public string Error { get => error; set => error = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public double Valor_producto { get => valor_producto; set => valor_producto = value; }
        #endregion
        #region Metodos Publicos
        public Factura()
        {
            id_factura = "";
            fecha = "";
            id_cliente = "";
            id_vendedor = "";
            id_producto = "";
            nombre_producto = "";
            valor_producto = 0;
            subtotal = 0;
            iva = 0;
            total = 0;
            valor_total = 0;
            cantidad_producto = 0;
            error = "";
        }

        public bool grabarFactura()
        {
            ClsConexion ObjF = new ClsConexion();
            String Sentencia = "EXECUTE USP_InsertarFactura '" + id_factura + "', '" + fecha + "', '" + subtotal + "', '" + iva + "','" + total + "','" + id_cliente + "','" + id_vendedor + "','" + id_producto + "','" + cantidad_producto+"',"+valor_total;
            if (!ObjF.EjecutarSentencia(Sentencia, false))
            {
                error = ObjF.Error;
                ObjF = null;
                return false;
            }
            else
            {
                error = "Se ha insertado exitosamente!";
                ObjF = null;
                return true;
            }
        }

        public bool ConsultarFactura()
        {
            ClsConexion ObjF = new ClsConexion();
            String Sencentica = "EXECUTE USP_ConsultarFactura '" + id_factura + "'";
            if (!ObjF.Consultar(Sencentica, false))
            {
                error = ObjF.Error;
                ObjF = null;
                return false;
            }
            else
            {
                reader = ObjF.Reader;
                ObjF = null;
                return true;
            }

        }
        public bool listarFacture(DataGridView objD)
        {
            ClsLlenarGrid ObjG = new ClsLlenarGrid();
            ObjG.NombreTabla = "DatosFactura";
            ObjG.SQL = "USP_ListarFactura ";
            if (ObjG.LlenarGrid(objD))
            {
                error = ObjG.Error;
                ObjG = null;
                return false;
            }
            else
            {
                ObjG = null;
                return true;
            }
        }



        public bool calcular()
        {
            try
            {
                valor_total = cantidad_producto * valor_producto;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }


        #endregion
        #region Metodos Privados
        #endregion
    }
}
