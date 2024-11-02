namespace Parcial_2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            enunciado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            enunciado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { enunciado1ToolStripMenuItem, enunciado2ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1219, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // enunciado1ToolStripMenuItem
            // 
            enunciado1ToolStripMenuItem.Name = "enunciado1ToolStripMenuItem";
            enunciado1ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            enunciado1ToolStripMenuItem.Text = "Enunciado 1";
            enunciado1ToolStripMenuItem.Click += enunciado1ToolStripMenuItem_Click;
            // 
            // enunciado2ToolStripMenuItem
            // 
            enunciado2ToolStripMenuItem.Name = "enunciado2ToolStripMenuItem";
            enunciado2ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            enunciado2ToolStripMenuItem.Text = "Enunciado 2";
            enunciado2ToolStripMenuItem.Click += enunciado2ToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1219, 663);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1235, 702);
            Name = "frmPrincipal";
            Text = "Main";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enunciado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado2ToolStripMenuItem;
    }
}

