namespace Parcial_2
{
    partial class frmEnunciado2
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlSell_Rest = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cbMed1 = new System.Windows.Forms.ComboBox();
            btnAceptar1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtCantidad1 = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            btnDefault = new System.Windows.Forms.Button();
            btnAdd_img = new System.Windows.Forms.Button();
            cbOpcion1 = new System.Windows.Forms.ComboBox();
            dgvInventario = new System.Windows.Forms.DataGridView();
            pnlAdd_Mod = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            btnAceptar2 = new System.Windows.Forms.Button();
            txtCantidad2 = new System.Windows.Forms.TextBox();
            cbMed2 = new System.Windows.Forms.ComboBox();
            cbOpcion2 = new System.Windows.Forms.ComboBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            pnlSell_Rest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            pnlAdd_Mod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSell_Rest
            // 
            pnlSell_Rest.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlSell_Rest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnlSell_Rest.Controls.Add(pictureBox1);
            pnlSell_Rest.Controls.Add(cbMed1);
            pnlSell_Rest.Controls.Add(btnAceptar1);
            pnlSell_Rest.Controls.Add(label3);
            pnlSell_Rest.Controls.Add(label2);
            pnlSell_Rest.Controls.Add(label1);
            pnlSell_Rest.Controls.Add(txtCantidad1);
            pnlSell_Rest.Controls.Add(txtPrecio);
            pnlSell_Rest.Controls.Add(txtNombre);
            pnlSell_Rest.Controls.Add(btnDefault);
            pnlSell_Rest.Controls.Add(btnAdd_img);
            pnlSell_Rest.Controls.Add(cbOpcion1);
            pnlSell_Rest.Location = new System.Drawing.Point(3, 3);
            pnlSell_Rest.Name = "pnlSell_Rest";
            pnlSell_Rest.Size = new System.Drawing.Size(449, 205);
            pnlSell_Rest.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(11, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 110);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // cbMed1
            // 
            cbMed1.FormattingEnabled = true;
            cbMed1.Location = new System.Drawing.Point(158, 9);
            cbMed1.Name = "cbMed1";
            cbMed1.Size = new System.Drawing.Size(134, 23);
            cbMed1.TabIndex = 13;
            cbMed1.Text = "medicamento";
            // 
            // btnAceptar1
            // 
            btnAceptar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAceptar1.Location = new System.Drawing.Point(177, 169);
            btnAceptar1.Name = "btnAceptar1";
            btnAceptar1.Size = new System.Drawing.Size(66, 30);
            btnAceptar1.TabIndex = 10;
            btnAceptar1.Text = "Aceptar";
            btnAceptar1.UseVisualStyleBackColor = true;
            btnAceptar1.Click += btnAceptar1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(312, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 21);
            label3.TabIndex = 9;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(312, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 21);
            label2.TabIndex = 8;
            label2.Text = "Precio";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(312, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 21);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // txtCantidad1
            // 
            txtCantidad1.Location = new System.Drawing.Point(312, 169);
            txtCantidad1.Name = "txtCantidad1";
            txtCantidad1.Size = new System.Drawing.Size(134, 23);
            txtCantidad1.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(312, 106);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(134, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(312, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(134, 23);
            txtNombre.TabIndex = 4;
            // 
            // btnDefault
            // 
            btnDefault.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnDefault.Location = new System.Drawing.Point(88, 169);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new System.Drawing.Size(66, 30);
            btnDefault.TabIndex = 3;
            btnDefault.Text = "Quitar";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // btnAdd_img
            // 
            btnAdd_img.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAdd_img.Location = new System.Drawing.Point(7, 169);
            btnAdd_img.Name = "btnAdd_img";
            btnAdd_img.Size = new System.Drawing.Size(75, 30);
            btnAdd_img.TabIndex = 2;
            btnAdd_img.Text = "Agregar";
            btnAdd_img.UseVisualStyleBackColor = true;
            btnAdd_img.Click += btnAdd_img_Click;
            // 
            // cbOpcion1
            // 
            cbOpcion1.FormattingEnabled = true;
            cbOpcion1.Location = new System.Drawing.Point(7, 9);
            cbOpcion1.Name = "cbOpcion1";
            cbOpcion1.Size = new System.Drawing.Size(134, 23);
            cbOpcion1.TabIndex = 0;
            cbOpcion1.Text = "--Funcion--";
            cbOpcion1.SelectedIndexChanged += cbOpcion1_SelectedIndexChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            dgvInventario.BackgroundColor = System.Drawing.SystemColors.Window;
            dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new System.Drawing.Point(587, 124);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new System.Drawing.Size(534, 431);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // pnlAdd_Mod
            // 
            pnlAdd_Mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlAdd_Mod.BackColor = System.Drawing.Color.NavajoWhite;
            pnlAdd_Mod.Controls.Add(pictureBox2);
            pnlAdd_Mod.Controls.Add(label4);
            pnlAdd_Mod.Controls.Add(btnAceptar2);
            pnlAdd_Mod.Controls.Add(txtCantidad2);
            pnlAdd_Mod.Controls.Add(cbMed2);
            pnlAdd_Mod.Controls.Add(cbOpcion2);
            pnlAdd_Mod.Location = new System.Drawing.Point(3, 214);
            pnlAdd_Mod.Name = "pnlAdd_Mod";
            pnlAdd_Mod.Size = new System.Drawing.Size(449, 205);
            pnlAdd_Mod.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(11, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(128, 110);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(369, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 21);
            label4.TabIndex = 11;
            label4.Text = "Cantidad";
            // 
            // btnAceptar2
            // 
            btnAceptar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAceptar2.Location = new System.Drawing.Point(369, 147);
            btnAceptar2.Name = "btnAceptar2";
            btnAceptar2.Size = new System.Drawing.Size(77, 30);
            btnAceptar2.TabIndex = 11;
            btnAceptar2.Text = "Aceptar";
            btnAceptar2.UseVisualStyleBackColor = true;
            btnAceptar2.Click += btnAceptar2_Click;
            // 
            // txtCantidad2
            // 
            txtCantidad2.Location = new System.Drawing.Point(369, 102);
            txtCantidad2.Name = "txtCantidad2";
            txtCantidad2.Size = new System.Drawing.Size(77, 23);
            txtCantidad2.TabIndex = 11;
            // 
            // cbMed2
            // 
            cbMed2.FormattingEnabled = true;
            cbMed2.Location = new System.Drawing.Point(312, 12);
            cbMed2.Name = "cbMed2";
            cbMed2.Size = new System.Drawing.Size(134, 23);
            cbMed2.TabIndex = 11;
            cbMed2.Text = "Medicamento";
            // 
            // cbOpcion2
            // 
            cbOpcion2.FormattingEnabled = true;
            cbOpcion2.Location = new System.Drawing.Point(7, 12);
            cbOpcion2.Name = "cbOpcion2";
            cbOpcion2.Size = new System.Drawing.Size(134, 23);
            cbOpcion2.TabIndex = 1;
            cbOpcion2.Text = "--funcion--";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanel1.Controls.Add(pnlSell_Rest);
            flowLayoutPanel1.Controls.Add(pnlAdd_Mod);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(110, 121);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(460, 431);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(dgvInventario);
            panel1.Location = new System.Drawing.Point(13, 7);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1180, 644);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(454, 37);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(260, 39);
            label5.TabIndex = 6;
            label5.Text = "Farmacia Pelos\r\n";
            label5.Click += label5_Click_1;
            // 
            // frmEnunciado2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1219, 663);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1235, 702);
            Name = "frmEnunciado2";
            Text = "frmEnunciado1";
            Load += frmEnunciado2_Load;
            pnlSell_Rest.ResumeLayout(false);
            pnlSell_Rest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            pnlAdd_Mod.ResumeLayout(false);
            pnlAdd_Mod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlSell_Rest;
        private System.Windows.Forms.Panel pnlAdd_Mod;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnAdd_img;
        private System.Windows.Forms.ComboBox cbOpcion1;
        private System.Windows.Forms.ComboBox cbOpcion2;
        private System.Windows.Forms.Button btnAceptar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar2;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.ComboBox cbMed2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMed1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}