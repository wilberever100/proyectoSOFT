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
    public partial class gestionUnidadesTematicas : Form
    {
        public gestionUnidadesTematicas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarNuevoCursoBT_Click(object sender, EventArgs e)
        {
            string nombre = this.nombreUT.Text;

            unidad_tematica UT = new unidad_tematica(nombre);
            BD.CURSO_GLOBAL[agregarEnCurso.SelectedIndex].unidadesTematicas.Add(UT);
            this.nombreUT.Text = string.Empty; //borra lo escrito
            MessageBox.Show("UT creadAA exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD.CURSO_GLOBAL[removerEnCurso.SelectedIndex].unidadesTematicas.RemoveAt(removerUT.SelectedIndex);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void agregarEnCurso_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                agregarEnCurso.Items.Add(nuevo);
            }
            agregarEnCurso.SelectedIndex = 0;
        }

        private void removerEnCurso_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                removerEnCurso.Items.Add(nuevo);
            }
            removerEnCurso.SelectedIndex = 0;
        }

        private void removerUT_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL[removerEnCurso.SelectedIndex].unidadesTematicas.Count(); i++)
            {
                string nuevo = BD.CURSO_GLOBAL[removerEnCurso.SelectedIndex].unidadesTematicas[i].nombre;
                removerUT.Items.Add(nuevo);
            }
            removerUT.SelectedIndex = 0;
        }
    }
}
