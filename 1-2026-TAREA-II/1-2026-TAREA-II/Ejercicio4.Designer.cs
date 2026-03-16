namespace _1_2026_TAREA_II
{
    partial class Ejercicio4
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
            txt_Valor = new TextBox();
            btn_Resultado = new Button();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            verMásToolStripMenuItem = new ToolStripMenuItem();
            númerosParesToolStripMenuItem = new ToolStripMenuItem();
            númerosImparesToolStripMenuItem = new ToolStripMenuItem();
            sumaDeNúmerosToolStripMenuItem = new ToolStripMenuItem();
            tablaDeMultiplicarToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            list_Factorial = new ListBox();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(170, 66);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 0;
            label1.Text = "Número factorial";
            // 
            // txt_Valor
            // 
            txt_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_Valor.Location = new Point(313, 147);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(152, 29);
            txt_Valor.TabIndex = 1;
            // 
            // btn_Resultado
            // 
            btn_Resultado.BackColor = SystemColors.ActiveCaption;
            btn_Resultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Resultado.Location = new Point(237, 411);
            btn_Resultado.Name = "btn_Resultado";
            btn_Resultado.Size = new Size(117, 38);
            btn_Resultado.TabIndex = 2;
            btn_Resultado.Text = "Mostrar";
            btn_Resultado.UseVisualStyleBackColor = false;
            btn_Resultado.Click += btn_Resultado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(141, 150);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 3;
            label2.Text = "Digite un número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(141, 213);
            label3.Name = "label3";
            label3.Size = new Size(168, 21);
            label3.TabIndex = 4;
            label3.Text = "Factorial del número";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verMásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 27);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(67, 23);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salir_Click;
            // 
            // verMásToolStripMenuItem
            // 
            verMásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { númerosParesToolStripMenuItem, númerosImparesToolStripMenuItem, sumaDeNúmerosToolStripMenuItem, tablaDeMultiplicarToolStripMenuItem });
            verMásToolStripMenuItem.Name = "verMásToolStripMenuItem";
            verMásToolStripMenuItem.Size = new Size(93, 23);
            verMásToolStripMenuItem.Text = "Formularios";
            // 
            // númerosParesToolStripMenuItem
            // 
            númerosParesToolStripMenuItem.Name = "númerosParesToolStripMenuItem";
            númerosParesToolStripMenuItem.Size = new Size(194, 24);
            númerosParesToolStripMenuItem.Text = "Números pares";
            númerosParesToolStripMenuItem.Click += menu_Pares_Click;
            // 
            // númerosImparesToolStripMenuItem
            // 
            númerosImparesToolStripMenuItem.Name = "númerosImparesToolStripMenuItem";
            númerosImparesToolStripMenuItem.Size = new Size(194, 24);
            númerosImparesToolStripMenuItem.Text = "Suma de números";
            númerosImparesToolStripMenuItem.Click += menu_impares_click;
            // 
            // sumaDeNúmerosToolStripMenuItem
            // 
            sumaDeNúmerosToolStripMenuItem.Name = "sumaDeNúmerosToolStripMenuItem";
            sumaDeNúmerosToolStripMenuItem.Size = new Size(194, 24);
            sumaDeNúmerosToolStripMenuItem.Text = "Números impares";
            sumaDeNúmerosToolStripMenuItem.Click += suma_Click;
            // 
            // tablaDeMultiplicarToolStripMenuItem
            // 
            tablaDeMultiplicarToolStripMenuItem.Name = "tablaDeMultiplicarToolStripMenuItem";
            tablaDeMultiplicarToolStripMenuItem.Size = new Size(194, 24);
            tablaDeMultiplicarToolStripMenuItem.Text = "Tabla de multiplicar";
            tablaDeMultiplicarToolStripMenuItem.Click += menu_Tabla_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(634, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "Número factorial";
            toolStrip1.Click += btn_Resultado_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(129, 22);
            toolStripLabel1.Text = "Número factorial";
            // 
            // list_Factorial
            // 
            list_Factorial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            list_Factorial.FormattingEnabled = true;
            list_Factorial.ItemHeight = 21;
            list_Factorial.Location = new Point(313, 213);
            list_Factorial.Name = "list_Factorial";
            list_Factorial.Size = new Size(152, 172);
            list_Factorial.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 485);
            label4.Name = "label4";
            label4.Size = new Size(281, 17);
            label4.TabIndex = 9;
            label4.Text = "Ingrese un número para obtener su factorial";
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(634, 525);
            Controls.Add(label4);
            Controls.Add(list_Factorial);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Resultado);
            Controls.Add(txt_Valor);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Ejercicio4";
            Text = "Programa 4-Número factorial";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Valor;
        private Button btn_Resultado;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem verMásToolStripMenuItem;
        private ToolStripMenuItem númerosParesToolStripMenuItem;
        private ToolStripMenuItem númerosImparesToolStripMenuItem;
        private ToolStripMenuItem sumaDeNúmerosToolStripMenuItem;
        private ToolStripMenuItem tablaDeMultiplicarToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ListBox list_Factorial;
        private Label label4;
    }
}