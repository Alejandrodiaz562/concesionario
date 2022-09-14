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
    public partial class VerVentas : Form
    {
        List<Inventario> inventario = new List<Inventario>();
        List<Vendedor> vendedores = new List<Vendedor>();
        public VerVentas(List<Inventario> a, List<Vendedor> b)
        {
            InitializeComponent();

            inventario = a;
            vendedores = b;

            btnConsultar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            btnConsultar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int index = vendedores.FindIndex(v => v.cedula == int.Parse(txtCedula.Text));

            if (index == -1)
            {
                MessageBox.Show("Vendedor no existe", "Error");
                txtCedula.Text = "";
                btnConsultar.Enabled = false;
            } else
            {
                lblVenta.Text = "Ventas de " + vendedores[index].nombre;

                if(vendedores[index].ventas.Count == 0)
                {
                    MessageBox.Show("Vendedor " + vendedores[index].nombre + " sin ventas", "Alerta");
                    txtCedula.Text = "";
                    btnConsultar.Enabled = false;
                } else
                {
                    foreach (Inventario venta in vendedores[index].ventas)
                    {
                        ListViewItem item = new ListViewItem(venta.modelo);
                        item.SubItems.Add(venta.valor.ToString());
                        item.SubItems.Add(venta.cantidad.ToString());
                        item.SubItems.Add((venta.valor * venta.cantidad).ToString());
                        lvVentas.Items.Add(item);
                    }
                    btnLimpiar.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvVentas.Items.Clear();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Menu M1 = new Menu(inventario, vendedores);
            M1.Show();
            this.Hide();
        }
    }
}
