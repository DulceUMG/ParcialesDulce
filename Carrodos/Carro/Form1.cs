using Carro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class Form1 : Form
    {
        private string ruta = "";

        ClsAutomotor carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void botonuno_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("Meches", 130); 
            carrito.color = "Negro";



            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
           
                
                Estado.Text = $" el carro {carrito.marca} :{carrito.encender()}";
            
             
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");

            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }
            
           
        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("BMW", 200, "NEGRO");

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void bouttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha(); 
        }

        private void labelEstadoVelocidad_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha(); 
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lablRuta.Text = ruta;             
            }
        }

        private void btnreproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); 
        }

        private void buttonFrenarDespacio_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.Frenarmaslento(); 
        }
    }
}
