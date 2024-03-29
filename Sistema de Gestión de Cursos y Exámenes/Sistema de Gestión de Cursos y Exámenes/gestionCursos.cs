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
   

    public partial class gestionCursos : Form
    {
        public gestionCursos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void profesorAsignado_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.PROFESOR_GLOBAL.Count; i++)
            {
                string nuevo = BD.PROFESOR_GLOBAL[i].nombre;
                profesorAsignado.Items.Add(nuevo);
            }
            profesorAsignado.SelectedIndex=0;

        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void refreshItemsEliminado()
        {
            cursoEliminado.Items.Clear();
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                cursoEliminado.Items.Add(nuevo);
            }
            //cursoEliminado.SelectedIndex = 0;
        }
        private void guardarNuevoCursoBT_Click(object sender, EventArgs e)
        {

            string nombre = this.nuevoCurso.Text;

            

            Curso foo = new Curso(nombre);
            BD.CURSO_GLOBAL.Add(foo);
            this.nuevoCurso.Text = string.Empty; //borra lo escrito
            MessageBox.Show("Creado exitosamente");


            //PONIENDO EN ELIMINADO
            refreshItemsEliminado();
        }

        private void asignarCursoBT_Click(object sender, EventArgs e)
        {
            BD.CURSO_GLOBAL[cursoAsignado.SelectedIndex].asignar(BD.GRUPO_GLOBAL[grupoAsignado.SelectedIndex], BD.PROFESOR_GLOBAL[profesorAsignado.SelectedIndex], BD.PERIODO_ACADEMICO_GLOBAL[periodoAsignado.SelectedIndex]);
            MessageBox.Show("Asignado exitosamente");

        }

        private void eliminarCursoBT_Click(object sender, EventArgs e)
        {
            BD.CURSO_GLOBAL.RemoveAt(cursoEliminado.SelectedIndex);
            refreshItemsEliminado();
        }
        private void periodoAsignado_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.PERIODO_ACADEMICO_GLOBAL.Count; i++)
            {
                string nuevo = BD.PERIODO_ACADEMICO_GLOBAL[i].m_periodo;
                periodoAsignado.Items.Add(nuevo);
            }
            periodoAsignado.SelectedIndex = 0;

        }
        private void grupoAsignado_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.GRUPO_GLOBAL.Count; i++)
            {
                string nuevo = BD.GRUPO_GLOBAL[i].identificador;
                grupoAsignado.Items.Add(nuevo);
            }
            grupoAsignado.SelectedIndex = 0;

        }
        private void cursoAsignado_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                cursoAsignado.Items.Add(nuevo);
            }
            cursoAsignado.SelectedIndex = 0;

        }
        private void cursoEliminado_Loaded(object sender, EventArgs e)
        {
            cursoEliminado.Items.Clear();
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                cursoEliminado.Items.Add(nuevo);
            }
            //cursoEliminado.SelectedIndex = 0;

        }
        private void periodoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void profesorAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cursoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form back= new menuDirector();
            back.ShowDialog();
            this.Close();
        }
    }
    public class Curso
    {
        public string nombre;
        public List<Grupo> Grupos;
        public List<unidad_tematica> unidadesTematicas;


        public Curso(string nom)
        {
            this.nombre = nom;
            
        }
        ~Curso()
        {
           
        }
        public Curso getCurso()
        {
            return this;
        }

        public bool asignar(Grupo grupito, Profesor profe, Periodo_Academico periodo)
        {
            grupito.curso = this;
            grupito.encargado = profe;
            grupito.periodo = periodo;
            return true;
        }

        public bool añadirUnidadTematica(unidad_tematica ut)
        {
            unidadesTematicas.Add(ut);
            return true;
        }

    }

    public class Grupo
    {
        public int id;
        public Profesor encargado;
        public Curso curso;
        public Periodo_Academico periodo;
        public string identificador;
        public int cupos;
        public List<Alumno> Alumnos;

        public Grupo(int num_cupos)
        {
            this.cupos = num_cupos;
        }
        ~Grupo()
        {

        }

        public bool añadirProfesor(Profesor profe)
        {
            encargado = profe;
            return true;
        }

        public bool añadirAlumno(int idAlumno)
        {
            BD.ALUMNO_GLOBAL[idAlumno].añadirGrupo(id);
            Alumnos.Add(BD.ALUMNO_GLOBAL[idAlumno]);
            return true;
        }

        public bool retirarAlumno(int idAlumno)
        {
            if (!BD.ALUMNO_GLOBAL[idAlumno].retirarGrupo(id))
                return false;
            Alumnos.Remove(BD.ALUMNO_GLOBAL[idAlumno]);
            return true;
        }

    }

    public class unidad_tematica
    {
        public string nombre;
        public List<string> Objetivos;
        public List<string> Contenido;

        public unidad_tematica(string name)
        {
            this.nombre = name;
        }

        public bool añadirObj(string nuevo)
        {
            Objetivos.Add(nuevo);
            return true;
        }

        public bool añadirCon(string nuevo)
        {
            Contenido.Add(nuevo);
            return true;
        }

        public bool eliminarObj(int index)
        {
            Objetivos.Remove(Objetivos[index]);
            return true;
        }

        public bool eliminarCon(int index)
        {
            Contenido.Remove(Contenido[index]);
            return true;
        }
    }
}
