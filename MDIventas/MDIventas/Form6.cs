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
using LibLNCategoria;

namespace MDIventas
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnguardarcategoria_Click(object sender, EventArgs e)
        {
            Categoria ObjC = new Categoria();

            try
            {
                string idcategoria, nombrecategoria;

                idcategoria = txtidcategoria.Text;
                nombrecategoria = txtnombrecategoria.Text;

                ObjC.Id_categoria = idcategoria;
                ObjC.Nombre_categoria = nombrecategoria;

                if (!ObjC.insertarcategoria())
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
                    return;
                }
                else
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
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

        private void btnactualizarcategoria_Click(object sender, EventArgs e)
        {
            Categoria ObjC = new Categoria();

            try
            {
                string idcategoria, nombrecategoria;

                idcategoria = txtidcategoria.Text;
                nombrecategoria = txtnombrecategoria.Text;

                ObjC.Id_categoria = idcategoria;
                ObjC.Nombre_categoria = nombrecategoria;

                if (!ObjC.actualizarcategoria())
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
                    return;
                }
                else
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
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

        private void btneliminarcategoria_Click(object sender, EventArgs e)
        {
            Categoria ObjC = new Categoria();
            try
            {
                string idcategoria;
                idcategoria = txtidcategoria.Text;
                ObjC.Id_categoria = idcategoria;

                if (!ObjC.eliminarcategoria())
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
                    return;
                }
                else
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
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

        private void btnconsultarcategoria_Click(object sender, EventArgs e)
        {
            Categoria ObjC = new Categoria();

            try
            {
                string idcategoria;
                SqlDataReader reader;

                idcategoria = txtidcategoria.Text;

                ObjC.Id_categoria = idcategoria;

                if (!ObjC.consultarcategoria())
                {
                    MessageBox.Show(ObjC.Error);
                    ObjC = null;
                    return;
                }
                else
                {
                    reader = ObjC.Reader;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtidcategoria.Text = reader.GetString(1);
                        txtnombrecategoria.Text = reader.GetString(2);
                        reader.Close();
                    }
                    listar();
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
            Categoria ObjC = new Categoria();
            if (!ObjC.listarcategoria(dgvcategoria))
            {
                MessageBox.Show(ObjC.Error);
                return;
            }
        }

        private void btnlistarcategoria_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
