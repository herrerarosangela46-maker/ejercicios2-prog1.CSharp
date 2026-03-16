using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2026_TAREA_II
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
    
     
                lst_Valor.Items.Clear(); 
            int Valor;
            if (!int.TryParse(txt_Valor.Text, out Valor) || Valor < 1) 
            { MessageBox.Show("Ingrese un número válido.", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
           
            int suma = 0;

            for (int i = 0; i <= Valor; i++)
            {
                suma += i;
            }

            {
                lst_Valor.Items.Add(suma.ToString());
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu_pares_Click(object sender, EventArgs e)
        {
            Ejercicio1 frmB = new Ejercicio1();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void menu_impares_Click(object sender, EventArgs e)
        {
            Ejercicio3 frmB = new Ejercicio3();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void menu_factorial_Click(object sender, EventArgs e)
        {
            Ejercicio4 frmB = new Ejercicio4();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void menu_tabla_Click(object sender, EventArgs e)
        {
            Ejercicio5 frmB = new Ejercicio5();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
