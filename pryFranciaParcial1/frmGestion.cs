using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryFranciaParcial1
{
    public partial class frmGestion : Form
    {

        
        clsArticulo[] articulos;
        int cantidad;
        double total;

        
        public frmGestion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("ARTICULOS_EXPORTADOS.csv");

            for (int i = 0; i < articulos.Length; i++)
            {
                archivo.WriteLine(
                    articulos[i].Codigo + ";" +
                    articulos[i].Descripcion + ";" +
                    articulos[i].Costo + ";" +
                    articulos[i].Rubro + ";" +
                    articulos[i].Stock
                );
            }

            archivo.Close();

            MessageBox.Show("Archivo exportado correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvArticulos.Rows.Clear();

            cantidad = 0;
            total = 0;

            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].Rubro == cmbRubro.Text)
                {
                    double valorStock;

                    valorStock = articulos[i].Costo * articulos[i].Stock;

                    dgvArticulos.Rows.Add(
                        articulos[i].Codigo,
                        articulos[i].Descripcion,
                        articulos[i].Costo,
                        articulos[i].Stock,
                        valorStock
                    );

                    cantidad++;
                    total = total + valorStock;
                }
            }

            lblCantidad.Text = cantidad.ToString();
            lblTotal.Text = total.ToString();



 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmGestion_Load(object sender, EventArgs e)
        {

            StreamReader archivoRubros = new StreamReader("RUBROS.csv");

            cmbRubro.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                string rubro = archivoRubros.ReadLine();

                cmbRubro.Items.Add(rubro);
            }

            archivoRubros.Close();


            StreamReader archivoArticulos = new StreamReader("ARTICULOS.csv");

            articulos = new clsArticulo[12];

            for (int i = 0; i < 12; i++)
            {
                string linea = archivoArticulos.ReadLine();

                string[] datos = linea.Split(';');

                clsArticulo articulo = new clsArticulo();

                articulo.Codigo = datos[0];
                articulo.Descripcion = datos[1];
                articulo.Costo = Convert.ToDouble(datos[2]);
                articulo.Rubro = datos[3];
                articulo.Stock = Convert.ToInt32(datos[4]);

                articulos[i] = articulo;
            }

            archivoArticulos.Close();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
