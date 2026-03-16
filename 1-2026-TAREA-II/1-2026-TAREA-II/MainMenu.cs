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
    public partial class MainMenu : Form
    {
        private bool arrastrando = false;
        private Point inicio = Point.Empty;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pares_btn(object sender, EventArgs e)
        {
            Ejercicio1 frmB = new Ejercicio1();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void suma_btn(object sender, EventArgs e)
        {
            Ejercicio2 frmB = new Ejercicio2();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void impare_btn(object sender, EventArgs e)
        {
            Ejercicio3 frmB = new Ejercicio3();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void Factorial_btn(object sender, EventArgs e)
        {
            Ejercicio4 frmB = new Ejercicio4();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void tabla_btn(object sender, EventArgs e)
        {
            Ejercicio5 frmB = new Ejercicio5();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void program1_btn(object sender, EventArgs e)
        {
            Ejercicio1 frmB = new Ejercicio1();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void program2_btn(object sender, EventArgs e)
        {
            Ejercicio2 frmB = new Ejercicio2();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void program3_btn(object sender, EventArgs e)
        {
            Ejercicio3 frmB = new Ejercicio3();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void program4_btn(object sender, EventArgs e)
        {
            Ejercicio4 frmB = new Ejercicio4();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void program5_btn(object sender, EventArgs e)
        {
            Ejercicio5 frmB = new Ejercicio5();
            frmB.ShowDialog();
            //frmB.Show();

        }

        private void hover1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void hover2(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void hover3(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void hover4(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void hover5(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btn_Salir(object sender, EventArgs e)
        {
            Close();
        }
    }
}
