using Sesion17.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion17.Modelos;

namespace Sesion17.Formulario
{
    public partial class Productofrm : Form
    {
        //crear un objeto de la calase producto

        //se crea la variuable, se crea un metodo para crear los bjetos

        //una variable es cuando pongo lel tipo de dato, un objeto es cuando hago una instancia es crear un nuevo objeto partiendo de una plantilla, jeto en este caso es productos 

        ProductoServicio productos = new ProductoServicio();
        
        public ;;


        public Productofrm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Producto prod = new Producto();
            prod.ID = int.Parse(tbId.Text);

            prod.Name = tbNombre.Text;

            prod.Description = tbDescipcion.Text;

            prod.Precio = double.Parse(tbPrecio.Text);

            Productos.AgregarProductos(prod);




        }

        //metodo

        private void MostrarRegistros()
        {
            dgvRegitros.DataSource  = null;
            dgvRegitros.DataSource = productos.Productos();
        }
    }
}
