
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(436, 86);
            this.buttonArreglo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(124, 41);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "ORDEN";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(149, 265);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(263, 180);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.SelectedIndexChanged += new System.EventHandler(this.listBoxResultado_SelectedIndexChanged);
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(13, 86);
            this.buttonCargarArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(107, 41);
            this.buttonCargarArchivo.TabIndex = 2;
            this.buttonCargarArchivo.Text = "CARGAR";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(149, 13);
            this.textBoxResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(263, 213);
            this.textBoxResultado.TabIndex = 3;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(16, 338);
            this.buttonNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(119, 39);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "NAMES";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(586, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 212);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "ORDEN SECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(586, 263);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(276, 180);
            this.listBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 478);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "PROM A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 478);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "PROM B";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 468);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 43);
            this.button4.TabIndex = 10;
            this.button4.Text = "PROM C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(714, 468);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 43);
            this.button5.TabIndex = 11;
            this.button5.Text = "PROM D";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 665);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

