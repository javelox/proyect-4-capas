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

namespace LibLNvendedor
{
    public class Vendedor
    {
        #region Atributos
        private string id_vendedor;
        private string nombre_vendedor;
        private string apellido_vendedor;
        private string telefono_vendedor;
        private string correo_electronico;
        private string direccion_vendedor;
        private string error;
        private SqlDataReader reader;
        #endregion
        #region Propiedades
        public string Id_vendedor { get => id_vendedor; set => id_vendedor = value; }
        public string Nombre_vendedor { get => nombre_vendedor; set => nombre_vendedor = value; }
        public string Apellido_vendedor { get => apellido_vendedor; set => apellido_vendedor = value; }
        public string Telefono_vendedor { get => telefono_vendedor; set => telefono_vendedor = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Direccion_vendedor { get => direccion_vendedor; set => direccion_vendedor = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        #endregion
        #region Metodos Publicos
        public Vendedor()
        {
            id_vendedor = "";
            nombre_vendedor = "";
            apellido_vendedor = "";
            telefono_vendedor = "";
            correo_electronico = "";
            direccion_vendedor = "";
            error = "";
        }
        public bool grabarVendedor()
        {
            ClsConexion ObjV = new ClsConexion();
            String Sentencia = "EXECUTE USP_InsertarFactura '" + id_vendedor + "', '" + nombre_vendedor + "', '" + apellido_vendedor + "', '" + telefono_vendedor + "','" + correo_electronico + "'," + direccion_vendedor;
            if (!ObjV.EjecutarSentencia(Sentencia, false))
            {
                error = ObjV.Error;
                ObjV = null;
                return false;
            }
            else
            {
                error = "Se ha insertado exitosamente!";
                ObjV = null;
                return true;
            }
        }

        public bool ConsultarVendedor()
        {
            ClsConexion ObjV = new ClsConexion();
            String Sencentica = "EXECUTE USP_ConsultarVendedor '" + id_vendedor + "'";
            if (!ObjV.Consultar(Sencentica, false))
            {
                error = ObjV.Error;
                ObjV = null;
                return false;
            }
            else
            {
                reader = ObjV.Reader;
                ObjV = null;
                return true;
            }

        }
        public bool listarVendedor(DataGridView objD)
        {
            ClsLlenarGrid ObjG = new ClsLlenarGrid();
            ObjG.NombreTabla = "DatosFactura";
            ObjG.SQL = "USP_ListarVendedor ";
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
        public bool actualizarVendedor()
        {
            ClsConexion ObjV = new ClsConexion();
            String Sentencia = "EXECUTE USP_ActualizarVendedor '" + id_vendedor + "', '" + nombre_vendedor + "', '" + apellido_vendedor + "', '" + telefono_vendedor + "','" + correo_electronico + "'," + direccion_vendedor;
            if (!ObjV.EjecutarSentencia(Sentencia, false))
            {
                error = ObjV.Error;
                ObjV = null;
                return false;
            }
            else
            {
                error = "Se ha actualizado exitosamente!";
                ObjV = null;
                return true;
            }
        }
        public bool eliminarVendedor()
        {
            ClsConexion ObjV = new ClsConexion();
            String Sentencia = "EXECUTE USP_ElminarVendedor '" + id_vendedor + "'";
            if (!ObjV.EjecutarSentencia(Sentencia, false))
            {
                error = ObjV.Error;
                ObjV = null;
                return false;
            }
            else
            {
                error = "Se ha eliminado exitosamente!";
                ObjV = null;
                return true;
            }
        }
        #endregion
        #region Metodos Privados
        #endregion
    }
}
