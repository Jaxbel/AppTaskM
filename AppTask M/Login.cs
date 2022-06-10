using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTask_M
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
                      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "Fabo" && contraseña.Text == "contra")
            {
                
                
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
                

            }
            else
            {
                MessageBox.Show("El usuario ingresado no es correcto");
            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Form2.StartPosition = FormStartPosition.Manual;
            Form2.Location = new Point(100, 100);
            this.Hide();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
