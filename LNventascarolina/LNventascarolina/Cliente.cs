using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
using LibLlenarGrid;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LNventascarolina
{
    public class Cliente
    {
        #region Atributos
        private string idcliente;
        private string nombrecliente;
        private string apellidocliente;
        private string telefonocliente;
        private string correocliente;
        private string direccioncliente;
        private string error;
        private SqlDataReader reader;
        #endregion
        #region Propiedades
        public string Idcliente { get => idcliente; set => idcliente = value; }
        public string Nombrecliente { get => nombrecliente; set => nombrecliente = value; }
        public string Apellidocliente { get => apellidocliente; set => apellidocliente = value; }
        public string Telefonocliente { get => telefonocliente; set => telefonocliente = value; }
        public string Correocliente { get => correocliente; set => correocliente = value; }
        public string Direccioncliente { get => direccioncliente; set => direccioncliente = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        #endregion
        #region Metodos Publicos
        public Cliente()
        {
            idcliente = "";
            nombrecliente = "";
            apellidocliente = "";
            telefonocliente = "";
            correocliente = "";
            direccioncliente = "";
            error = "";
        }
        public bool GrabarCliente()
        {
            ClsConexion Objc = new ClsConexion();
            string sentencia = "EXECUTE USP_InsertarCliente '" + idcliente + "','" + nombrecliente + "','" + apellidocliente + "','" + telefonocliente + "','" + correocliente + "','" + direccioncliente + "';";
            if(!Objc.EjecutarSentencia(sentencia, false))
            {
                error = Objc.Error;
                Objc = null;
                return false;
            }
            else
            {
                error = "se guardo el cliente exitosamente";
                Objc = null;
                return true;
            }
        }
        public bool ActualizarCliente()
        {
            ClsConexion Objc = new ClsConexion();
            string sentencia = "EXECUTE USP_ActualizarCliente '" + idcliente + "','" + nombrecliente + "','" + apellidocliente + "','" + telefonocliente + "','" + correocliente + "','" + direccioncliente + "'";
            if(!Objc.EjecutarSentencia(sentencia, false))
            {
                error = Objc.Error;
                Objc = null;
                return false;
            }
            else
            {
                error = "se actualizo la infomacion correctamente";
                Objc = null;
                return true;
            }
        }
        public bool EliminarCliente()
        {
            ClsConexion Objc = new ClsConexion();
            string sentencia = "EXECUTE USP_EliminarCliente '" + idcliente + "'";
            if(!Objc.EjecutarSentencia(sentencia, false))
            {
                error = Objc.Error;
                Objc=null;
                return false;
            }
            else
            {
                error = "se elimino el cliente correctamente";
                Objc = null;
                return true;

            }
        }
        public bool ConsultarCliente()
        {
            ClsConexion ObjV = new ClsConexion();
            String Sencentica = "EXECUTE USP_ConsultarCliente '" + idcliente + "'";
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
        public bool listarCliente(DataGridView objD)
        {
            ClsLlenarGrid ObjG = new ClsLlenarGrid();
            ObjG.NombreTabla = "DatosEmpleados";
            ObjG.SQL = "USP_ListarCliente";

            if (!ObjG.LlenarGrid(objD))
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
        #endregion

    }
}
