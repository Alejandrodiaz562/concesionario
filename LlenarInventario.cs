using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class LlenarInventario : Form
    {
        List<Inventario> inventario = new List<Inventario>();
        List<Vendedor> vendedores = new List<Vendedor>();
        Boolean primeraVez;
        public LlenarInventario(List<Inventario> a, List<Vendedor> b, Boolean c)
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            btnTerminar.Visible = false;
            inventario = a;
            vendedores = b;
            primeraVez = c;

            if (inventario.Count != 0)
            {
                btnTerminar.Visible = true;
            }
        }

        private void LlenarInventario_Load(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if(txtModelo.Text != "" && txtValor.Text != "" && txtCantidad.Text != "")
            {
                btnAgregar.Enabled = true;
            } else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtModelo.Text != "" && txtValor.Text != "" && txtCantidad.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtModelo.Text != "" && txtValor.Text != "" && txtCantidad.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int index = inventario.FindIndex(m => m.modelo == txtModelo.Text);
            if (index == -1)
            {
                inventario.Add(new Inventario()
                {
                    modelo = txtModelo.Text,
                    valor = double.Parse(txtValor.Text),
                    cantidad = int.Parse(txtCantidad.Text)
                });
            } else
            {
                string auxModelo = inventario[index].modelo;
                int auxCantidad = inventario[index].cantidad;
                inventario[index] = new Inventario()
                {
                    modelo = auxModelo,
                    valor = double.Parse(txtValor.Text),
                    cantidad = int.Parse(txtCantidad.Text) + auxCantidad
                };
            }

            if (inventario.Count != 0)
            {
                btnTerminar.Visible = true;
            }

            txtModelo.Text = "";
            txtValor.Text = "";
            txtCantidad.Text = "";
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if(primeraVez == true)
            {
                AgregarVendedor AG1 = new AgregarVendedor(inventario, vendedores);
                AG1.Show();
                this.Hide();
            } else
            {
                Menu M1 = new Menu(inventario, vendedores);
                M1.Show();
                this.Hide();
            }
        }
    }
}
