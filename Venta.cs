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
    public partial class Venta : Form
    {
        List<Inventario> inventario = new List<Inventario>();
        List<Vendedor> vendedores = new List<Vendedor>();
        double total;
        public Venta(List<Inventario> a, List<Vendedor> b)
        {
            InitializeComponent();
            inventario = a;
            vendedores = b;
            btnAceptar.Enabled = false;
            total = 0;
            lblTotal.Text = total.ToString();
            txtModelo.Enabled = false;
            TxtCantidad.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int indexModelo = inventario.FindIndex(m => m.modelo == txtModelo.Text);
            int indexVendedor = vendedores.FindIndex(v => v.cedula == int.Parse(txtCedula.Text));

            inventario[indexModelo].cantidad -= int.Parse(TxtCantidad.Text);

            vendedores[indexVendedor].totalVendido += total;

            vendedores[indexVendedor].agregarVenta(
                txtModelo.Text, inventario[indexModelo].valor, int.Parse(TxtCantidad.Text));

            Menu M1 = new Menu(inventario, vendedores);
            M1.Show();
            this.Hide();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text != "")
            {
                int index = vendedores.FindIndex(v => v.cedula == int.Parse(txtCedula.Text));

                if (index == -1)
                {
                    ep1.SetError(txtCedula, "El vendedor no se encuentra registrado");
                    txtModelo.Text = "";
                    txtModelo.Enabled = false;
                    btnAceptar.Enabled = false;
                    ep1.SetError(txtModelo, null);
                }
                else
                {
                    txtModelo.Enabled = true;
                    ep1.SetError(txtCedula, null);
                }
            }
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if (txtModelo.Text != "")
            {
                int index = inventario.FindIndex(m => m.modelo == txtModelo.Text);

                if (index == -1)
                {
                    ep1.SetError(txtModelo, "Modelo no registrado");
                    TxtCantidad.Text = "";
                    TxtCantidad.Enabled = false;
                    btnAceptar.Enabled = false;
                    ep1.SetError(TxtCantidad, null);
                }
                else
                {
                    TxtCantidad.Enabled = true;
                    ep1.SetError(txtModelo, null);
                }
            }
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (TxtCantidad.Text != "")
            {
                int index = inventario.FindIndex(m => m.modelo == txtModelo.Text);
                int cantidadDisponible = inventario[index].cantidad;

                if (int.Parse(TxtCantidad.Text) > 0 && int.Parse(TxtCantidad.Text) <= cantidadDisponible)
                {
                    total = inventario[index].valor * int.Parse(TxtCantidad.Text);
                    lblTotal.Text = total.ToString();
                    btnAceptar.Enabled = true;
                    ep1.SetError(TxtCantidad, null);
                }
                else
                {
                    ep1.SetError(TxtCantidad, "Unidades disponibles " + cantidadDisponible);
                    btnAceptar.Enabled = false;
                }
            } else
            {
                lblTotal.Text = 0.ToString();
                btnAceptar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Menu M1 = new Menu(inventario, vendedores);
            M1.Show();
            this.Hide();
        }
    }
}
