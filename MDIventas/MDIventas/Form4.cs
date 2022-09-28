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
using LibLNfactura;

namespace MDIventas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Factura Objf = new Factura();
            try
            {
                String id_factura, fecha, id_cliente, id_vendedor, id_producto;
                double subtotal, iva, total, valor_total;
                int cantidad_producto;

                id_factura = txtnro.Text;
                fecha = txtfecha.Text;
                id_cliente = txtcliente.Text;
                id_vendedor = txtvendedor.Text;
                id_producto = txtproducto.Text;
                subtotal = Convert.ToDouble(txtsubtotal.Text);
                iva = Convert.ToDouble(txtiva.Text);
                total = Convert.ToDouble(txttotal.Text);
                valor_total = Convert.ToDouble(txtvalortotal.Text);
                cantidad_producto = Convert.ToInt32(txtcantidad.Text);

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Objf.Id_factura = id_factura;
                Objf.Fecha = fecha;
                Objf.Id_cliente = id_cliente;
                Objf.Id_vendedor = id_vendedor;
                Objf.Id_producto = id_producto;
                Objf.Subtotal = subtotal;
                Objf.Iva = iva;
                Objf.Total = total;
                Objf.Valor_total = valor_total;
                Objf.Cantidad_producto = cantidad_producto;

                if (!Objf.grabarFactura())
                {
                    MessageBox.Show(Objf.Error);
                    Objf = null;
                    return;
                }
                else
                {
                    MessageBox.Show(Objf.Error);
                    Objf = null;
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Factura Objf = new Factura();
            try
            {
                String id_factura;
                SqlDataReader reader;
                id_factura = txtnro.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                Objf.Id_factura = id_factura;

                if (!Objf.ConsultarFactura())
                {
                    MessageBox.Show(Objf.Error);
                    Objf = null;
                    return;
                }
                else
                {
                    reader = Objf.Reader;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtfecha.Text = reader.GetString(1);
                        txtsubtotal.Text = reader.GetFloat(2).ToString();
                        txtiva.Text = reader.GetFloat(3).ToString();
                        txttotal.Text = reader.GetDouble(4).ToString();
                        txtcliente.Text = reader.GetString(5);
                        txtvendedor.Text = reader.GetString(6);
                        txtcodigo.Text = reader.GetString(8);
                        txtcantidad.Text = reader.GetInt32(9).ToString();
                        txtvalortotal.Text = reader.GetFloat(10).ToString();
                        txtproducto.Text = reader.GetString(12);
                        txtvalor.Text = reader.GetFloat(13).ToString();
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

        private void btnlistar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            Factura Obje = new Factura();
            if (!Obje.listarFactura(dgvdatos))
            {
                return;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
