using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Inventario> inventario = new List<Inventario>();
            List<Vendedor> vendedores = new List<Vendedor>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LlenarInventario(inventario, vendedores, true));

            /*
            vendedores.Add(new Vendedor() {cedula=1234, nombre="Frank", totalVendido=0});
            vendedores.Add(new Vendedor() { cedula = 44456, nombre = "Jose", totalVendido = 0 });

            vendedores[0].agregarVenta("yz", 5);

            foreach (Vendedor vendedor in vendedores)
            {
                Console.WriteLine(vendedor.cedula);
                Console.WriteLine(vendedor.nombre);
                Console.WriteLine(vendedor.totalVendido);
                foreach (InventarioVendedor ventas in vendedor.ventas)
                {
                    Console.WriteLine(ventas.modelo);
                    Console.WriteLine(ventas.cantidad);
                }
            }

            Console.WriteLine("");

            int elementIndex = vendedores.FindIndex(i => i.cedula == 1234);
            vendedores[elementIndex].agregarVenta("yz", 5);
            vendedores[elementIndex].agregarVenta("rx115", 5);

            int indexJose = vendedores.FindIndex(i => i.cedula == 44456);
            vendedores[indexJose].agregarVenta("yz", 5);

            foreach (Vendedor vendedor in vendedores)
            {
                Console.WriteLine(vendedor.cedula);
                Console.WriteLine(vendedor.nombre);
                Console.WriteLine(vendedor.totalVendido);
                foreach (InventarioVendedor ventas in vendedor.ventas)
                {
                    Console.WriteLine(ventas.modelo);
                    Console.WriteLine(ventas.cantidad);
                }
            }
            */
        }
    }
}
