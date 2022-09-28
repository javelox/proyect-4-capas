using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNventascarolina;
using System.Data;
using System.Data.SqlClient;


namespace MDIventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente Objc = new Cliente();
            try
            {
                string idcliente, nombre, apellido, telefono, correo, direccion;

                idcliente = txtidcliente.Text;
                nombre = txtnombrecliente.Text;
                apellido = txtapellidocliente.Text;
                telefono = txttelefonocliente.Text;
                correo = txtcorreocliente.Text;
                direccion = txtdireccioncliente.Text;

                Objc.Idcliente = idcliente;
                Objc.Nombrecliente = nombre;
                Objc.Apellidocliente = apellido;
                Objc.Telefonocliente = telefono;
                Objc.Correocliente = correo;
                Objc.Direccioncliente = direccion;
                if (!Objc.GrabarCliente())
                {
                    MessageBox.Show(Objc.Error);
                    Objc = null;
                    return;
                }
                MessageBox.Show(Objc.Error);
                Listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnactualizarcliente_Click(object sender, EventArgs e)
        {
            Cliente Objc = new Cliente();
            try
            {
                string idcliente, nombre, apellido, telefono, correo, direccion;

                idcliente = txtidcliente.Text;
                nombre = txtnombrecliente.Text;
                apellido = txtapellidocliente.Text;
                telefono = txttelefonocliente.Text;
                correo = txtcorreocliente.Text;
                direccion = txtdireccioncliente.Text;

                Objc.Idcliente = idcliente;
                Objc.Nombrecliente = nombre;
                Objc.Apellidocliente = apellido;
                Objc.Telefonocliente = telefono;
                Objc.Correocliente = correo;
                Objc.Direccioncliente = direccion;

                if (!Objc.ActualizarCliente())
                {
                    MessageBox.Show(Objc.Error);
                    Objc = null;
                    return;
                }
                MessageBox.Show(Objc.Error);
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btneliminarcliente_Click(object sender, EventArgs e)
        {
            Cliente Objc = new Cliente();
            try
            {
                string idcliente;

                idcliente = txtidcliente.Text;

                Objc.Idcliente = idcliente;

                if (!Objc.EliminarCliente())
                {
                    MessageBox.Show(Objc.Error);
                    Objc = null;
                    return;
                }
                MessageBox.Show(Objc.Error);
                Listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnconsultarcliente_Click(object sender, EventArgs e)
        {
            Cliente Objc = new Cliente();
            try
            {
                string idcliente;
                SqlDataReader reader;

                idcliente = txtidcliente.Text;

                Objc.Idcliente = idcliente;

                if (!Objc.ConsultarCliente())
                {
                    MessageBox.Show(Objc.Error);
                    Objc = null;
                    return;
                }
                else
                {
                    reader = Objc.Reader;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtnombrecliente.Text = reader.GetString(1);
                        txtapellidocliente.Text = reader.GetString(2);
                        txttelefonocliente.Text = reader.GetString(3);
                        txtcorreocliente.Text = reader.GetString(4);
                        txtdireccioncliente.Text = reader.GetString(5);
                        reader.Close();
                    }
                    Listar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnlistarcliente_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            Cliente Objc = new Cliente();
            if (!Objc.listarCliente(dgvcliente))
            {
                MessageBox.Show(Objc.Error);
                return;
            }
        }
    }
}
