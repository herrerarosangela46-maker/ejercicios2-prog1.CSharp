namespace _1_2026_TAREA_II
{
    partial class Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_Numero = new TextBox();
            label2 = new Label();
            btn_Mostrar = new Button();
            lst_Numero = new ListBox();
            menuStrip2 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            númerosParesToolStripMenuItem = new ToolStripMenuItem();
            mostrarResultadoToolStripMenuItem = new ToolStripMenuItem();
            verMásToolStripMenuItem = new ToolStripMenuItem();
            númerosImparesToolStripMenuItem = new ToolStripMenuItem();
            sumaDeNúmerosToolStripMenuItem = new ToolStripMenuItem();
            númeroFactorialToolStripMenuItem = new ToolStripMenuItem();
            tablaDeMultiplicarToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 55);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 0;
            label1.Text = "Números pares";
            // 
            // txt_Numero
            // 
            txt_Numero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_Numero.Location = new Point(249, 125);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(145, 29);
            txt_Numero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(87, 125);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 2;
            label2.Text = "Digite un número";
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.Azure;
            btn_Mostrar.Cursor = Cursors.Hand;
            btn_Mostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Mostrar.Location = new Point(87, 178);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(145, 37);
            btn_Mostrar.TabIndex = 3;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            btn_Mostrar.MouseHover += _btn_Hover;
            // 
            // lst_Numero
            // 
            lst_Numero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lst_Numero.FormattingEnabled = true;
            lst_Numero.ItemHeight = 21;
            lst_Numero.Location = new Point(249, 178);
            lst_Numero.Name = "lst_Numero";
            lst_Numero.Size = new Size(145, 214);
            lst_Numero.TabIndex = 4;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(192, 192, 255);
            menuStrip2.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, númerosParesToolStripMenuItem, verMásToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(540, 24);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "Números pares";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(180, 22);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // númerosParesToolStripMenuItem
            // 
            númerosParesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarResultadoToolStripMenuItem });
            númerosParesToolStripMenuItem.Name = "númerosParesToolStripMenuItem";
            númerosParesToolStripMenuItem.Size = new Size(99, 20);
            númerosParesToolStripMenuItem.Text = "Números pares";
            númerosParesToolStripMenuItem.Click += númerosParesToolStripMenuItem_Click;
            // 
            // mostrarResultadoToolStripMenuItem
            // 
            mostrarResultadoToolStripMenuItem.Name = "mostrarResultadoToolStripMenuItem";
            mostrarResultadoToolStripMenuItem.Size = new Size(180, 22);
            mostrarResultadoToolStripMenuItem.Text = "Mostrar resultado";
            mostrarResultadoToolStripMenuItem.Click += btn_Mostrar_Click;
            // 
            // verMásToolStripMenuItem
            // 
            verMásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { númerosImparesToolStripMenuItem, sumaDeNúmerosToolStripMenuItem, númeroFactorialToolStripMenuItem, tablaDeMultiplicarToolStripMenuItem });
            verMásToolStripMenuItem.Name = "verMásToolStripMenuItem";
            verMásToolStripMenuItem.Size = new Size(82, 20);
            verMásToolStripMenuItem.Text = "Formularios";
            // 
            // númerosImparesToolStripMenuItem
            // 
            númerosImparesToolStripMenuItem.Name = "númerosImparesToolStripMenuItem";
            númerosImparesToolStripMenuItem.Size = new Size(180, 22);
            númerosImparesToolStripMenuItem.Text = "Suma de números";
            númerosImparesToolStripMenuItem.Click += btnClick_Click;
            // 
            // sumaDeNúmerosToolStripMenuItem
            // 
            sumaDeNúmerosToolStripMenuItem.Name = "sumaDeNúmerosToolStripMenuItem";
            sumaDeNúmerosToolStripMenuItem.Size = new Size(180, 22);
            sumaDeNúmerosToolStripMenuItem.Text = "Número impares";
            sumaDeNúmerosToolStripMenuItem.Click += submenuSegundo_Click;
            // 
            // númeroFactorialToolStripMenuItem
            // 
            númeroFactorialToolStripMenuItem.Name = "númeroFactorialToolStripMenuItem";
            númeroFactorialToolStripMenuItem.Size = new Size(180, 22);
            númeroFactorialToolStripMenuItem.Text = "Número factorial";
            númeroFactorialToolStripMenuItem.Click += submenuTercero_Click;
            // 
            // tablaDeMultiplicarToolStripMenuItem
            // 
            tablaDeMultiplicarToolStripMenuItem.Name = "tablaDeMultiplicarToolStripMenuItem";
            tablaDeMultiplicarToolStripMenuItem.Size = new Size(180, 22);
            tablaDeMultiplicarToolStripMenuItem.Text = "Tabla de multiplicar";
            tablaDeMultiplicarToolStripMenuItem.Click += submenuCuarto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 441);
            label3.Name = "label3";
            label3.Size = new Size(442, 17);
            label3.TabIndex = 7;
            label3.Text = "Ingrese un número  para obtener los números pares hasta ese número";
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(540, 492);
            Controls.Add(label3);
            Controls.Add(lst_Numero);
            Controls.Add(btn_Mostrar);
            Controls.Add(label2);
            Controls.Add(txt_Numero);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Name = "Ejercicio1";
            Text = "Programa 1-Números pares";
            Load += Ejercicio1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Numero;
        private Label label2;
        private Button btn_Mostrar;
        private ListBox lst_Numero;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem númerosParesToolStripMenuItem;
        private ToolStripMenuItem mostrarResultadoToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem verMásToolStripMenuItem;
        private ToolStripMenuItem númerosImparesToolStripMenuItem;
        private ToolStripMenuItem sumaDeNúmerosToolStripMenuItem;
        private ToolStripMenuItem númeroFactorialToolStripMenuItem;
        private ToolStripMenuItem tablaDeMultiplicarToolStripMenuItem;
        private Label label3;
    }
}
