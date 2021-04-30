
namespace Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonuno = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.bouttonAltoTotal = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            this.lablRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonFrenarDespacio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonuno
            // 
            this.botonuno.Location = new System.Drawing.Point(72, 89);
            this.botonuno.Name = "botonuno";
            this.botonuno.Size = new System.Drawing.Size(100, 37);
            this.botonuno.TabIndex = 0;
            this.botonuno.Text = "Crear carro ";
            this.botonuno.UseVisualStyleBackColor = true;
            this.botonuno.Click += new System.EventHandler(this.botonuno_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(215, 113);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(35, 13);
            this.Estado.TabIndex = 1;
            this.Estado.Text = "label1";
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(72, 132);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(100, 43);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender el carro";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(72, 217);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(100, 37);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(215, 156);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(35, 13);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "label1";
            this.labelEstadoVelocidad.Click += new System.EventHandler(this.labelEstadoVelocidad_Click);
            // 
            // buttonBMW
            // 
            this.buttonBMW.Location = new System.Drawing.Point(72, 48);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(100, 35);
            this.buttonBMW.TabIndex = 5;
            this.buttonBMW.Text = "BMW";
            this.buttonBMW.UseVisualStyleBackColor = true;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // bouttonAltoTotal
            // 
            this.bouttonAltoTotal.Location = new System.Drawing.Point(72, 260);
            this.bouttonAltoTotal.Name = "bouttonAltoTotal";
            this.bouttonAltoTotal.Size = new System.Drawing.Size(100, 39);
            this.bouttonAltoTotal.TabIndex = 6;
            this.bouttonAltoTotal.Text = "AltoTotal";
            this.bouttonAltoTotal.UseVisualStyleBackColor = true;
            this.bouttonAltoTotal.Click += new System.EventHandler(this.bouttonAltoTotal_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(517, 53);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(287, 210);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(503, 276);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 8;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.Location = new System.Drawing.Point(584, 276);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(75, 23);
            this.btnreproducir.TabIndex = 9;
            this.btnreproducir.Text = "Reproducir";
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(665, 276);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(75, 23);
            this.btnparar.TabIndex = 10;
            this.btnparar.Text = "Parar";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.Location = new System.Drawing.Point(746, 276);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(75, 23);
            this.btnpausa.TabIndex = 11;
            this.btnpausa.Text = "Pausa";
            this.btnpausa.UseVisualStyleBackColor = true;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // lablRuta
            // 
            this.lablRuta.AutoSize = true;
            this.lablRuta.Location = new System.Drawing.Point(456, 310);
            this.lablRuta.Name = "lablRuta";
            this.lablRuta.Size = new System.Drawing.Size(35, 13);
            this.lablRuta.TabIndex = 12;
            this.lablRuta.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // buttonFrenarDespacio
            // 
            this.buttonFrenarDespacio.Location = new System.Drawing.Point(72, 181);
            this.buttonFrenarDespacio.Name = "buttonFrenarDespacio";
            this.buttonFrenarDespacio.Size = new System.Drawing.Size(100, 30);
            this.buttonFrenarDespacio.TabIndex = 13;
            this.buttonFrenarDespacio.Text = "Frenar Despacio ";
            this.buttonFrenarDespacio.UseVisualStyleBackColor = true;
            this.buttonFrenarDespacio.Click += new System.EventHandler(this.buttonFrenarDespacio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.buttonFrenarDespacio);
            this.Controls.Add(this.lablRuta);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnreproducir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.bouttonAltoTotal);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.botonuno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonuno;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button bouttonAltoTotal;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnpausa;
        private System.Windows.Forms.Label lablRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonFrenarDespacio;
    }
}

