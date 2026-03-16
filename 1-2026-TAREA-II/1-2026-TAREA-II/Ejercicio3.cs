using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1_2026_TAREA_II
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            lst_Impares.Items.Clear();

            lbl_Resultado.Text = string.Empty;

            if (!int.TryParse(txt_Valor.Text, out int Valor) || Valor < 1)

            {
                MessageBox.Show("Ingrese un número entero mayor o igual a 1.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int contador = 0;


            for (int i = 1; i <= Valor; i += 2)


            {
                lst_Impares.Items.Add(i.ToString());
                contador++;
            }

            lbl_Resultado.Text = $"La cantidad de impares es: {contador}";
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void menu_Pares_Click(object sender, EventArgs e)
        {
            Ejercicio1 frmB = new Ejercicio1();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void menu_suma_Click(object sender, EventArgs e)
        {
            Ejercicio2 frmB = new Ejercicio2();
            frmB.ShowDialog();
            //frmB.Show();
        }

        private void factorial_Click(object sender, EventArgs e)
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
