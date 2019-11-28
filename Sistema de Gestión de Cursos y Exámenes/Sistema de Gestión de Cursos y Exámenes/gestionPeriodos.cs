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
    public partial class gestionPeriodos : Form
    {
        public gestionPeriodos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void abrirPeriodoBT_Click(object sender, EventArgs e)
        {
            string nombre = this.nuevoPeriodo.Text;



            Periodo_Academico foo = new Periodo_Academico(nombre,calendarPeriodo.SelectionStart,calendarPeriodo.SelectionEnd);
            BD.PERIODO_ACADEMICO_GLOBAL.Add(foo);
            this.nuevoPeriodo.Text = string.Empty; //borra lo escrito
            MessageBox.Show("Abierto exitosamente");
        }

        private void periodoEliminado_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.PERIODO_ACADEMICO_GLOBAL.Count; i++)
            {
                string nuevo = BD.PERIODO_ACADEMICO_GLOBAL[i].m_periodo;
                periodoEliminado.Items.Add(nuevo);
            }
            periodoEliminado.SelectedIndex = 0;

        }

        private void periodoEliminado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BD.PERIODO_ACADEMICO_GLOBAL.RemoveAt(periodoEliminado.SelectedIndex);
        
        }
    }
    public class Periodo_Academico
    {
        public string m_periodo;
        DateTime inicio;
        DateTime fin;
        public Periodo_Academico(string nombre,DateTime ini,DateTime fn)
        {
            nombre = m_periodo;
            inicio = ini;
            fin = fn;
        }
    }
}
