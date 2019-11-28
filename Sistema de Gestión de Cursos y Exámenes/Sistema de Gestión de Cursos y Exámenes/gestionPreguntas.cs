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
    public partial class gestionPreguntas : Form
    {
        Pregunta_COMPLETAR p = new Pregunta_COMPLETAR();
        Pregunta_OPCION q = new Pregunta_OPCION();
        public gestionPreguntas()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void GENERALUPDATE_Click(object sender, EventArgs e)
        {
            if (DESARROLLO.Checked == true) {
                p.curso.nombre = CURSO.Text;
                p.tipo = "Pregunta de Desarrollo";
                p.pregunta = PREGUNTA.Text;
                p.lineas = REGLONES.Value;
            }
            if (CONCRETA.Checked == true) {
                p.curso.nombre = CURSO.Text;
                p.tipo = "Pregunta de Respuesta Concreta";
                p.pregunta = PREGUNTA.Text;
                p.respuestas.Add(RPTAQ.Text);
            }
            if (CHOICE.Checked == true) {
                q.tipo = "Alternativa Multiple";
                q.curso.nombre = CURSO.Text;
                q.pregunta = PREGUNTA.Text;
            }
            if (TRUEFALSE.Checked == true) {
                q.tipo = "Verdadero / Falso";
                q.curso.nombre = CURSO.Text;
                q.pregunta = PREGUNTA.Text;
            }
            if (PAIR.Checked == true) {
                q.tipo = "Emparejamiento";
                q.curso.nombre = CURSO.Text;
                q.pregunta = PREGUNTA.Text;
            }
            if (DESARROLLO.Checked == true || CONCRETA.Checked == true) {
                
            }
        }

        private void gestionPreguntas_Load(object sender, EventArgs e)
        {

        }

        private void UPLOADW_Click(object sender, EventArgs e)
        {
            q.alternativasFalsas.Add(rptaCHOICE.Text);
        }

        private void UPLOADR_Click(object sender, EventArgs e)
        {
            q.alternativaVerdadera.Add( CORRECT.Text);
        }

        private void UPLOADT_Click(object sender, EventArgs e)
        {
            q.alternativaVerdadera.Add(VERDADERO.Text) ;
        }

        private void UPLOADF_Click(object sender, EventArgs e)
        {
            q.alternativasFalsas.Add(FALSO.Text);
        }

        private void UPLOAD2_Click(object sender, EventArgs e)
        {
            q.alternativasFalsas.Add(unoPAIR.Text);
            q.alternativaVerdadera.Add(dosPAIR.Text);
        }
    }

    public class Pregunta_COMPLETAR{
        public string tipo;
        public string pregunta;
        public decimal lineas;
        public List<string> respuestas;
        public Curso curso;
    };

    public class Pregunta_OPCION {
        public string tipo;
        public Curso curso;
        public string pregunta;
        public List<string> alternativasFalsas;
        public List<string> alternativaVerdadera;
    };
}
