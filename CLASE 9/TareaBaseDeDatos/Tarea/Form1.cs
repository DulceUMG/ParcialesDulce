using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea.Clases;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsConexion Datos = new ClsConexion();
        private void Form1_Load(object sender, EventArgs e)
        {
            Prueba1.DataSource = Datos.MostrarDatos();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
