using ScottPlot.Plottables;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tesseract;


namespace Parcial_2.metodos
{
    internal class MetodosGenerales
    {
        public void selectFoto(PictureBox pbox, out string? ruta)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(openFD.FileName);
                ruta = openFD.FileName;

            }
            else { ruta = null; }
        }

        // llevar la imagen a la BD
        public void agregarFoto(string ruta)
        {



            try
            {
                string tessDataPath = @"./";

                using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(ruta))
                    {
                        using (var page = engine.Process(img))
                        {
                            //txtResult.Text = page.GetText();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al copiar el archivo: {ex.Message}");
            }

        }
    }
}
