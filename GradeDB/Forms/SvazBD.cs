using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GradeDB.Forms
{
    public partial class SvazBD : Form
    {
        private string connectionString = "server=localhost;user=root;password=0000;database=university_db;";

        public SvazBD()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Marks", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Marks");

                foreach (DataRow dr in ds.Tables["Marks"].Rows)
                {
                    textBox1.Text += dr["idMarks"] + " " + dr["Mark"] + " " + dr["Student_idStudent"] + Environment.NewLine;
                }
            }
        }
    }
}
