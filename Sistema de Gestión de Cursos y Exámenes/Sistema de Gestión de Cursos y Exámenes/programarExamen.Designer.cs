namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class programarExamen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Programar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ListaExamenes = new System.Windows.Forms.ComboBox();
            this.ListaGrupos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListaGrupo = new System.Windows.Forms.ComboBox();
            this.ListaProgramados = new System.Windows.Forms.ComboBox();
            this.Anular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ListaGrupos);
            this.panel2.Controls.Add(this.ListaExamenes);
            this.panel2.Controls.Add(this.Programar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 567);
            this.panel2.TabIndex = 5;
            // 
            // Programar
            // 
            this.Programar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Programar.Location = new System.Drawing.Point(112, 504);
            this.Programar.Name = "Programar";
            this.Programar.Size = new System.Drawing.Size(220, 47);
            this.Programar.TabIndex = 13;
            this.Programar.Text = "Programar";
            this.Programar.UseVisualStyleBackColor = true;
            this.Programar.Click += new System.EventHandler(this.abrirPeriodoBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Examen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Programar Examen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grupo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ListaExamenes
            // 
            this.ListaExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListaExamenes.FormattingEnabled = true;
            this.ListaExamenes.Location = new System.Drawing.Point(21, 222);
            this.ListaExamenes.Name = "ListaExamenes";
            this.ListaExamenes.Size = new System.Drawing.Size(329, 33);
            this.ListaExamenes.TabIndex = 25;
            this.ListaExamenes.SelectedIndexChanged += new System.EventHandler(this.periodoEliminado_SelectedIndexChanged);
            // 
            // ListaGrupos
            // 
            this.ListaGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListaGrupos.FormattingEnabled = true;
            this.ListaGrupos.Location = new System.Drawing.Point(21, 105);
            this.ListaGrupos.Name = "ListaGrupos";
            this.ListaGrupos.Size = new System.Drawing.Size(329, 33);
            this.ListaGrupos.TabIndex = 26;
            this.ListaGrupos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ListaGrupo);
            this.panel1.Controls.Add(this.ListaProgramados);
            this.panel1.Controls.Add(this.Anular);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(482, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 567);
            this.panel1.TabIndex = 27;
            // 
            // ListaGrupo
            // 
            this.ListaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListaGrupo.FormattingEnabled = true;
            this.ListaGrupo.Location = new System.Drawing.Point(21, 105);
            this.ListaGrupo.Name = "ListaGrupo";
            this.ListaGrupo.Size = new System.Drawing.Size(329, 33);
            this.ListaGrupo.TabIndex = 26;
            this.ListaGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ListaProgramados
            // 
            this.ListaProgramados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListaProgramados.FormattingEnabled = true;
            this.ListaProgramados.Location = new System.Drawing.Point(21, 222);
            this.ListaProgramados.Name = "ListaProgramados";
            this.ListaProgramados.Size = new System.Drawing.Size(329, 33);
            this.ListaProgramados.TabIndex = 25;
            this.ListaProgramados.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Anular
            // 
            this.Anular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Anular.Location = new System.Drawing.Point(112, 504);
            this.Anular.Name = "Anular";
            this.Anular.Size = new System.Drawing.Size(220, 47);
            this.Anular.TabIndex = 13;
            this.Anular.Text = "Anular";
            this.Anular.UseVisualStyleBackColor = true;
            this.Anular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Examen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cancelar Examen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Grupo";
            // 
            // programarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "programarExamen";
            this.Text = "programarExamen";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Programar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ListaGrupos;
        private System.Windows.Forms.ComboBox ListaExamenes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ListaGrupo;
        private System.Windows.Forms.ComboBox ListaProgramados;
        private System.Windows.Forms.Button Anular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}