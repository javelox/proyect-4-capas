using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNventascarolina;

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
            Cliente Obje = new Cliente();
            try
            {
                String id_vendedor, nombre_vendedor, apellido_vendedor, telefono_vendedor, correo_electronico, direccion_vendedor;

                id_vendedor = txtidcliente.Text;
                nombre_vendedor = txtnombrecliente.Text;
                apellido_vendedor = txtapellidocliente.Text;
                telefono_vendedor = txttelefonocliente.Text;
                correo_electronico = txtcorreocliente.Text;
                direccion_vendedor = txtdireccioncliente.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Idcliente = id_vendedor;
                Obje.Nombrecliente = nombre_vendedor;
                Obje.Apellidocliente = apellido_vendedor;
                Obje.Telefonocliente = telefono_vendedor;
                Obje.Correocliente = correo_electronico;
                Obje.Direccioncliente = direccion_vendedor;

                if (!Obje.GrabarCliente())
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    return;
                }
                else
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    listar();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnactualizarcliente_Click(object sender, EventArgs e)
        {
            Cliente Obje = new Cliente();
            try
            {
                String id_cliente, nombre_cliente, apellido_cliente, telefono_cliente, correo_electronico, direccion_cliente;

                id_cliente = txtidcliente.Text;
                nombre_cliente = txtnombrecliente.Text;
                apellido_cliente = txtapellidocliente.Text;
                telefono_cliente = txttelefonocliente.Text;
                correo_electronico = txtcorreocliente.Text;
                direccion_cliente = txtdireccioncliente.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Idcliente = id_cliente;
                Obje.Nombrecliente = nombre_cliente;
                Obje.Apellidocliente = apellido_cliente;
                Obje.Telefonocliente = telefono_cliente;
                Obje.Correocliente = correo_electronico;
                Obje.Direccioncliente = direccion_cliente;

                if (!Obje.ActualizarCliente())
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    return;
                }
                else
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    listar();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btneliminarcliente_Click(object sender, EventArgs e)
        {
            Cliente Obje = new Cliente();
            try
            {
                String id_cliente;
                id_cliente = txtidcliente.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Idcliente = id_cliente;

                if (!Obje.EliminarCliente())
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    return;
                }
                else
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    listar();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnconsultarcliente_Click(object sender, EventArgs e)
        {
            Cliente Obje = new Cliente();
            try
            {
                String id_cliente;
                SqlDataReader reader;
                id_cliente = txtidcliente.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Idcliente = id_cliente;

                if (!Obje.ConsultarCliente())
                {
                    MessageBox.Show(Obje.Error);
                    Obje = null;
                    return;
                }
                else
                {
                    reader = Obje.Reader;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void listar()
        {
            Cliente Obje = new Cliente();
            if (!Obje.listarCliente(dgvcliente))
            {
                MessageBox.Show(Obje.Error);
                return;
            }
        }

        private void btnlistarcliente_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
