using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Vendedor
    {
        public int cedula;
        public string nombre { get; set; }
        public double totalVendido { get; set; }

        public List<Inventario> ventas = new List<Inventario>();

        public void agregarVenta (string modeloVendido, double valorModelo, int cantidadesVendidas)
        {
            ventas.Add(new Inventario() { modelo = modeloVendido, valor = valorModelo , cantidad = cantidadesVendidas });
        }
    }
}
