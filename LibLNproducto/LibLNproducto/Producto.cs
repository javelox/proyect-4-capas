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
        private string valor_producto;
        private string cantidad_bodega;
        private string error;
        private SqlDataReader reader;
        #endregion

        #region propiedades
        public string Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Valor_producto { get => valor_producto; set => valor_producto = value; }
        public string Cantidad_bodega { get => cantidad_bodega; set => cantidad_bodega = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        #endregion

        #region metodos publicos 
        public Producto()
       {
            id_producto = "";
            nombre_producto = "";
            valor_producto = "";
            cantidad_bodega = "";
            error = "";
        }

        public bool grabarproducto()
        {
            ClsConexion objP = new ClsConexion();
            String Sentencia = "EXECUTE USP_InsertarProducto '" + id_producto + "','" + nombre_producto + "','" + valor_producto + "','" + cantidad_bodega + "';";
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
            String Sentencia = "EXECUTE USP_Actualizar_Producto '" + id_producto + "','" + nombre_producto + "','" + valor_producto + "','" + cantidad_bodega + "';";
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
            ClsConexion objP = new ClsConexion();
            String Sentencia = "EXECUTE USP_Consultar_Producto '" + id_producto +  "';";
            if (!objP.EjecutarSentencia(Sentencia, false))
            {
                error = objP.Error;
                objP = null;
                return false;
            }
            else
            {
                reader = objP.Reader;
                objP = null;
                return true;
            }
        }

        public bool eliminarproducto()
        {
            ClsConexion objP = new ClsConexion();
            String Sentencia = "EXECUTE USP_Eliminar_Producto '" + id_producto +"';";
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
