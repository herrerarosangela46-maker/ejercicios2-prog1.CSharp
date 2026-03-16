namespace _1_2026_TAREA_II
{
    partial class Ejercicio5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lst_Tabla = new ListBox();
            btn_Ver = new Button();
            txt_Numero = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            formulariosToolStripMenuItem = new ToolStripMenuItem();
            númerosParesToolStripMenuItem = new ToolStripMenuItem();
            sumaDeNúmerosToolStripMenuItem = new ToolStripMenuItem();
            númerosImpaToolStripMenuItem = new ToolStripMenuItem();
            númeroFactorialToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 94);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "Tabla de multiplicar";
            // 
            // lst_Tabla
            // 
            lst_Tabla.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lst_Tabla.FormattingEnabled = true;
            lst_Tabla.ItemHeight = 21;
            lst_Tabla.Location = new Point(308, 217);
            lst_Tabla.Name = "lst_Tabla";
            lst_Tabla.Size = new Size(173, 235);
            lst_Tabla.TabIndex = 1;
            // 
            // btn_Ver
            // 
            btn_Ver.BackColor = Color.PaleTurquoise;
            btn_Ver.Cursor = Cursors.Hand;
            btn_Ver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Ver.Location = new Point(164, 242);
            btn_Ver.Name = "btn_Ver";
            btn_Ver.Size = new Size(98, 42);
            btn_Ver.TabIndex = 2;
            btn_Ver.Text = "Mostrar";
            btn_Ver.UseVisualStyleBackColor = false;
            btn_Ver.Click += btn_Ver_Click;
            // 
            // txt_Numero
            // 
            txt_Numero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_Numero.Location = new Point(308, 162);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(173, 29);
            txt_Numero.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(147, 165);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 4;
            label2.Text = "Digite un número";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, formulariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(670, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += Salir_Click;
            // 
            // formulariosToolStripMenuItem
            // 
            formulariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { númerosParesToolStripMenuItem, sumaDeNúmerosToolStripMenuItem, númerosImpaToolStripMenuItem, númeroFactorialToolStripMenuItem });
            formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            formulariosToolStripMenuItem.Size = new Size(82, 20);
            formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // númerosParesToolStripMenuItem
            // 
            númerosParesToolStripMenuItem.Name = "númerosParesToolStripMenuItem";
            númerosParesToolStripMenuItem.Size = new Size(180, 22);
            númerosParesToolStripMenuItem.Text = "Números pares";
            númerosParesToolStripMenuItem.Click += pares_Click;
            // 
            // sumaDeNúmerosToolStripMenuItem
            // 
            sumaDeNúmerosToolStripMenuItem.Name = "sumaDeNúmerosToolStripMenuItem";
            sumaDeNúmerosToolStripMenuItem.Size = new Size(180, 22);
            sumaDeNúmerosToolStripMenuItem.Text = "Suma de números";
            sumaDeNúmerosToolStripMenuItem.Click += suma_Click;
            // 
            // númerosImpaToolStripMenuItem
            // 
            númerosImpaToolStripMenuItem.Name = "númerosImpaToolStripMenuItem";
            númerosImpaToolStripMenuItem.Size = new Size(180, 22);
            númerosImpaToolStripMenuItem.Text = "Números impares";
            númerosImpaToolStripMenuItem.Click += Menu_Impares_Click;
            // 
            // númeroFactorialToolStripMenuItem
            // 
            númeroFactorialToolStripMenuItem.Name = "númeroFactorialToolStripMenuItem";
            númeroFactorialToolStripMenuItem.Size = new Size(180, 22);
            númeroFactorialToolStripMenuItem.Text = "Número factorial";
            númeroFactorialToolStripMenuItem.Click += Menu_factorial_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 476);
            label3.Name = "label3";
            label3.Size = new Size(418, 17);
            label3.TabIndex = 6;
            label3.Text = "A partir del número ingresado obtenga la tabla de éste hasta el 10";
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(670, 512);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Numero);
            Controls.Add(btn_Ver);
            Controls.Add(lst_Tabla);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Ejercicio5";
            Text = "Programa 5-Tabla de multiplicar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lst_Tabla;
        private Button btn_Ver;
        private TextBox txt_Numero;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem formulariosToolStripMenuItem;
        private ToolStripMenuItem númerosParesToolStripMenuItem;
        private ToolStripMenuItem sumaDeNúmerosToolStripMenuItem;
        private ToolStripMenuItem númerosImpaToolStripMenuItem;
        private ToolStripMenuItem númeroFactorialToolStripMenuItem;
        private Label label3;
    }
}