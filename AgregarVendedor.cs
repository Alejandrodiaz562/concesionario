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
    public partial class AgregarVendedor : Form
    {

        List<Inventario> inventario = new List<Inventario>();
        List<Vendedor> vendedores = new List<Vendedor>();

        public AgregarVendedor(List<Inventario> a, List<Vendedor> b)
        {
            InitializeComponent();
            btnTerminar.Visible = false;
            btnAgregar.Enabled = false;
            inventario = a;
            vendedores = b;

            if (vendedores.Count != 0)
            {
                btnTerminar.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int index = vendedores.FindIndex(v => v.cedula == int.Parse(txtCedula.Text));

            if (index == -1)
            {
                vendedores.Add(new Vendedor()
                {
                    cedula = int.Parse(txtCedula.Text),
                    nombre = txtNombre.Text,
                    totalVendido = 0,
                });
            } else
            {
                MessageBox.Show("Vendedor ya existe", "Error");
            }

            if (vendedores.Count != 0)
            {
                btnTerminar.Visible = true;
            }

            txtCedula.Text = "";
            txtNombre.Text = "";
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Menu M1 = new Menu(inventario, vendedores);
            M1.Show();
            this.Hide();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if(txtCedula.Text != "" && txtNombre.Text != "")
            {
                btnAgregar.Enabled = true;
            } else
            {
                btnAgregar.Enabled  = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtNombre.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void AgregarVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
