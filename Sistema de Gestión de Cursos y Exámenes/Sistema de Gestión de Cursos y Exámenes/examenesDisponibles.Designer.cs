namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class examenesDisponibles
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
            this.tablaProfesores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datos = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProfesores
            // 
            this.tablaProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Datos});
            this.tablaProfesores.Location = new System.Drawing.Point(34, 34);
            this.tablaProfesores.Name = "tablaProfesores";
            this.tablaProfesores.Size = new System.Drawing.Size(1196, 609);
            this.tablaProfesores.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Examenes Disponibles";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Datos
            // 
            this.Datos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datos.HeaderText = "Rendir Examen";
            this.Datos.Name = "Datos";
            this.Datos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Datos.Text = "Rendir Examen";
            this.Datos.UseColumnTextForButtonValue = true;
            // 
            // examenesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tablaProfesores);
            this.Name = "examenesDisponibles";
            this.Text = "examenesDisponibles";
            this.Load += new System.EventHandler(this.examenesDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Datos;
    }
}