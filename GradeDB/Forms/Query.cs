using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GradeDB.Forms
{
    public partial class Query : Form
    {
        private string connectionString = "server=localhost;port=3306;user=root;password=0000;database=university_db;";

        public Query()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string fio = txtFIO.Text;
            DateTime dob = dateTimePickerDOB.Value;
            int groupID = int.Parse(txtGroupID.Text);
            string recordBook = txtRecordBook.Text;
            AddStudent(recordBook, fio, dob, groupID);
        }

        private void TestConnection()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Подключение успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
        }

        private void GetStudents()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Student", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                listBoxStudents.Items.Clear();
                while (reader.Read())
                {
                    string studentData = reader["idStudent"] + " " + reader["recordBook"] + " " + reader["FIOstudenst"] + " " + reader["DateBirth"];
                    listBoxStudents.Items.Add(studentData);
                }
            }
        }

        private void AddStudent(string recordBook, string fio, DateTime dob, int groupID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Student (recordBook, FIOstudenst, DateBirth, Group_idGroup) VALUES (@recordBook, @fio, @dob, @groupID)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@recordBook", recordBook);
                cmd.Parameters.AddWithValue("@fio", fio);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@groupID", groupID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Студент успешно добавлен!");
            }
        }


    }
}
