using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        private string[] datosUnitarios; // Lo vamos a utilizar para Representar los datos de nombres y sus respectivas notas
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int ArreglarNombres = 0; // Variable declarada con valor de 0 
            string[] nombres = new string[ArregloNotas.Length - 1]; // Creara un String nuevo donde leera los datos 

            foreach (string linea in ArregloNotas) // Lo leera en Arreglo notas 
            {
                if (ArreglarNombres != 0) // Si ArregloNombres sigue siendo diferente a 0 entonces seguira ordenandolos 
                {
                    string[] datos = linea.Split(';');
                    nombres[ArreglarNombres - 1] = datos[1]; // Si sigue siendo menor a la primera variable, Seguira ordenando para pasar al siguiente dato

                }

                ArreglarNombres++;
            }

            ClsArreglos arrreglo = new ClsArreglos(nombres); // Nuevo metodo para ordenar nombres 
            string[] resultado = arrreglo.Burbujita();

            for (int indice = 0; indice < resultado.Length; indice++) // Verifica todas las lineas para ordenar 
            {
                listBox1.Items.Add($"{resultado[indice]}"); // Devuelve El valor Arreglado 
            }

        }



        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog(); // Abre el archivo Plano 

            ofd.Title = "Selecciona el archivo plano";
            ofd.InitialDirectory = @"C:\Users\Dulce Mazariegos\Desktop\UMG\Programacion 1\Clase 7"; // Direccion del archivo 
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;

            }


        }

        public int promedio2D(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio2D = 0;
            int totalfilas = matriz.GetLength(0);
            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);

            }

            promedio2D = (acumulador / (matriz.GetLength(0) - 1)) - 1;
            return promedio2D;
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {

            int contador = 0;
            int promedio, promedio1, promedio2;
            int acumulador, acumulador1, acumulador2;


            acumulador = 0;
            acumulador1 = 0;
            acumulador2 = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];

            int[] ordenParcialNota3 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota2 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota1 = new int[ArregloNotas.Length - 1];


            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datosUnitarios = Linea.Split(';');
                    listBoxResultado.Items.Add($"{datosUnitarios[1]}");
                    acumulador = acumulador + Convert.ToInt32(datosUnitarios[2]);
                    acumulador1 = acumulador1 + Convert.ToInt32(datosUnitarios[3]);
                    acumulador2 = acumulador2 + Convert.ToInt32(datosUnitarios[4]);

                    ordenParcialNota1[contador - 1] = Convert.ToInt32(datosUnitarios[2]);

                    ordenParcialNota2[contador - 1] = Convert.ToInt32(datosUnitarios[3]);

                    ordenParcialNota3[contador - 1] = Convert.ToInt32(datosUnitarios[4]);

                    ArregloDosDimensiones[contador, 0] = datosUnitarios[0];
                    ArregloDosDimensiones[contador, 1] = datosUnitarios[1];
                    ArregloDosDimensiones[contador, 2] = datosUnitarios[2];
                    ArregloDosDimensiones[contador, 3] = datosUnitarios[3];
                    ArregloDosDimensiones[contador, 4] = datosUnitarios[4];
                    ArregloDosDimensiones[contador, 5] = datosUnitarios[5];

                }

                contador++;
            }


            //promedio archivo plano 
            ClsArreglos FncArreglosN1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = FncArreglosN1.MetodoBurbuja();
            int MinN1 = ordenParcialNota1[0];
            int MaxN1 = ordenParcialNota1[ordenParcialNota1.Length - 1];

            ClsArreglos FncArreglosN2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = FncArreglosN2.MetodoBurbuja();
            int MinN2 = ordenParcialNota2[0];
            int MaxN2 = ordenParcialNota2[ordenParcialNota2.Length - 1];

            ClsArreglos FncArreglosN3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = FncArreglosN3.MetodoBurbuja();
            int MinN3 = ordenParcialNota3[0];
            int MaxN3 = ordenParcialNota3[ordenParcialNota3.Length - 1];

            //Funcion, promedio archivo plano de las dos dimensiones 
            ClsArreglos fncN2D = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncN2D.MetodoBurbuja();
            promedio = acumulador / ArregloDosDimensiones.Length - 1;
            int promedioMatriz = promedio2D(ArregloDosDimensiones, 2);
            int MinN1ed = ordenParcialNota1[0];
            int MaxN12d = ordenParcialNota1[ordenParcialNota1.Length - 1];

            ClsArreglos fncN12D = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncN2D.MetodoBurbuja();
            promedio = acumulador / ArregloDosDimensiones.Length - 1;
            int promedioMatriz2 = promedio2D(ArregloDosDimensiones, 2);
            int MinN2ed = ordenParcialNota1[0];
            int MaxN22d = ordenParcialNota1[ordenParcialNota1.Length - 1];

            ClsArreglos fncN13D = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncN12D.MetodoBurbuja();
            promedio = acumulador / ArregloDosDimensiones.Length - 1;
            int promedioMatriz3 = promedio2D(ArregloDosDimensiones, 2);
            int MinN3ed = ordenParcialNota1[0];
            int MaxN32d = ordenParcialNota1[ordenParcialNota1.Length - 1];

            //mostrar promedio dos dimensiones 
            MessageBox.Show($"promedio de 2D P1: { promedioMatriz}.\nMaximaNota: {MaxN32d} {MinN1ed}.\npromedio de 2D P2: { promedioMatriz2}.\nMaximaNota:{ MaxN22d}.\nMinimaNota: {MinN2ed}.\npromedio de 2D P3: { promedioMatriz3}.\nMaximaNota: { MaxN32d}.\nMinimaNota: {MinN3ed}.");


        }
    }



        }
       
        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
