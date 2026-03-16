using System.Reflection.Metadata;

namespace _1_2026_TAREA_II
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            lst_Numero.Items.Clear();

            if (!int.TryParse(txt_Numero.Text, out int Numero) || Numero < 1)
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 2; i <= Numero; i += 2)

            {
                lst_Numero.Items.Add(i.ToString());
            }


        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Ejercicio2 frmB = new Ejercicio2();
            frmB.ShowDialog();
            //frmB.Show();


        }
        private void submenuSegundo_Click(object sender, EventArgs e)
        {
            Ejercicio3 frm = new Ejercicio3();
            frm.ShowDialog();
        }

        private void submenuTercero_Click(object sender, EventArgs e)
        {
            Ejercicio4 frm = new Ejercicio4();
            frm.ShowDialog();
        }

        private void submenuCuarto_Click(object sender, EventArgs e)
        {
            Ejercicio5 frm = new Ejercicio5();
            frm.ShowDialog();
        }



        private void lst_Numero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void númerosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txt_Numero.Focus();

        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
                Close();
            


        }
        private void Ejercicio1_Load(object sender, EventArgs e)
        {

            lst_Numero.Items.Clear();
        }

        private void _btn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
