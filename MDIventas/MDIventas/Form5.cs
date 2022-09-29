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
using LibLNproducto;

namespace MDIventas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnguardarproducto_Click(object sender, EventArgs e)
        {
            Producto ObjP = new Producto();
            try
            {
                String idproducto, nombreproducto, idcategoria;
                double valorproducto;
                int cantidadproducto;

                idproducto = txtidproducto.Text;
                nombreproducto = txtnombreproducto.Text;
                valorproducto = Convert.ToDouble(txtvalorproducto.Text);
                cantidadproducto = Convert.ToInt32(txtcantidadbodegaproducto.Text);
                idcategoria = txtidcategoriaproducto.Text;

                ObjP.Id_producto = idproducto;
                ObjP.Nombre_producto = nombreproducto;
                ObjP.Valor_producto = valorproducto;
                ObjP.Cantidad_bodega = cantidadproducto;
                ObjP.Id_categoria = idcategoria;

                if (!ObjP.grabarproducto())
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
                    return;
                }
                else
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
                    listar();
                    return;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnactualizarproducto_Click(object sender, EventArgs e)
        {
            Producto ObjP = new Producto();
            try
            {
                String idproducto, nombreproducto, idcategoria;
                double valorproducto;
                int cantidadproducto;

                idproducto = txtidproducto.Text;
                nombreproducto = txtnombreproducto.Text;
                valorproducto = Convert.ToDouble(txtvalorproducto.Text);
                cantidadproducto = Convert.ToInt32(txtcantidadbodegaproducto.Text);
                idcategoria = txtidcategoriaproducto.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO



                ObjP.Id_producto = idproducto;
                ObjP.Nombre_producto = nombreproducto;
                ObjP.Valor_producto = valorproducto;
                ObjP.Cantidad_bodega = cantidadproducto;
                ObjP.Id_categoria = idcategoria;

                if (!ObjP.actualizarproducto())
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
                    return;
                }
                else
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
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

        private void btnlistarproducto_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            Producto ObjP = new Producto();
            if (!ObjP.listarproducto(dgvproducto))
            {
                MessageBox.Show(ObjP.Error);
                return;
            }
        }

        private void btnconsultarproducto_Click(object sender, EventArgs e)
        {
            Producto ObjP = new Producto();
            try
            {
                String idproducto;
                SqlDataReader reader;
                idproducto = txtidproducto.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                ObjP.Id_producto = idproducto;

                if (!ObjP.consultarproducto())
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
                    return;
                }
                else
                {
                    reader = ObjP.Reader;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtnombreproducto.Text = reader.GetString(1);
                        txtvalorproducto.Text = reader.GetFloat(2).ToString();
                        txtcantidadbodegaproducto.Text = reader.GetInt32(3).ToString();
                        txtidcategoriaproducto.Text = reader.GetString(4);
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

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            Producto ObjP = new Producto();
            try
            {
                String idproducto;
                idproducto = txtidproducto.Text;

                //Enviar DATOS a la LOGICA DE NEGOCIO

                ObjP.Id_producto = idproducto;

                if (!ObjP.eliminarproducto())
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
                    return;
                }
                else
                {
                    MessageBox.Show(ObjP.Error);
                    ObjP = null;
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

        private void Form5_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
