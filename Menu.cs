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
    public partial class Menu : Form
    {
        List<Inventario> inventario = new List<Inventario>();
        List<Vendedor> vendedores = new List<Vendedor>();
        public Menu(List<Inventario> a, List<Vendedor> b)
        {
            InitializeComponent();
            inventario = a;
            vendedores = b;

            foreach (Inventario moto in inventario)
            {
                ListViewItem item = new ListViewItem(moto.modelo);
                item.SubItems.Add(moto.valor.ToString());
                item.SubItems.Add(moto.cantidad.ToString());
                if (moto.cantidad < 10)
                {
                    item.BackColor = System.Drawing.Color.Red;
                }
                lvInventario.Items.Add(item);
            }

            foreach (Vendedor vendedor in vendedores)
            {
                ListViewItem item = new ListViewItem(vendedor.cedula.ToString());
                item.SubItems.Add(vendedor.nombre);
                item.SubItems.Add(vendedor.totalVendido.ToString());
                lvVendedores.Items.Add(item);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            LlenarInventario llenarInventario = new LlenarInventario(inventario, vendedores, false);
            llenarInventario.Show();
            this.Hide();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            AgregarVendedor AG1 = new AgregarVendedor(inventario, vendedores);
            AG1.Show();
            this.Hide();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Venta V1 = new Venta(inventario, vendedores);
            V1.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VerVentas VV1 = new VerVentas(inventario, vendedores);
            VV1.Show();
            this.Hide();
        }
    }
}
