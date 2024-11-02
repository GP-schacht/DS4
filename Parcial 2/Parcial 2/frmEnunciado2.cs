using Parcial_2.metodos;
using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmEnunciado2 : Form
    {
        Querys consulta = new Querys();
        MetodosGenerales metodos = new MetodosGenerales();
        private string rutas;
       
        public frmEnunciado2()
        {
            InitializeComponent();
            metodos.Conexion conexion = new metodos.Conexion();
            conexion.Conectar();
        }

        private void frmEnunciado2_Load(object sender, EventArgs e)
        {

            cbOpcion1.Items.Add("Modificar");
            cbOpcion1.Items.Add("Agregar");

            cbOpcion2.Items.Add("Vender");
            cbOpcion2.Items.Add("Reabastecer");

            consulta.CargarMedicamentos(cbMed1);
            consulta.CargarMedicamentos(cbMed2);


        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbOpcion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOpcion1.SelectedIndex)
            {
                case 0:
                    cbMed1.Visible = true;
                    cbMed1.Enabled = true;
                    break;

                case 1:
                    cbMed1.Visible = false;
                    cbMed1.Enabled = false;
                    break;
            }
        }

        private void btnAdd_img_Click(object sender, EventArgs e)
        {
            metodos.selectFoto(pictureBox1, out string? ruta);
            rutas = ruta.ToString();
        }



        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Int32 cantidad;
            double precio;

            // Validar que los campos de cantidad y precio sean válidos
            if (!Int32.TryParse(txtCantidad1.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            // Verificar qué opción está seleccionada en el ComboBox
            if (cbOpcion1.SelectedItem != null && cbOpcion1.SelectedItem.ToString() == "Modificar")
            {

                if (cbMed1.SelectedItem != null)
                {
                    string nombre1 = cbMed1.SelectedItem.ToString();
                    consulta.Mod(nombre1, nombre, cantidad, precio);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un medicamento para modificar.");
                }
            }
            else if (cbOpcion1.SelectedItem != null && cbOpcion1.SelectedItem.ToString() == "Agregar")
            {
                consulta.Add(nombre, cantidad, precio);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción válida.");
            }


            consulta.Stock(dgvInventario);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            // validar seleccion
            if (cbMed2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un medicamento para Vender o Reabastecer.");
                return;
            }

            string nombre = cbMed2.SelectedItem.ToString();
            int stock;

            // Obtener medicamento disponible
            consulta.GetCantidad(cbMed2, out int? ctd);
            stock = ctd ?? 0; 

            // Validar  campos 
            if (!int.TryParse(txtCantidad2.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            // Verificar qué opción está seleccionada en el ComboBox
            if (cbOpcion2.SelectedItem != null)
            {
                int fn = cbOpcion2.SelectedItem.ToString() == "Vender" ? 1 : 0;

                if ((fn == 1 && cantidad > stock))
                {
                    MessageBox.Show("Stock insuficiente.");
                    return;
                }

                consulta.Transact(nombre, cantidad, stock, fn);
                consulta.Stock(dgvInventario);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción válida.");
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMed2_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.Stock(dgvInventario);
        }
    }
}
