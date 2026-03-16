namespace _1_2026_TAREA_II
{
    partial class MainMenu
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
            btn_Factorial = new Button();
            btn_Tabla = new Button();
            btn_Pares = new Button();
            btn_Impares = new Button();
            btn_Suma = new Button();
            menuStrip1 = new MenuStrip();
            programa1ToolStripMenuItem = new ToolStripMenuItem();
            programa2ToolStripMenuItem = new ToolStripMenuItem();
            programa3ToolStripMenuItem = new ToolStripMenuItem();
            programa4ToolStripMenuItem = new ToolStripMenuItem();
            programa5ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 80);
            label1.Name = "label1";
            label1.Size = new Size(488, 32);
            label1.TabIndex = 0;
            label1.Text = "Tarea II-Estructuras de control repetitivas";
            // 
            // btn_Factorial
            // 
            btn_Factorial.BackColor = Color.CornflowerBlue;
            btn_Factorial.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Factorial.Location = new Point(208, 305);
            btn_Factorial.Name = "btn_Factorial";
            btn_Factorial.Size = new Size(137, 78);
            btn_Factorial.TabIndex = 1;
            btn_Factorial.Text = "Número factorial";
            btn_Factorial.UseVisualStyleBackColor = false;
            btn_Factorial.Click += Factorial_btn;
            // 
            // btn_Tabla
            // 
            btn_Tabla.BackColor = Color.CornflowerBlue;
            btn_Tabla.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Tabla.Location = new Point(388, 305);
            btn_Tabla.Name = "btn_Tabla";
            btn_Tabla.Size = new Size(134, 78);
            btn_Tabla.TabIndex = 2;
            btn_Tabla.Text = "Tabla de multiplicar";
            btn_Tabla.UseVisualStyleBackColor = false;
            btn_Tabla.Click += tabla_btn;
            // 
            // btn_Pares
            // 
            btn_Pares.BackColor = Color.CornflowerBlue;
            btn_Pares.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Pares.Location = new Point(102, 186);
            btn_Pares.Name = "btn_Pares";
            btn_Pares.Size = new Size(140, 72);
            btn_Pares.TabIndex = 3;
            btn_Pares.Text = "Números pares";
            btn_Pares.UseVisualStyleBackColor = false;
            btn_Pares.Click += pares_btn;
            // 
            // btn_Impares
            // 
            btn_Impares.BackColor = Color.CornflowerBlue;
            btn_Impares.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Impares.Location = new Point(462, 186);
            btn_Impares.Name = "btn_Impares";
            btn_Impares.Size = new Size(156, 72);
            btn_Impares.TabIndex = 4;
            btn_Impares.Text = "Números impares";
            btn_Impares.UseVisualStyleBackColor = false;
            btn_Impares.Click += impare_btn;
            // 
            // btn_Suma
            // 
            btn_Suma.BackColor = Color.CornflowerBlue;
            btn_Suma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Suma.Location = new Point(277, 186);
            btn_Suma.Name = "btn_Suma";
            btn_Suma.Size = new Size(145, 72);
            btn_Suma.TabIndex = 5;
            btn_Suma.Text = "Sumatoria de números";
            btn_Suma.UseVisualStyleBackColor = false;
            btn_Suma.Click += suma_btn;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programa1ToolStripMenuItem, programa2ToolStripMenuItem, programa3ToolStripMenuItem, programa4ToolStripMenuItem, programa5ToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(747, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // programa1ToolStripMenuItem
            // 
            programa1ToolStripMenuItem.Name = "programa1ToolStripMenuItem";
            programa1ToolStripMenuItem.Size = new Size(87, 20);
            programa1ToolStripMenuItem.Text = "Programa #1";
            programa1ToolStripMenuItem.Click += program1_btn;
            // 
            // programa2ToolStripMenuItem
            // 
            programa2ToolStripMenuItem.Name = "programa2ToolStripMenuItem";
            programa2ToolStripMenuItem.Size = new Size(87, 20);
            programa2ToolStripMenuItem.Text = "Programa #2";
            programa2ToolStripMenuItem.Click += program2_btn;
            // 
            // programa3ToolStripMenuItem
            // 
            programa3ToolStripMenuItem.Name = "programa3ToolStripMenuItem";
            programa3ToolStripMenuItem.Size = new Size(87, 20);
            programa3ToolStripMenuItem.Text = "Programa #3";
            programa3ToolStripMenuItem.Click += program3_btn;
            // 
            // programa4ToolStripMenuItem
            // 
            programa4ToolStripMenuItem.Name = "programa4ToolStripMenuItem";
            programa4ToolStripMenuItem.Size = new Size(87, 20);
            programa4ToolStripMenuItem.Text = "Programa #4";
            programa4ToolStripMenuItem.Click += program4_btn;
            // 
            // programa5ToolStripMenuItem
            // 
            programa5ToolStripMenuItem.Name = "programa5ToolStripMenuItem";
            programa5ToolStripMenuItem.Size = new Size(87, 20);
            programa5ToolStripMenuItem.Text = "Programa #5";
            programa5ToolStripMenuItem.Click += program5_btn;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += btn_Salir;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(747, 450);
            Controls.Add(btn_Suma);
            Controls.Add(btn_Impares);
            Controls.Add(btn_Pares);
            Controls.Add(btn_Tabla);
            Controls.Add(btn_Factorial);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Factorial;
        private Button btn_Tabla;
        private Button btn_Pares;
        private Button btn_Impares;
        private Button btn_Suma;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programa1ToolStripMenuItem;
        private ToolStripMenuItem programa2ToolStripMenuItem;
        private ToolStripMenuItem programa3ToolStripMenuItem;
        private ToolStripMenuItem programa4ToolStripMenuItem;
        private ToolStripMenuItem programa5ToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}