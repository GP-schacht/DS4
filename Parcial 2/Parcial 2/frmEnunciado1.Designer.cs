namespace Parcial_2
{
    partial class frmEnunciado1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnunciado1));
            lblA = new System.Windows.Forms.Label();
            lblB = new System.Windows.Forms.Label();
            lblC = new System.Windows.Forms.Label();
            txtCampoA = new System.Windows.Forms.TextBox();
            txtCampoB = new System.Windows.Forms.TextBox();
            txtCampoC = new System.Windows.Forms.TextBox();
            lblx1 = new System.Windows.Forms.Label();
            lblx2 = new System.Windows.Forms.Label();
            txtX1 = new System.Windows.Forms.TextBox();
            txtX2 = new System.Windows.Forms.TextBox();
            chkGrado2 = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            pbCuadratica = new System.Windows.Forms.PictureBox();
            pbLineal = new System.Windows.Forms.PictureBox();
            fpGrafica = new ScottPlot.WinForms.FormsPlot();
            txtX = new System.Windows.Forms.TextBox();
            lblx = new System.Windows.Forms.Label();
            btnResult = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCuadratica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLineal).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblA.Location = new System.Drawing.Point(24, 80);
            lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new System.Drawing.Size(63, 16);
            lblA.TabIndex = 0;
            lblA.Text = "Campo A";
            lblA.Click += label1_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblB.Location = new System.Drawing.Point(24, 149);
            lblB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblB.Name = "lblB";
            lblB.Size = new System.Drawing.Size(63, 16);
            lblB.TabIndex = 1;
            lblB.Text = "Campo B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Enabled = false;
            lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblC.Location = new System.Drawing.Point(24, 216);
            lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblC.Name = "lblC";
            lblC.Size = new System.Drawing.Size(63, 16);
            lblC.TabIndex = 2;
            lblC.Text = "Campo C";
            lblC.Visible = false;
            // 
            // txtCampoA
            // 
            txtCampoA.Location = new System.Drawing.Point(28, 98);
            txtCampoA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCampoA.Name = "txtCampoA";
            txtCampoA.Size = new System.Drawing.Size(68, 23);
            txtCampoA.TabIndex = 3;
            txtCampoA.Text = "0";
            // 
            // txtCampoB
            // 
            txtCampoB.Location = new System.Drawing.Point(28, 167);
            txtCampoB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCampoB.Name = "txtCampoB";
            txtCampoB.Size = new System.Drawing.Size(68, 23);
            txtCampoB.TabIndex = 4;
            txtCampoB.Text = "0";
            // 
            // txtCampoC
            // 
            txtCampoC.Enabled = false;
            txtCampoC.Location = new System.Drawing.Point(28, 234);
            txtCampoC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCampoC.Name = "txtCampoC";
            txtCampoC.Size = new System.Drawing.Size(68, 23);
            txtCampoC.TabIndex = 5;
            txtCampoC.Text = "0";
            txtCampoC.Visible = false;
            // 
            // lblx1
            // 
            lblx1.AutoSize = true;
            lblx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblx1.Location = new System.Drawing.Point(24, 372);
            lblx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblx1.Name = "lblx1";
            lblx1.Size = new System.Drawing.Size(20, 16);
            lblx1.TabIndex = 6;
            lblx1.Text = "x1";
            lblx1.Visible = false;
            // 
            // lblx2
            // 
            lblx2.AutoSize = true;
            lblx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblx2.Location = new System.Drawing.Point(24, 434);
            lblx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblx2.Name = "lblx2";
            lblx2.Size = new System.Drawing.Size(20, 16);
            lblx2.TabIndex = 7;
            lblx2.Text = "x2";
            lblx2.Visible = false;
            lblx2.Click += label5_Click;
            // 
            // txtX1
            // 
            txtX1.Enabled = false;
            txtX1.Location = new System.Drawing.Point(28, 390);
            txtX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtX1.Name = "txtX1";
            txtX1.Size = new System.Drawing.Size(68, 23);
            txtX1.TabIndex = 8;
            txtX1.Visible = false;
            // 
            // txtX2
            // 
            txtX2.Enabled = false;
            txtX2.Location = new System.Drawing.Point(28, 452);
            txtX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtX2.Name = "txtX2";
            txtX2.Size = new System.Drawing.Size(68, 23);
            txtX2.TabIndex = 9;
            txtX2.Visible = false;
            // 
            // chkGrado2
            // 
            chkGrado2.AutoSize = true;
            chkGrado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkGrado2.Location = new System.Drawing.Point(28, 40);
            chkGrado2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkGrado2.Name = "chkGrado2";
            chkGrado2.Size = new System.Drawing.Size(90, 20);
            chkGrado2.TabIndex = 10;
            chkGrado2.Text = "2do Grade";
            chkGrado2.UseVisualStyleBackColor = true;
            chkGrado2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(pbCuadratica);
            panel1.Controls.Add(pbLineal);
            panel1.Controls.Add(fpGrafica);
            panel1.Controls.Add(txtX);
            panel1.Controls.Add(lblx);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(chkGrado2);
            panel1.Controls.Add(lblA);
            panel1.Controls.Add(txtX2);
            panel1.Controls.Add(lblB);
            panel1.Controls.Add(txtX1);
            panel1.Controls.Add(lblC);
            panel1.Controls.Add(lblx2);
            panel1.Controls.Add(txtCampoA);
            panel1.Controls.Add(lblx1);
            panel1.Controls.Add(txtCampoB);
            panel1.Controls.Add(txtCampoC);
            panel1.Location = new System.Drawing.Point(128, 12);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(993, 579);
            panel1.TabIndex = 11;
            // 
            // pbCuadratica
            // 
            pbCuadratica.BackgroundImage = (System.Drawing.Image)resources.GetObject("pbCuadratica.BackgroundImage");
            pbCuadratica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbCuadratica.Location = new System.Drawing.Point(458, 18);
            pbCuadratica.Name = "pbCuadratica";
            pbCuadratica.Size = new System.Drawing.Size(261, 61);
            pbCuadratica.TabIndex = 17;
            pbCuadratica.TabStop = false;
            pbCuadratica.Visible = false;
            // 
            // pbLineal
            // 
            pbLineal.BackgroundImage = (System.Drawing.Image)resources.GetObject("pbLineal.BackgroundImage");
            pbLineal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbLineal.Location = new System.Drawing.Point(434, -6);
            pbLineal.Name = "pbLineal";
            pbLineal.Size = new System.Drawing.Size(306, 118);
            pbLineal.TabIndex = 16;
            pbLineal.TabStop = false;
            pbLineal.Click += pbLineal_Click;
            // 
            // fpGrafica
            // 
            fpGrafica.DisplayScale = 1F;
            fpGrafica.Location = new System.Drawing.Point(255, 98);
            fpGrafica.Name = "fpGrafica";
            fpGrafica.Size = new System.Drawing.Size(647, 449);
            fpGrafica.TabIndex = 15;
            // 
            // txtX
            // 
            txtX.Enabled = false;
            txtX.Location = new System.Drawing.Point(28, 407);
            txtX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtX.Name = "txtX";
            txtX.Size = new System.Drawing.Size(68, 23);
            txtX.TabIndex = 14;
            // 
            // lblx
            // 
            lblx.AutoSize = true;
            lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblx.Location = new System.Drawing.Point(55, 385);
            lblx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblx.Name = "lblx";
            lblx.Size = new System.Drawing.Size(15, 16);
            lblx.TabIndex = 13;
            lblx.Text = "X";
            // 
            // btnResult
            // 
            btnResult.Location = new System.Drawing.Point(24, 275);
            btnResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnResult.Name = "btnResult";
            btnResult.Size = new System.Drawing.Size(82, 36);
            btnResult.TabIndex = 12;
            btnResult.Text = "Resultados";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(24, 335);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(93, 18);
            label6.TabIndex = 11;
            label6.Text = "Resultados";
            // 
            // frmEnunciado1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RosyBrown;
            ClientSize = new System.Drawing.Size(1233, 620);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmEnunciado1";
            Text = "frmEnunciado2";
            Load += frmEnunciado1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCuadratica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLineal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtCampoA;
        private System.Windows.Forms.TextBox txtCampoB;
        private System.Windows.Forms.TextBox txtCampoC;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.CheckBox chkGrado2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblx;
        private ScottPlot.WinForms.FormsPlot fpGrafica;
        private System.Windows.Forms.PictureBox pbCuadratica;
        private System.Windows.Forms.PictureBox pbLineal;
    }
}