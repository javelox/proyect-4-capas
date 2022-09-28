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
using LibLNvendedor;

namespace MDIventas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnguardarvendedor_Click(object sender, EventArgs e)
        {
            Vendedor Obje = new Vendedor();
            try
            {
                String id_vendedor, nombre_vendedor, apellido_vendedor, telefono_vendedor, correo_electronico, direccion_vendedor;

                id_vendedor = txtidvendedor.Text;
                nombre_vendedor = txtnombrevendedor.Text;
                apellido_vendedor = txtapellidovendedor.Text;
                telefono_vendedor = txttelefonovendedor.Text;
                correo_electronico = txtcorreocliente.Text;
                direccion_vendedor = txtdireccioncliente.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Id_vendedor = id_vendedor;
                Obje.Nombre_vendedor = nombre_vendedor;
                Obje.Apellido_vendedor = apellido_vendedor;
                Obje.Telefono_vendedor = telefono_vendedor;
                Obje.Correo_electronico = correo_electronico;
                Obje.Direccion_vendedor = direccion_vendedor;

                if (!Obje.grabarVendedor())
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

        private void btnactualizarvendedor_Click(object sender, EventArgs e)
        {
            Vendedor Obje = new Vendedor();
            try
            {
                String id_vendedor, nombre_vendedor, apellido_vendedor, telefono_vendedor, correo_electronico, direccion_vendedor;

                id_vendedor = txtidvendedor.Text;
                nombre_vendedor = txtnombrevendedor.Text;
                apellido_vendedor = txtapellidovendedor.Text;
                telefono_vendedor = txttelefonovendedor.Text;
                correo_electronico = txtcorreocliente.Text;
                direccion_vendedor = txtdireccioncliente.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Id_vendedor = id_vendedor;
                Obje.Nombre_vendedor = nombre_vendedor;
                Obje.Apellido_vendedor = apellido_vendedor;
                Obje.Telefono_vendedor = telefono_vendedor;
                Obje.Correo_electronico = correo_electronico;
                Obje.Direccion_vendedor = direccion_vendedor;

                if (!Obje.actualizarVendedor())
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

        private void btneliminarvendedor_Click(object sender, EventArgs e)
        {
            Vendedor Obje = new Vendedor();
            try
            {
                String id_vendedor;
                id_vendedor = txtidvendedor.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Id_vendedor = id_vendedor;

                if (!Obje.eliminarVendedor())
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

        private void btnconsultarvendedor_Click(object sender, EventArgs e)
        {
            Vendedor Obje = new Vendedor();
            try
            {
                String id_vendedor;
                SqlDataReader reader;
                id_vendedor = txtidvendedor.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Obje.Id_vendedor = id_vendedor;

                if (!Obje.ConsultarVendedor())
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
                        txtnombrevendedor.Text = reader.GetString(1);
                        txtapellidovendedor.Text = reader.GetString(2);
                        txttelefonovendedor.Text = reader.GetString(3);
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

        private void btnlistarvendedor_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            Vendedor Obje = new Vendedor();
            if (!Obje.listarVendedor(dgvvendedor))
            {
                MessageBox.Show(Obje.Error);
                return;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
