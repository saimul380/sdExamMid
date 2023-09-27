using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace sdExamMid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Data Source=LAPTOP-Q7KTNQDN\\SQLEXPRESS;Initial Catalog=examDatabase;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                var insertQuery = "insert into student values(@matricId, @name,@department)";

                SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@matricId", textBox_MatricID.Text);
                sqlCommand.Parameters.AddWithValue("@name", textBox_StudentName.Text);
                sqlCommand.Parameters.AddWithValue("@department", textBox_department.Text);


                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Data Inserted Succesfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }

            
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Data Source=LAPTOP-Q7KTNQDN\\SQLEXPRESS;Initial Catalog=examDatabase;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string readCommand = "";

                if (textBox_MatricID.Text.ToString() == "")
                {
                    readCommand = "select * from student";
                }
                else
                {
                    readCommand = "select * from student where matricId=@matricId";
                }

                SqlCommand sqlCommand = new SqlCommand(readCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@matricId", textBox_MatricID.Text);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Show!");
            }
        }
    }
}
