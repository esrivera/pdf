namespace WinAppParesCuerpo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picImagenPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitulo
            // 
            this.picTitulo.BackColor = System.Drawing.Color.Teal;
            this.picTitulo.BackgroundImage = global::WinAppParesCuerpo.Properties.Resources.TITULO;
            this.picTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTitulo.Location = new System.Drawing.Point(884, 14);
            this.picTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(799, 380);
            this.picTitulo.TabIndex = 0;
            this.picTitulo.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Teal;
            this.btnPlay.BackgroundImage = global::WinAppParesCuerpo.Properties.Resources.boton;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(1075, 549);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(419, 367);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseHover += new System.EventHandler(this.sonidoMouse);
            // 
            // picImagenPrincipal
            // 
            this.picImagenPrincipal.BackgroundImage = global::WinAppParesCuerpo.Properties.Resources.niños;
            this.picImagenPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImagenPrincipal.Location = new System.Drawing.Point(53, 220);
            this.picImagenPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImagenPrincipal.Name = "picImagenPrincipal";
            this.picImagenPrincipal.Size = new System.Drawing.Size(739, 620);
            this.picImagenPrincipal.TabIndex = 2;
            this.picImagenPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1339, 655);
            this.Controls.Add(this.picImagenPrincipal);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picTitulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "PARES DEL CUERPO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picImagenPrincipal;
    }
}

