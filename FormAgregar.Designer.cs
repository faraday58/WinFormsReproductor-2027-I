namespace WinFormsReproductor_2027_I
{
    partial class FormAgregar
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 94);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 157);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 0;
            label2.Text = "Artista";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 31);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 223);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 0;
            label3.Text = "Álbum";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(425, 31);
            textBox3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(456, 308);
            button1.Name = "button1";
            button1.Size = new Size(171, 46);
            button1.TabIndex = 2;
            button1.Text = "Agregar Canción";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 408);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
    }
}