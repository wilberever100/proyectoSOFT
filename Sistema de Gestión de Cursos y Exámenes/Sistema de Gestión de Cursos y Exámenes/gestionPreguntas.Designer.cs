namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionPreguntas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PREGUNTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DESARROLLO = new System.Windows.Forms.RadioButton();
            this.CONCRETA = new System.Windows.Forms.RadioButton();
            this.CHOICE = new System.Windows.Forms.RadioButton();
            this.TRUEFALSE = new System.Windows.Forms.RadioButton();
            this.PAIR = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.REGLONES = new System.Windows.Forms.NumericUpDown();
            this.rptaCHOICE = new System.Windows.Forms.TextBox();
            this.UPLOADW = new System.Windows.Forms.Button();
            this.FALSO = new System.Windows.Forms.TextBox();
            this.unoPAIR = new System.Windows.Forms.TextBox();
            this.dosPAIR = new System.Windows.Forms.TextBox();
            this.UPLOAD2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DISPLAYPREGUNTA = new System.Windows.Forms.Label();
            this.GENERALUPDATE = new System.Windows.Forms.Button();
            this.SEE = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CURSO = new System.Windows.Forms.TextBox();
            this.RPTAQ = new System.Windows.Forms.TextBox();
            this.VERDADERO = new System.Windows.Forms.TextBox();
            this.CORRECT = new System.Windows.Forms.TextBox();
            this.UPLOADR = new System.Windows.Forms.Button();
            this.UPLOADF = new System.Windows.Forms.Button();
            this.UPLOADT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.REGLONES)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de preguntas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coloque el planteamiento de la pregunta";
            // 
            // PREGUNTA
            // 
            this.PREGUNTA.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PREGUNTA.Location = new System.Drawing.Point(23, 138);
            this.PREGUNTA.Margin = new System.Windows.Forms.Padding(4);
            this.PREGUNTA.Multiline = true;
            this.PREGUNTA.Name = "PREGUNTA";
            this.PREGUNTA.Size = new System.Drawing.Size(475, 78);
            this.PREGUNTA.TabIndex = 2;
            this.PREGUNTA.Text = "Cuerpo de la pregunta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione el tipo de pregunta:";
            // 
            // DESARROLLO
            // 
            this.DESARROLLO.AutoSize = true;
            this.DESARROLLO.Location = new System.Drawing.Point(23, 296);
            this.DESARROLLO.Margin = new System.Windows.Forms.Padding(4);
            this.DESARROLLO.Name = "DESARROLLO";
            this.DESARROLLO.Size = new System.Drawing.Size(158, 21);
            this.DESARROLLO.TabIndex = 4;
            this.DESARROLLO.TabStop = true;
            this.DESARROLLO.Text = "Escrita de Desarrollo";
            this.DESARROLLO.UseVisualStyleBackColor = true;
            // 
            // CONCRETA
            // 
            this.CONCRETA.AutoSize = true;
            this.CONCRETA.Location = new System.Drawing.Point(23, 325);
            this.CONCRETA.Margin = new System.Windows.Forms.Padding(4);
            this.CONCRETA.Name = "CONCRETA";
            this.CONCRETA.Size = new System.Drawing.Size(222, 21);
            this.CONCRETA.TabIndex = 5;
            this.CONCRETA.TabStop = true;
            this.CONCRETA.Text = "Escrita de Respuesta Concreta";
            this.CONCRETA.UseVisualStyleBackColor = true;
            // 
            // CHOICE
            // 
            this.CHOICE.AutoSize = true;
            this.CHOICE.Location = new System.Drawing.Point(23, 354);
            this.CHOICE.Margin = new System.Windows.Forms.Padding(4);
            this.CHOICE.Name = "CHOICE";
            this.CHOICE.Size = new System.Drawing.Size(145, 21);
            this.CHOICE.TabIndex = 6;
            this.CHOICE.TabStop = true;
            this.CHOICE.Text = "Alternativa Multiple";
            this.CHOICE.UseVisualStyleBackColor = true;
            // 
            // TRUEFALSE
            // 
            this.TRUEFALSE.AutoSize = true;
            this.TRUEFALSE.Location = new System.Drawing.Point(23, 456);
            this.TRUEFALSE.Margin = new System.Windows.Forms.Padding(4);
            this.TRUEFALSE.Name = "TRUEFALSE";
            this.TRUEFALSE.Size = new System.Drawing.Size(139, 21);
            this.TRUEFALSE.TabIndex = 7;
            this.TRUEFALSE.TabStop = true;
            this.TRUEFALSE.Text = "Verdadero / Falso";
            this.TRUEFALSE.UseVisualStyleBackColor = true;
            // 
            // PAIR
            // 
            this.PAIR.AutoSize = true;
            this.PAIR.Location = new System.Drawing.Point(23, 554);
            this.PAIR.Margin = new System.Windows.Forms.Padding(4);
            this.PAIR.Name = "PAIR";
            this.PAIR.Size = new System.Drawing.Size(128, 21);
            this.PAIR.TabIndex = 8;
            this.PAIR.TabStop = true;
            this.PAIR.Text = "Emparejamiento";
            this.PAIR.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad de Reglones:";
            // 
            // REGLONES
            // 
            this.REGLONES.Location = new System.Drawing.Point(385, 296);
            this.REGLONES.Name = "REGLONES";
            this.REGLONES.Size = new System.Drawing.Size(53, 23);
            this.REGLONES.TabIndex = 10;
            // 
            // rptaCHOICE
            // 
            this.rptaCHOICE.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rptaCHOICE.Location = new System.Drawing.Point(39, 383);
            this.rptaCHOICE.Margin = new System.Windows.Forms.Padding(4);
            this.rptaCHOICE.Name = "rptaCHOICE";
            this.rptaCHOICE.Size = new System.Drawing.Size(240, 23);
            this.rptaCHOICE.TabIndex = 11;
            this.rptaCHOICE.Text = "Escriba aqui  cualquier alternativa";
            // 
            // UPLOADW
            // 
            this.UPLOADW.Location = new System.Drawing.Point(303, 383);
            this.UPLOADW.Name = "UPLOADW";
            this.UPLOADW.Size = new System.Drawing.Size(75, 23);
            this.UPLOADW.TabIndex = 12;
            this.UPLOADW.Text = "Subir";
            this.UPLOADW.UseVisualStyleBackColor = true;
            this.UPLOADW.Click += new System.EventHandler(this.UPLOADW_Click);
            // 
            // FALSO
            // 
            this.FALSO.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FALSO.Location = new System.Drawing.Point(39, 523);
            this.FALSO.Margin = new System.Windows.Forms.Padding(4);
            this.FALSO.Name = "FALSO";
            this.FALSO.Size = new System.Drawing.Size(240, 23);
            this.FALSO.TabIndex = 13;
            this.FALSO.Text = "Escriba aqui la alternativa falsa";
            // 
            // unoPAIR
            // 
            this.unoPAIR.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.unoPAIR.Location = new System.Drawing.Point(39, 583);
            this.unoPAIR.Margin = new System.Windows.Forms.Padding(4);
            this.unoPAIR.Name = "unoPAIR";
            this.unoPAIR.Size = new System.Drawing.Size(123, 23);
            this.unoPAIR.TabIndex = 14;
            this.unoPAIR.Text = "Preposicion";
            // 
            // dosPAIR
            // 
            this.dosPAIR.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dosPAIR.Location = new System.Drawing.Point(173, 583);
            this.dosPAIR.Margin = new System.Windows.Forms.Padding(4);
            this.dosPAIR.Name = "dosPAIR";
            this.dosPAIR.Size = new System.Drawing.Size(123, 23);
            this.dosPAIR.TabIndex = 15;
            this.dosPAIR.Text = "Respuesta";
            // 
            // UPLOAD2
            // 
            this.UPLOAD2.Location = new System.Drawing.Point(328, 583);
            this.UPLOAD2.Name = "UPLOAD2";
            this.UPLOAD2.Size = new System.Drawing.Size(75, 23);
            this.UPLOAD2.TabIndex = 16;
            this.UPLOAD2.Text = "+";
            this.UPLOAD2.UseVisualStyleBackColor = true;
            this.UPLOAD2.Click += new System.EventHandler(this.UPLOAD2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "La pregunta es:";
            // 
            // DISPLAYPREGUNTA
            // 
            this.DISPLAYPREGUNTA.AutoSize = true;
            this.DISPLAYPREGUNTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISPLAYPREGUNTA.Location = new System.Drawing.Point(655, 141);
            this.DISPLAYPREGUNTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DISPLAYPREGUNTA.Name = "DISPLAYPREGUNTA";
            this.DISPLAYPREGUNTA.Size = new System.Drawing.Size(177, 17);
            this.DISPLAYPREGUNTA.TabIndex = 18;
            this.DISPLAYPREGUNTA.Text = "Informacion de la pregunta";
            // 
            // GENERALUPDATE
            // 
            this.GENERALUPDATE.Location = new System.Drawing.Point(658, 381);
            this.GENERALUPDATE.Name = "GENERALUPDATE";
            this.GENERALUPDATE.Size = new System.Drawing.Size(125, 96);
            this.GENERALUPDATE.TabIndex = 19;
            this.GENERALUPDATE.Text = "Guardar en Banco de Preguntas";
            this.GENERALUPDATE.UseVisualStyleBackColor = true;
            this.GENERALUPDATE.Click += new System.EventHandler(this.GENERALUPDATE_Click);
            // 
            // SEE
            // 
            this.SEE.Location = new System.Drawing.Point(860, 381);
            this.SEE.Name = "SEE";
            this.SEE.Size = new System.Drawing.Size(125, 96);
            this.SEE.TabIndex = 20;
            this.SEE.Text = "Ver Banco de Preguntas";
            this.SEE.UseVisualStyleBackColor = true;
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(635, 22);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(197, 35);
            this.BACK.TabIndex = 21;
            this.BACK.Text = "Retroceder";
            this.BACK.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 622);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Coloque el nombre del curso";
            // 
            // CURSO
            // 
            this.CURSO.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CURSO.Location = new System.Drawing.Point(39, 661);
            this.CURSO.Margin = new System.Windows.Forms.Padding(4);
            this.CURSO.Name = "CURSO";
            this.CURSO.Size = new System.Drawing.Size(212, 23);
            this.CURSO.TabIndex = 23;
            this.CURSO.Text = "Curso aqui";
            // 
            // RPTAQ
            // 
            this.RPTAQ.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RPTAQ.Location = new System.Drawing.Point(253, 326);
            this.RPTAQ.Margin = new System.Windows.Forms.Padding(4);
            this.RPTAQ.Name = "RPTAQ";
            this.RPTAQ.Size = new System.Drawing.Size(212, 23);
            this.RPTAQ.TabIndex = 24;
            this.RPTAQ.Text = "Respuesta aqui";
            // 
            // VERDADERO
            // 
            this.VERDADERO.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.VERDADERO.Location = new System.Drawing.Point(39, 492);
            this.VERDADERO.Margin = new System.Windows.Forms.Padding(4);
            this.VERDADERO.Name = "VERDADERO";
            this.VERDADERO.Size = new System.Drawing.Size(240, 23);
            this.VERDADERO.TabIndex = 25;
            this.VERDADERO.Text = "Escriba aqui la alternativa verdadera";
            // 
            // CORRECT
            // 
            this.CORRECT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CORRECT.Location = new System.Drawing.Point(39, 418);
            this.CORRECT.Margin = new System.Windows.Forms.Padding(4);
            this.CORRECT.Name = "CORRECT";
            this.CORRECT.Size = new System.Drawing.Size(240, 23);
            this.CORRECT.TabIndex = 26;
            this.CORRECT.Text = "Escriba aqui la alternativa correcta";
            // 
            // UPLOADR
            // 
            this.UPLOADR.Location = new System.Drawing.Point(303, 418);
            this.UPLOADR.Name = "UPLOADR";
            this.UPLOADR.Size = new System.Drawing.Size(75, 23);
            this.UPLOADR.TabIndex = 27;
            this.UPLOADR.Text = "Subir";
            this.UPLOADR.UseVisualStyleBackColor = true;
            this.UPLOADR.Click += new System.EventHandler(this.UPLOADR_Click);
            // 
            // UPLOADF
            // 
            this.UPLOADF.Location = new System.Drawing.Point(303, 527);
            this.UPLOADF.Name = "UPLOADF";
            this.UPLOADF.Size = new System.Drawing.Size(75, 23);
            this.UPLOADF.TabIndex = 29;
            this.UPLOADF.Text = "Subir";
            this.UPLOADF.UseVisualStyleBackColor = true;
            this.UPLOADF.Click += new System.EventHandler(this.UPLOADF_Click);
            // 
            // UPLOADT
            // 
            this.UPLOADT.Location = new System.Drawing.Point(303, 492);
            this.UPLOADT.Name = "UPLOADT";
            this.UPLOADT.Size = new System.Drawing.Size(75, 23);
            this.UPLOADT.TabIndex = 28;
            this.UPLOADT.Text = "Subir";
            this.UPLOADT.UseVisualStyleBackColor = true;
            this.UPLOADT.Click += new System.EventHandler(this.UPLOADT_Click);
            // 
            // gestionPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.UPLOADF);
            this.Controls.Add(this.UPLOADT);
            this.Controls.Add(this.UPLOADR);
            this.Controls.Add(this.CORRECT);
            this.Controls.Add(this.VERDADERO);
            this.Controls.Add(this.RPTAQ);
            this.Controls.Add(this.CURSO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.SEE);
            this.Controls.Add(this.GENERALUPDATE);
            this.Controls.Add(this.DISPLAYPREGUNTA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UPLOAD2);
            this.Controls.Add(this.dosPAIR);
            this.Controls.Add(this.unoPAIR);
            this.Controls.Add(this.FALSO);
            this.Controls.Add(this.UPLOADW);
            this.Controls.Add(this.rptaCHOICE);
            this.Controls.Add(this.REGLONES);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PAIR);
            this.Controls.Add(this.TRUEFALSE);
            this.Controls.Add(this.CHOICE);
            this.Controls.Add(this.CONCRETA);
            this.Controls.Add(this.DESARROLLO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PREGUNTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gestionPreguntas";
            this.Text = "gestionPreguntas";
            this.Load += new System.EventHandler(this.gestionPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REGLONES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PREGUNTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton DESARROLLO;
        private System.Windows.Forms.RadioButton CONCRETA;
        private System.Windows.Forms.RadioButton CHOICE;
        private System.Windows.Forms.RadioButton TRUEFALSE;
        private System.Windows.Forms.RadioButton PAIR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown REGLONES;
        private System.Windows.Forms.TextBox rptaCHOICE;
        private System.Windows.Forms.Button UPLOADW;
        private System.Windows.Forms.TextBox FALSO;
        private System.Windows.Forms.TextBox unoPAIR;
        private System.Windows.Forms.TextBox dosPAIR;
        private System.Windows.Forms.Button UPLOAD2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DISPLAYPREGUNTA;
        private System.Windows.Forms.Button GENERALUPDATE;
        private System.Windows.Forms.Button SEE;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CURSO;
        private System.Windows.Forms.TextBox RPTAQ;
        private System.Windows.Forms.TextBox VERDADERO;
        private System.Windows.Forms.TextBox CORRECT;
        private System.Windows.Forms.Button UPLOADR;
        private System.Windows.Forms.Button UPLOADF;
        private System.Windows.Forms.Button UPLOADT;
    }
}