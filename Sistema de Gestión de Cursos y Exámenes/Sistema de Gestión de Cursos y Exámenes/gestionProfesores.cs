﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    public partial class gestionProfesores : Form
    {
        public gestionProfesores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            agregarDatosBT.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tablaProfesores.Columns[e.ColumnIndex].Name == "Datos")
            {
                int index = e.RowIndex;
                textBox1.Text = BD.PROFESOR_GLOBAL[index].nombre;
                textBox2.Text = BD.PROFESOR_GLOBAL[index].apellido;
                textBox3.Text = BD.PROFESOR_GLOBAL[index].DNI.ToString();
                textBox4.Text = BD.PROFESOR_GLOBAL[index].usuario;
                textBox5.Text = BD.PROFESOR_GLOBAL[index].contraseña;
                agregarDatosBT.Enabled = false;
            }

            
        }

        private void mostrarProfes_Click(object sender, EventArgs e)
        {
            tablaProfesores.Rows.Clear();
            DataGridViewRow row = (DataGridViewRow)tablaProfesores.Rows[0].Clone();
            
            
            tablaProfesores.Rows.Add(row);

            for (int i = 0; i < BD.PROFESOR_GLOBAL.Count; i++)
            {
                row.Cells["Column1"].Value = BD.PROFESOR_GLOBAL[i].nombre;
                tablaProfesores.Rows.Add(row);
            }

            
            
        }

        private void agregarProfes_Click(object sender, EventArgs e)
        {
            agregarDatosBT.Enabled = true;
        }

        private void agregarDatosBT_Click(object sender, EventArgs e)
        {
            Profesor nuevo = new Profesor();
            nuevo.nombre = textBox1.Text;
            nuevo.apellido = textBox2.Text;
            nuevo.DNI = Int32.Parse(textBox3.Text);
            nuevo.usuario = textBox4.Text;
            nuevo.contraseña = textBox5.Text;
            BD.PROFESOR_GLOBAL.Add(nuevo);

        }
    }

    public class Profesor
    {
        
        public string usuario,contraseña;
        public List<Curso> cursos;
        public List<Curso> grupos;
        public string nombre, apellido;
        public int DNI;


    }
}
