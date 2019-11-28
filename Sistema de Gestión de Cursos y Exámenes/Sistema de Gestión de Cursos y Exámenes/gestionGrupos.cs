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
    public partial class gestionGrupos : Form
    {
        public gestionGrupos()
        {
            InitializeComponent();
        }

        private void cursosDisponibles1_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                cursosDisponibles1.Items.Add(nuevo);
            }
            cursosDisponibles1.SelectedIndex = 0;

        }

        private void CrearGrupoBT_Click(object sender, EventArgs e)
        {
            int cupos = Int32.Parse(this.indicarCupos.Text);

            Grupo nuevo = new Grupo(cupos);
            BD.GRUPO_GLOBAL.Add(nuevo);
            this.indicarCupos.Text = string.Empty;
            MessageBox.Show("Grupo creado exitosamente");
        }

        private void CerrarGrupoBT_Click(object sender, EventArgs e)
        {
            BD.GRUPO_GLOBAL.RemoveAt(gruposDisponibles.SelectedIndex);
        }
    }
}
