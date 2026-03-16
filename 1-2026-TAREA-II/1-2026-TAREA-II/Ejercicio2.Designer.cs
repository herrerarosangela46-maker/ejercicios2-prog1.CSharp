namespace _1_2026_TAREA_II
{
    partial class Ejercicio2
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
            lst_Valor = new ListBox();
            btn_Ver = new Button();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            verMásToolStripMenuItem = new ToolStripMenuItem();
            númerosParesToolStripMenuItem = new ToolStripMenuItem();
            númerosFactorialesToolStripMenuItem = new ToolStripMenuItem();
            númerosFactorialesToolStripMenuItem1 = new ToolStripMenuItem();
            tablaDeMultiplicarToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(196, 111);
            label1.Name = "label1";
            label1.Size = new Size(269, 41);
            label1.TabIndex = 0;
            label1.Text = "Suma de números";
            // 
            // txt_Valor
            // 
            txt_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_Valor.Location = new Point(334, 181);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(154, 29);
            txt_Valor.TabIndex = 1;
            // 
            // lst_Valor
            // 
            lst_Valor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lst_Valor.FormattingEnabled = true;
            lst_Valor.ItemHeight = 21;
            lst_Valor.Location = new Point(334, 297);
            lst_Valor.Name = "lst_Valor";
            lst_Valor.Size = new Size(154, 67);
            lst_Valor.TabIndex = 2;
            // 
            // btn_Ver
            // 
            btn_Ver.BackColor = Color.FromArgb(255, 128, 255);
            btn_Ver.Cursor = Cursors.Hand;
            btn_Ver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Ver.Location = new Point(196, 297);
            btn_Ver.Name = "btn_Ver";
            btn_Ver.Size = new Size(105, 48);
            btn_Ver.TabIndex = 3;
            btn_Ver.Text = "Mostrar";
            btn_Ver.UseVisualStyleBackColor = false;
            btn_Ver.Click += btn_Ver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(171, 184);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 4;
            label2.Text = "Digite un número";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(255, 192, 255);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(691, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(147, 22);
            toolStripLabel1.Text = "Suma de números";
            toolStripLabel1.Click += btn_Ver_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verMásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(691, 24);
            menuStrip1.TabIndex = 7;
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
            verMásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { númerosParesToolStripMenuItem, númerosFactorialesToolStripMenuItem, númerosFactorialesToolStripMenuItem1, tablaDeMultiplicarToolStripMenuItem });
            verMásToolStripMenuItem.Name = "verMásToolStripMenuItem";
            verMásToolStripMenuItem.Size = new Size(82, 20);
            verMásToolStripMenuItem.Text = "Formularios";
            // 
            // númerosParesToolStripMenuItem
            // 
            númerosParesToolStripMenuItem.Name = "númerosParesToolStripMenuItem";
            númerosParesToolStripMenuItem.Size = new Size(180, 22);
            númerosParesToolStripMenuItem.Text = "Números pares";
            númerosParesToolStripMenuItem.Click += menu_pares_Click;
            // 
            // númerosFactorialesToolStripMenuItem
            // 
            númerosFactorialesToolStripMenuItem.Name = "númerosFactorialesToolStripMenuItem";
            númerosFactorialesToolStripMenuItem.Size = new Size(180, 22);
            númerosFactorialesToolStripMenuItem.Text = "Números impares";
            númerosFactorialesToolStripMenuItem.Click += menu_impares_Click;
            // 
            // númerosFactorialesToolStripMenuItem1
            // 
            númerosFactorialesToolStripMenuItem1.Name = "númerosFactorialesToolStripMenuItem1";
            númerosFactorialesToolStripMenuItem1.Size = new Size(180, 22);
            númerosFactorialesToolStripMenuItem1.Text = "Números factoriales";
            númerosFactorialesToolStripMenuItem1.Click += menu_factorial_Click;
            // 
            // tablaDeMultiplicarToolStripMenuItem
            // 
            tablaDeMultiplicarToolStripMenuItem.Name = "tablaDeMultiplicarToolStripMenuItem";
            tablaDeMultiplicarToolStripMenuItem.Size = new Size(180, 22);
            tablaDeMultiplicarToolStripMenuItem.Text = "Tabla de multiplicar";
            tablaDeMultiplicarToolStripMenuItem.Click += menu_tabla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 417);
            label3.Name = "label3";
            label3.Size = new Size(455, 17);
            label3.TabIndex = 8;
            label3.Text = "Ingrese un número para obtener la sumatoria del cero hasta ese número";
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(691, 454);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(btn_Ver);
            Controls.Add(lst_Valor);
            Controls.Add(txt_Valor);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Ejercicio2";
            Text = "Programa 2-Suma de números";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Valor;
        private ListBox lst_Valor;
        private Button btn_Ver;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem verMásToolStripMenuItem;
        private ToolStripMenuItem númerosParesToolStripMenuItem;
        private ToolStripMenuItem númerosFactorialesToolStripMenuItem;
        private ToolStripMenuItem númerosFactorialesToolStripMenuItem1;
        private ToolStripMenuItem tablaDeMultiplicarToolStripMenuItem;
        private Label label3;
    }
}