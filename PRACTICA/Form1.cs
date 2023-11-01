using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PRACTICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
     

            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(consulta,Conexion.conectar());

            SqlDataAdapter dat = new SqlDataAdapter(cmd);

            dat.Fill(dt);
            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string insertar = "INSERT INTO Clientes (Nombre, Distrito, Monto, Fecha)VALUES(@Nombre,@Distrito,@Monto,@Fecha)";

            SqlCommand cmd = new SqlCommand(insertar, Conexion.conectar());

            cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
            cmd.Parameters.AddWithValue("@Distrito", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Monto", textBox2.Text);
            cmd.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_grid();

        }
        
    }
}
