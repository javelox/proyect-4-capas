using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
using LibLlenarGrid;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibLNCategoria
{
    public class Categoria
    {
        #region atributos
        private string id_categoria;
        private string nombre_categoria;
        private string error;
        private SqlDataReader reader;
        #endregion

        #region propiedades
        public string Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }
        public string Error { get => error; set => error = value; }
<<<<<<< HEAD
        public SqlDataReader Reader { get => reader; set => reader = value; }
        #endregion

        #region metodos publicos
        public Categoria()
=======
        #endregion

        #region metodos publicos
        public Categoria(string error)
>>>>>>> 1dc2abc08043b56257adfc7ed3d78933b27df8f8
        {
            id_categoria = "";
            nombre_categoria = "";
            Error = "";
        }

        public bool insertarcategoria()
        {
            ClsConexion objC = new ClsConexion();
            String Sentencia = "EXECUTE USP_InsertarCategoriaProducto '" + Id_categoria + "','" + Nombre_categoria +"';";
            if (!objC.EjecutarSentencia(Sentencia, false))
            {
                error = objC.Error;
                objC = null;
                return true;
            }
            else
            {
                error = "Se agrego exitosamente";
                objC = null;
                return true;
            }
        }

        public bool actualizarcategoria()
        {
            ClsConexion objC = new ClsConexion();
            String Sentencia = "EXECUTE USP_ActuralizarCategoriaProducto '" + Id_categoria + "','" + Nombre_categoria + "';";
            if (!objC.EjecutarSentencia(Sentencia, false))
            {
                error = objC.Error;
                objC = null;
                return true;
            }
            else
            {
                error = "Se actualizo exitosamente";
                objC = null;
                return true;
            }
        }

        public bool eliminarcategoria()
        {
            ClsConexion objC = new ClsConexion();
            String Sentencia = "EXECUTE USP_EliminarCategoriaProducto '" + Id_categoria + "';";
            if (!objC.EjecutarSentencia(Sentencia, false))
            {
                error = objC.Error;
                objC = null;
                return true;
            }
            else
            {
                error = "Se ha eliminado exitosamnete";
                objC = null;
                return true;
            }
        }

        public bool consultarcategoria()
        {
            ClsConexion objC = new ClsConexion();
            String Sentencia = "EXECUTE USP_ConsultarCategoriaProducto '" + Id_categoria + "';";
            if (!objC.EjecutarSentencia(Sentencia, false))
            {
                error = objC.Error;
                objC = null;
                return true;
            }
            else
            {
<<<<<<< HEAD
                Reader = objC.Reader;
=======
                reader = objC.Reader;
>>>>>>> 1dc2abc08043b56257adfc7ed3d78933b27df8f8
                objC = null;
                return true;
            }
        }

        public bool listarcategoria(DataGridView objD)
        {
            ClsLlenarGrid objA = new ClsLlenarGrid();
            objA.NombreTabla = "DatosCategorias";
            objA.SQL = "USP_ListarCategoriaProducto";
            if (objA.LlenarGrid(objD))
            {
                error = objA.Error;
                objA = null;
                return false;
            }
            else
            {
                objA = null;
                return true;
            }
        }
        #endregion
    }
}
