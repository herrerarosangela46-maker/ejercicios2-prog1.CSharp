using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2026_TAREA_II
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            lst_Tabla.Items.Clear();

            if (!int.TryParse(txt_Numero.Text, out int Numero))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const int Limite = 10;


            for (int i = 1; i <= Limite; i++)
            {
                int multiplicacion = Numero * i;
                lst_Tabla.Items.Add($"{Numero} x {i} = {multiplicacion}");
            }


        }

        private void pares_Click(object sender, EventArgs e)
        {
            Ejercicio1 frmB = new Ejercicio1();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            Ejercicio2 frmB = new Ejercicio2();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void Menu_Impares_Click(object sender, EventArgs e)
        {
            Ejercicio3 frmB = new Ejercicio3();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void Menu_factorial_Click(object sender, EventArgs e)
        {
            Ejercicio4 frmB = new Ejercicio4();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
