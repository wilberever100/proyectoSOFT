namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionUnidadesTematicas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.agregarEnCurso = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Objetivos = new System.Windows.Forms.TabPage();
            this.Contenidos = new System.Windows.Forms.TabPage();
            this.nombreUT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarUTBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removerUT = new System.Windows.Forms.ComboBox();
            this.removerEnCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removerUTBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.agregarEnCurso);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.nombreUT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.agregarUTBT);
            this.panel1.Location = new System.Drawing.Point(72, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 544);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Curso";
            // 
            // agregarEnCurso
            // 
            this.agregarEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.agregarEnCurso.FormattingEnabled = true;
            this.agregarEnCurso.Location = new System.Drawing.Point(19, 99);
            this.agregarEnCurso.Name = "agregarEnCurso";
            this.agregarEnCurso.Size = new System.Drawing.Size(329, 33);
            this.agregarEnCurso.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Objetivos);
            this.tabControl1.Controls.Add(this.Contenidos);
            this.tabControl1.Location = new System.Drawing.Point(19, 261);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 177);
            this.tabControl1.TabIndex = 12;
            // 
            // Objetivos
            // 
            this.Objetivos.Location = new System.Drawing.Point(4, 22);
            this.Objetivos.Name = "Objetivos";
            this.Objetivos.Padding = new System.Windows.Forms.Padding(3);
            this.Objetivos.Size = new System.Drawing.Size(329, 151);
            this.Objetivos.TabIndex = 0;
            this.Objetivos.Text = "tabPage1";
            this.Objetivos.UseVisualStyleBackColor = true;
            // 
            // Contenidos
            // 
            this.Contenidos.Location = new System.Drawing.Point(4, 22);
            this.Contenidos.Name = "Contenidos";
            this.Contenidos.Padding = new System.Windows.Forms.Padding(3);
            this.Contenidos.Size = new System.Drawing.Size(329, 151);
            this.Contenidos.TabIndex = 1;
            this.Contenidos.Text = "tabPage2";
            this.Contenidos.UseVisualStyleBackColor = true;
            // 
            // nombreUT
            // 
            this.nombreUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nombreUT.Location = new System.Drawing.Point(19, 197);
            this.nombreUT.Name = "nombreUT";
            this.nombreUT.Size = new System.Drawing.Size(333, 30);
            this.nombreUT.TabIndex = 8;
            this.nombreUT.TextChanged += new System.EventHandler(this.nuevoCurso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Unidad Tematica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // agregarUTBT
            // 
            this.agregarUTBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.agregarUTBT.Location = new System.Drawing.Point(72, 473);
            this.agregarUTBT.Name = "agregarUTBT";
            this.agregarUTBT.Size = new System.Drawing.Size(220, 47);
            this.agregarUTBT.TabIndex = 11;
            this.agregarUTBT.Text = "Guardar";
            this.agregarUTBT.UseVisualStyleBackColor = true;
            this.agregarUTBT.Click += new System.EventHandler(this.guardarNuevoCursoBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.removerUT);
            this.panel2.Controls.Add(this.removerEnCurso);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.removerUTBT);
            this.panel2.Location = new System.Drawing.Point(526, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 544);
            this.panel2.TabIndex = 3;
            // 
            // removerUT
            // 
            this.removerUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.removerUT.FormattingEnabled = true;
            this.removerUT.Location = new System.Drawing.Point(19, 197);
            this.removerUT.Name = "removerUT";
            this.removerUT.Size = new System.Drawing.Size(329, 33);
            this.removerUT.TabIndex = 22;
            // 
            // removerEnCurso
            // 
            this.removerEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.removerEnCurso.FormattingEnabled = true;
            this.removerEnCurso.Location = new System.Drawing.Point(19, 99);
            this.removerEnCurso.Name = "removerEnCurso";
            this.removerEnCurso.Size = new System.Drawing.Size(329, 33);
            this.removerEnCurso.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unidades Tematicas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(26, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remover Unidad Tematica";
            // 
            // removerUTBT
            // 
            this.removerUTBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.removerUTBT.Location = new System.Drawing.Point(76, 357);
            this.removerUTBT.Name = "removerUTBT";
            this.removerUTBT.Size = new System.Drawing.Size(220, 47);
            this.removerUTBT.TabIndex = 11;
            this.removerUTBT.Text = "Guardar";
            this.removerUTBT.UseVisualStyleBackColor = true;
            this.removerUTBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestionUnidadesTematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "gestionUnidadesTematicas";
            this.Text = "gestionUnidadesTematicas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombreUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarUTBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removerUTBT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Objetivos;
        private System.Windows.Forms.TabPage Contenidos;
        private System.Windows.Forms.ComboBox agregarEnCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox removerEnCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox removerUT;
    }
}