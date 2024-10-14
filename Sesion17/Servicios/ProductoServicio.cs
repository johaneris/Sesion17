using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion17.Modelos;
using NLog;
namespace Sesion17.Servicios
{
    internal class ProductoServicio
    {


        List<Producto> productos = new List<Producto>();
       

        //metodo
        public void Agregarproducto(Producto producto)
        {
            productos.Add(producto);
        }
        //lamda funcion anonima que no teiene nombre, tien e valor de retorno y de bsusqueda\

        public Producto BuscarProducto(Producto producto)
        {
            return productos.Find(prod => prod.ID == producto.ID);
        }
        public void EliminarProducto(Producto producto, Logger logger)
        {
            try
            {
                productos.Remove(producto);
            }catch(Exception ex)
            {
                logger.Error(ex, "esta malo");

                MessageBox.Show($"Error eliminando el producto: {ex.Message}");


            }
        }

        public void ActualizarProducto(Producto producto, int id)
        {
            int index = productos.FindIndex(prod => prod.ID == id);

            if(index != -1)
            {
                productos[index] = producto;
            }
            {
                MessageBox.Show("no exuiste el producto");
            }
        }

            
    }
}
