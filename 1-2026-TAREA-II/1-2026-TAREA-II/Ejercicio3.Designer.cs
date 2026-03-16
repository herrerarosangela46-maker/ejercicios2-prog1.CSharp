namespace _1_2026_TAREA_II
{
    partial class Ejercicio3
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
            label2 = new Label();
            txt_Valor = new TextBox();
            btn_Mostrar = new Button();
            lbl_Resultado = new Label();
            lst_Impares = new ListBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            verMásToolStripMenuItem = new ToolStripMenuItem();
            númerosParesToolStripMenuItem = new ToolStripMenuItem();
            sumaDeNúmerosToolStripMenuItem = new ToolStripMenuItem();
            númeroFactorialToolStripMenuItem = new ToolStripMenuItem();
            tablaDeMultiplicarToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 60);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Número impares";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(176, 127);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 1;
            label2.Text = "Digite un número";
            // 
            // txt_Valor
            // 
            txt_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_Valor.Location = new Point(336, 119);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(120, 29);
            txt_Valor.TabIndex = 2;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.MistyRose;
            btn_Mostrar.Cursor = Cursors.Hand;
            btn_Mostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Mostrar.Location = new Point(188, 187);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(100, 35);
            btn_Mostrar.TabIndex = 3;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_Resultado.Location = new Point(159, 419);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(244, 25);
            lbl_Resultado.TabIndex = 4;
            lbl_Resultado.Text = "La cantidad de impares es:";
            // 
            // lst_Impares
            // 
            lst_Impares.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lst_Impares.FormattingEnabled = true;
            lst_Impares.ItemHeight = 21;
            lst_Impares.Location = new Point(336, 168);
            lst_Impares.Name = "lst_Impares";
            lst_Impares.Size = new Size(120, 214);
            lst_Impares.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verMásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(658, 24);
            menuStrip1.TabIndex = 6;
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
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salir_Click;
            // 
            // verMásToolStripMenuItem
            // 
            verMásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { númerosParesToolStripMenuItem, sumaDeNúmerosToolStripMenuItem, númeroFactorialToolStripMenuItem, tablaDeMultiplicarToolStripMenuItem });
            verMásToolStripMenuItem.Name = "verMásToolStripMenuItem";
            verMásToolStripMenuItem.Size = new Size(82, 20);
            verMásToolStripMenuItem.Text = "Formularios";
            // 
            // númerosParesToolStripMenuItem
            // 
            númerosParesToolStripMenuItem.Name = "númerosParesToolStripMenuItem";
            númerosParesToolStripMenuItem.Size = new Size(177, 22);
            númerosParesToolStripMenuItem.Text = "Números pares";
            númerosParesToolStripMenuItem.Click += menu_Pares_Click;
            // 
            // sumaDeNúmerosToolStripMenuItem
            // 
            sumaDeNúmerosToolStripMenuItem.Name = "sumaDeNúmerosToolStripMenuItem";
            sumaDeNúmerosToolStripMenuItem.Size = new Size(177, 22);
            sumaDeNúmerosToolStripMenuItem.Text = "Suma de números";
            sumaDeNúmerosToolStripMenuItem.Click += menu_suma_Click;
            // 
            // númeroFactorialToolStripMenuItem
            // 
            númeroFactorialToolStripMenuItem.Name = "númeroFactorialToolStripMenuItem";
            númeroFactorialToolStripMenuItem.Size = new Size(177, 22);
            númeroFactorialToolStripMenuItem.Text = "Número factorial";
            númeroFactorialToolStripMenuItem.Click += factorial_Click;
            // 
            // tablaDeMultiplicarToolStripMenuItem
            // 
            tablaDeMultiplicarToolStripMenuItem.Name = "tablaDeMultiplicarToolStripMenuItem";
            tablaDeMultiplicarToolStripMenuItem.Size = new Size(177, 22);
            tablaDeMultiplicarToolStripMenuItem.Text = "Tabla de multiplicar";
            tablaDeMultiplicarToolStripMenuItem.Click += menu_tabla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 480);
            label3.Name = "label3";
            label3.Size = new Size(589, 17);
            label3.TabIndex = 7;
            label3.Text = "Ingrese un número  para obtener los números pares hasta ese número. Y cuántos impares hay";
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(658, 521);
            Controls.Add(label3);
            Controls.Add(lst_Impares);
            Controls.Add(lbl_Resultado);
            Controls.Add(btn_Mostrar);
            Controls.Add(txt_Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "Ejercicio3";
            Text = "Programa 3-Números impares";
            Load += Ejercicio3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Valor;
        private Button btn_Mostrar;
        private Label lbl_Resultado;
        private ListBox lst_Impares;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem verMásToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem númerosParesToolStripMenuItem;
        private ToolStripMenuItem sumaDeNúmerosToolStripMenuItem;
        private ToolStripMenuItem númeroFactorialToolStripMenuItem;
        private ToolStripMenuItem tablaDeMultiplicarToolStripMenuItem;
        private Label label3;
    }
}