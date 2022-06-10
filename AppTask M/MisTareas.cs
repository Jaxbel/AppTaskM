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
    public partial class MisTareas : Form
    {
        public MisTareas()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-71KERVI\SERVIDOR;Initial Catalog=APPTASK;Integrated Security=True");
        private void MisTareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aPPTASKDataSet.TAREAS' Puede moverla o quitarla según sea necesario.
            this.tAREASTableAdapter.Fill(this.aPPTASKDataSet.TAREAS);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
