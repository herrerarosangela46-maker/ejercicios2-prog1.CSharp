using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2026_TAREA_II
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {

        list_Factorial.Items.Clear();


            if (!int.TryParse(txt_Valor.Text, out int n) || n < 0)

            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BigInteger Factorial = BigInteger.One;
            for (int i = 2; i <= n; i++)
            {
                Factorial *= i;
            }
            
            list_Factorial.Items.Add(Factorial.ToString());
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Pares_Click(object sender, EventArgs e)
        {
            Ejercicio1 frmB = new Ejercicio1();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void menu_impares_click(object sender, EventArgs e)
        {
            Ejercicio2 frmB = new Ejercicio2();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            Ejercicio3 frmB = new Ejercicio3();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void menu_Tabla_Click(object sender, EventArgs e)
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
