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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = "director";
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                if (tipo == "profesor")
                {
                    menuProfesor mP = new menuProfesor();
                    mP.Show();
                }

                else if (tipo == "alumno")
                {
                    menuAlumno mA = new menuAlumno();
                    mA.Show();
                }

                else if (tipo == "director")
                {
                    menuDirector mD = new menuDirector();
                    mD.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
