using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibLlenarGrid;
using LibConexionBD;
using System.Windows.Forms;

namespace LibLNproducto
{
    public class Producto
    {
        #region atributos 
        private string id_producto;
        private string nombre_producto;
        private double valor_producto;
        private int cantidad_bodega;
        private string id_categoria;
        private string error;
        private SqlDataReader reader;
        #endregion

        #region propiedades
        public string Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public double Valor_producto { get => valor_producto; set => valor_producto = value; }
        public int Cantidad_bodega { get => cantidad_bodega; set => cantidad_bodega = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public string Id_categoria { get => id_categoria; set => id_categoria = value; }
        #endregion

        #region metodos publicos 
        public Producto()
       {
            id_producto = "";
            nombre_producto = "";
            valor_producto = 0;
            cantidad_bodega = 0;
            id_categoria = "";
            error = "";
        }

        public bool grabarproducto()
        {
            ClsConexion objP = new ClsConexion();
            String Sentencia = "EXECUTE USP_InsertarProducto '" + id_producto + "','" + nombre_producto + "','" + valor_producto+ "','" + cantidad_bodega+ "','" + id_categoria + "'";
            if (!objP.EjecutarSentencia(Sentencia, false))
            {
                error = objP.Error;
                objP = null;
                return true;
            }
            else
            {
                error = "Se agrego exitosamente!";
                objP = null;
                return true;
            }
        }

        public bool actualizarproducto()
        {
            ClsConexion objP = new ClsConexion();
            String Sentencia = "EXECUTE USP_ActualizarProducto '" + id_producto + "','" + nombre_producto + "','" + valor_producto + "','" + cantidad_bodega + "';";
            if (!objP.EjecutarSentencia(Sentencia, false))
            {
                error = objP.Error;
                objP = null;
                return true;
            }
            else
            {
                error = "Se actualizo exitosamente!";
                objP = null;
                return true;
            }
        }

        public bool consultarproducto()
        {
            ClsConexion ObjP = new ClsConexion();
            String Sencentica = "EXECUTE USP_ConsultarProducto '" + id_producto + "'";
            if (!ObjP.Consultar(Sencentica, false))
            {
                error = ObjP.Error;
                ObjP = null;
                return false;
            }
            else
            {
                reader = ObjP.Reader;
                ObjP = null;
                return true;
            }
        }

        public bool eliminarproducto()
        {
            ClsConexion objP = new ClsConexion();
            String Sentencia = "EXECUTE USP_EliminarProducto '" + id_producto +"';";
            if (!objP.EjecutarSentencia(Sentencia, false))
            {
                error = objP.Error;
                objP = null;
                return false;
            }
            else
            {
                error = "Se ha eliminado exitosamente!";
                objP = null;
                return true;
            }
        }

        public bool listarproducto(DataGridView objD)
        {
            ClsLlenarGrid objG = new ClsLlenarGrid();
            objG.NombreTabla = "DatosProductos";
            objG.SQL = "USP_ListarProducto";
            if (objG.LlenarGrid(objD))
            {
                error = objG.Error;
                objG = null;
                return false;
            }
            else
            {
                objG = null;
                return true;
            }
        }

        #endregion
    }
}
