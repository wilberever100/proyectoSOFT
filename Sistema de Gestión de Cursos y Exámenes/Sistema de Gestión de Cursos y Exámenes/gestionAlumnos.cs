using System;
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
    public partial class gestionAlumnos : Form
    {
        public gestionAlumnos()
        {
            InitializeComponent();
        }

        private void MatriculaCurso_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                MatriculaCurso.Items.Add(nuevo);
            }
            MatriculaCurso.SelectedIndex = 0;

        }
        private void MatriculaGrupo_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.GRUPO_GLOBAL.Count; i++)
            {
                string nuevo = BD.GRUPO_GLOBAL[i].identificador;
                MatriculaGrupo.Items.Add(nuevo);
            }
            MatriculaGrupo.SelectedIndex = 0;
        }

        private void RetirarCurso_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                RetirarCurso.Items.Add(nuevo);
            }
            RetirarCurso.SelectedIndex = 0;

        }
        private void RetirarGrupo_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.GRUPO_GLOBAL.Count; i++)
            {
                string nuevo = BD.GRUPO_GLOBAL[i].identificador;
                RetirarGrupo.Items.Add(nuevo);
            }
            RetirarGrupo.SelectedIndex = 0;
        }

        private void MatricularBT_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.MatriculaAlumno.Text);
            BD.GRUPO_GLOBAL[RetirarGrupo.SelectedIndex].añadirAlumno(id);
        }

        private void RetirarBT_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.RetirarAlumno.Text);
            BD.GRUPO_GLOBAL[RetirarGrupo.SelectedIndex].retirarAlumno(id);
        }
    }

    public class Alumno {
        bool activo;
        string usuario, contraseña;
        string nombre, apellido;
        List<int> Grupos; // Almacena solo el id del grupo
        List<Examen> Examenes;

        public Alumno(string name, string l_name, string user, string password)
        {
            this.activo = true;
            this.nombre = name;
            this.apellido = l_name;
            this.usuario = user;
            this.contraseña = password;
        }

        ~Alumno() {

        }

        public bool añadirGrupo(int idGrupo)
        {
            if (BD.GRUPO_GLOBAL[idGrupo].Alumnos.Count() == BD.GRUPO_GLOBAL[idGrupo].cupos)
                return false;
            Grupos.Add(idGrupo);
            return true;
        }

        public bool retirarGrupo(int idGrupo)
        {
            if (Examenes.Count() > 0)
                return false;
            Grupos.Remove(idGrupo);
            return true;
        }

    }

    public class Examen
    {

    }
}
