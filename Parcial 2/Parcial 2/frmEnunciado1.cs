using Parcial_2.metodos;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Parcial_2
{
    public partial class frmEnunciado1 : Form
    {
        public frmEnunciado1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrado2.Checked == true)
            {
                btnResult.Location = new Point(24, 263);
                lblC.Visible = true;
                lblC.Enabled = true;
                txtCampoC.Visible = true;
                txtCampoC.Enabled = true;

                pbCuadratica.Visible = true;
                pbLineal.Visible = false;

                lblx1.Visible = true;
                lblx2.Visible = true;
                txtX1.Visible = true;
                txtX2.Visible = true;

                lblx.Visible = false;
                txtX.Visible = false;


            }
            else
            {
                btnResult.Location = new Point(24, 206);
                lblC.Visible = false;
                lblC.Enabled = false;
                txtCampoC.Visible = false;
                txtCampoC.Enabled = false;

                pbLineal.Visible = true;
                pbCuadratica.Visible = false;

                lblx1.Visible = false;
                lblx2.Visible = false;
                txtX1.Visible = false;
                txtX2.Visible = false;

                lblx.Visible = true;
                txtX.Visible = true;
                lblx.Enabled = true;

            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtCampoA.Text);
                double B = Convert.ToDouble(txtCampoB.Text);
                double C = 0;


                if (chkGrado2.Checked == true)
                {
                    if (txtCampoA.Text == "0" || txtCampoA.Text == string.Empty)

                    {
                        MessageBox.Show("Campo A obligatorio", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        C = Convert.ToDouble(txtCampoC.Text);

                        ecuaciones ecuaciones = new(A, B, C);
                        ecuaciones.resolver2G(out double? x1, out double? x2);

                        fpGrafica.Reset();

                        ecuaciones.graficar1G(2, out double[] Xs, out double[] Ys);
                        fpGrafica.Plot.Add.Scatter(Xs, Ys);
                        fpGrafica.Refresh();

                        txtX1.Text = x1.ToString();
                        txtX2.Text = x2.ToString();





                    }
                }

                else
                {
                    fpGrafica.Reset();
                    ecuaciones ecuaciones = new(A, B, C);

                    double[] Xs;
                    double[] Ys;
                    ecuaciones.graficar1G(1, out Xs, out Ys);
                    fpGrafica.Plot.Add.Scatter(Xs, Ys);
                    fpGrafica.Refresh();
                    ecuaciones.resolver1G(out double? x);
                    txtX.Text = x.ToString();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show(" Use el formato correcto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbLineal_Click(object sender, EventArgs e)
        {

        }

        private void frmEnunciado1_Load(object sender, EventArgs e)
        {

        }
    }
}
