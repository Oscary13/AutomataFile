using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class Form1 : Form
    {
        FileStream archivo;
        StreamReader leer;
        public Form1()
        {
            InitializeComponent();
            ShowDialog();
            DialogResult resultado;

            resultado = openfiledialogArchivoTxt.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                archivo = new FileStream(openfiledialogArchivoTxt.FileName, FileMode.Open, FileAccess.Read);
                leer = new StreamReader(archivo);
                String[] estados = leer.ReadLine().Split(',');
                String[] alfabeto = leer.ReadLine().Split(',');
                int estadoInicial = int.Parse(leer.ReadLine());
                String[] estadosFonales = leer.ReadLine().Split(',');

                int[,] tablaTranciciones = new int[estados.Length,alfabeto.Length];
                for (int i = 0; i < estados.Length; i++)
                {
                    String[] transiciones = leer.ReadLine().Split('\t');
                    for (int j = 0; j < alfabeto.Length; j++)
                    {
                        tablaTranciciones[i, j] = int.Parse(transiciones[j]);
                    }
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfiledialogArchivoTxt.Title = "Seleciona un automata";
            openfiledialogArchivoTxt.Filter = "Archivo txt|*.txt";


        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openfiledialogArchivoTxt.Title = "Seleciona un automata";
            openfiledialogArchivoTxt.Filter = "Archivo txt|*.txt";

        }
    }
}
