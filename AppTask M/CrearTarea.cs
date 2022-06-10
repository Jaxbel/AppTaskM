using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppTask_M
{
    public partial class CrearTarea : Form
    {
        public CrearTarea()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-71KERVI\SERVIDOR;Initial Catalog=APPTASK;Integrated Security=True");


        
        private void button2_Click(object sender, EventArgs e)
        {

            
            string titulo = txtTitulo.Text.ToString();
            string fechaIn = dateTimePicker2.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string finali = dateTimePicker3.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string import = cmbImport.Text.ToString();
            string etiqueta = txtEtiq.Text.ToString();

            conexion.Open();

            //
            try
            {
                SqlCommand insert = new SqlCommand("insert into TAREAS(TITULO, FECHAIN, FECHAFIN, IMPORTANCIA, ETIQUETA)" + "values(@TITULO, @FECHAIN, @FECHAFIN, @IMPORTANCIA, @ETIQUETA)", conexion);

                insert.Parameters.AddWithValue("TITULO", titulo);
                insert.Parameters.AddWithValue("FECHAIN", fechaIn);
                insert.Parameters.AddWithValue("FECHAFIN", finali);
                insert.Parameters.AddWithValue("IMPORTANCIA", import);
                insert.Parameters.AddWithValue("ETIQUETA", etiqueta);
                insert.ExecuteNonQuery();


                

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex}");
            }

            MessageBox.Show("Tarea Creada");
            conexion.Close();
        }

        public void llenar_grid(DataGridView grid)
        {
            SqlCommand da = new SqlCommand("Select *from TAREAS", conexion);
            SqlDataAdapter dt = new SqlDataAdapter(da);
            DataTable dx = new DataTable();

            dt.Fill(dx);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
            txtEtiq.Text = "";
            cmbImport.Text = null;
        }

        private void txtEtiq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbImport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfechaIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
