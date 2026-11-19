namespace WinFormsReproductor_2027_I
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstbReproduccion = new ListBox();
            label1 = new Label();
            lbArtista = new Label();
            label3 = new Label();
            lbNombre = new Label();
            label5 = new Label();
            lbAlbum = new Label();
            progbCancion = new ProgressBar();
            lbTiempoTrans = new Label();
            lbTiempoTotal = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            reToolStripMenuItem = new ToolStripMenuItem();
            reproducirToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            pausaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            siguienteToolStripMenuItem = new ToolStripMenuItem();
            atrásToolStripMenuItem = new ToolStripMenuItem();
            tOPToolStripMenuItem = new ToolStripMenuItem();
            másEscuchadasToolStripMenuItem = new ToolStripMenuItem();
            nacionalToolStripMenuItem = new ToolStripMenuItem();
            extranjerasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstbReproduccion
            // 
            lstbReproduccion.FormattingEnabled = true;
            lstbReproduccion.Location = new Point(49, 76);
            lstbReproduccion.Name = "lstbReproduccion";
            lstbReproduccion.Size = new Size(277, 454);
            lstbReproduccion.TabIndex = 0;
            lstbReproduccion.SelectedIndexChanged += lstbReproduccion_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 105);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Artista";
            // 
            // lbArtista
            // 
            lbArtista.AutoSize = true;
            lbArtista.Location = new Point(693, 105);
            lbArtista.Name = "lbArtista";
            lbArtista.Size = new Size(84, 25);
            lbArtista.TabIndex = 1;
            lbArtista.Text = "Jere Klein";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 180);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(693, 180);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(105, 25);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Todo Ke ver";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 254);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 1;
            label5.Text = "Álbum";
            // 
            // lbAlbum
            // 
            lbAlbum.AutoSize = true;
            lbAlbum.Location = new Point(693, 254);
            lbAlbum.Name = "lbAlbum";
            lbAlbum.Size = new Size(105, 25);
            lbAlbum.TabIndex = 1;
            lbAlbum.Text = "Todo Ke ver";
            // 
            // progbCancion
            // 
            progbCancion.Location = new Point(530, 401);
            progbCancion.Name = "progbCancion";
            progbCancion.Size = new Size(449, 12);
            progbCancion.TabIndex = 2;
            // 
            // lbTiempoTrans
            // 
            lbTiempoTrans.AutoSize = true;
            lbTiempoTrans.Location = new Point(502, 388);
            lbTiempoTrans.Name = "lbTiempoTrans";
            lbTiempoTrans.Size = new Size(22, 25);
            lbTiempoTrans.TabIndex = 3;
            lbTiempoTrans.Text = "0";
            // 
            // lbTiempoTotal
            // 
            lbTiempoTotal.AutoSize = true;
            lbTiempoTotal.Location = new Point(1008, 388);
            lbTiempoTotal.Name = "lbTiempoTotal";
            lbTiempoTotal.Size = new Size(46, 25);
            lbTiempoTotal.TabIndex = 3;
            lbTiempoTotal.Text = "2:30";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, reToolStripMenuItem, tOPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1249, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(177, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(177, 34);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // reToolStripMenuItem
            // 
            reToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reproducirToolStripMenuItem, stopToolStripMenuItem, pausaToolStripMenuItem, toolStripMenuItem1, siguienteToolStripMenuItem, atrásToolStripMenuItem });
            reToolStripMenuItem.Name = "reToolStripMenuItem";
            reToolStripMenuItem.Size = new Size(137, 29);
            reToolStripMenuItem.Text = "Reproducción";
            // 
            // reproducirToolStripMenuItem
            // 
            reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            reproducirToolStripMenuItem.Size = new Size(200, 34);
            reproducirToolStripMenuItem.Text = "Reproducir";
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(200, 34);
            stopToolStripMenuItem.Text = "Stop";
            // 
            // pausaToolStripMenuItem
            // 
            pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            pausaToolStripMenuItem.Size = new Size(200, 34);
            pausaToolStripMenuItem.Text = "Pausa";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(197, 6);
            // 
            // siguienteToolStripMenuItem
            // 
            siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            siguienteToolStripMenuItem.Size = new Size(200, 34);
            siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // atrásToolStripMenuItem
            // 
            atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            atrásToolStripMenuItem.Size = new Size(200, 34);
            atrásToolStripMenuItem.Text = "Atrás";
            // 
            // tOPToolStripMenuItem
            // 
            tOPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { másEscuchadasToolStripMenuItem, nacionalToolStripMenuItem, extranjerasToolStripMenuItem });
            tOPToolStripMenuItem.Name = "tOPToolStripMenuItem";
            tOPToolStripMenuItem.Size = new Size(65, 29);
            tOPToolStripMenuItem.Text = "TOP ";
            // 
            // másEscuchadasToolStripMenuItem
            // 
            másEscuchadasToolStripMenuItem.Name = "másEscuchadasToolStripMenuItem";
            másEscuchadasToolStripMenuItem.Size = new Size(256, 34);
            másEscuchadasToolStripMenuItem.Text = "Más reproducidas";
            // 
            // nacionalToolStripMenuItem
            // 
            nacionalToolStripMenuItem.Name = "nacionalToolStripMenuItem";
            nacionalToolStripMenuItem.Size = new Size(256, 34);
            nacionalToolStripMenuItem.Text = "Nacional";
            // 
            // extranjerasToolStripMenuItem
            // 
            extranjerasToolStripMenuItem.Name = "extranjerasToolStripMenuItem";
            extranjerasToolStripMenuItem.Size = new Size(256, 34);
            extranjerasToolStripMenuItem.Text = "Extranjeras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 585);
            Controls.Add(lbTiempoTotal);
            Controls.Add(lbTiempoTrans);
            Controls.Add(progbCancion);
            Controls.Add(lbAlbum);
            Controls.Add(lbNombre);
            Controls.Add(lbArtista);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstbReproduccion);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbReproduccion;
        private Label label1;
        private Label lbNombre;
        private Label label3;
        private Label lbArtista;
        private Label label5;
        private Label lbAlbum;
        private ProgressBar progbCancion;
        private Label lbTiempoTrans;
        private Label lbTiempoTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem reToolStripMenuItem;
        private ToolStripMenuItem reproducirToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem pausaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem siguienteToolStripMenuItem;
        private ToolStripMenuItem atrásToolStripMenuItem;
        private ToolStripMenuItem tOPToolStripMenuItem;
        private ToolStripMenuItem másEscuchadasToolStripMenuItem;
        private ToolStripMenuItem nacionalToolStripMenuItem;
        private ToolStripMenuItem extranjerasToolStripMenuItem;
    }
}
