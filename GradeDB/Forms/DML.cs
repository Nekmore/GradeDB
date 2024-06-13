using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GradeDB.Forms
{
    public partial class DML : Form
    {
        private string connectionString = "server=localhost;port=3306;user=root;password=0000;database=university_db;";

        public DML()
        {
            InitializeComponent();
            LoadStudentsAndMarks();
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtStudentID.Text);
                int subjectID = int.Parse(txtSubjectID.Text);
                int mark = int.Parse(txtMark.Text);
                int semesterID = int.Parse(txtSemesterID.Text);
                AddMark(studentID, subjectID, mark, semesterID);
                LoadStudentsAndMarks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите правильные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMark_Click(object sender, EventArgs e)
        {
            try
            {
                int markID = int.Parse(txtMarkID.Text);
                int mark = int.Parse(txtMark.Text);
                UpdateMark(markID, mark);
                LoadStudentsAndMarks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите правильные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            try
            {
                int markID = int.Parse(txtMarkID.Text);
                DeleteMark(markID);
                LoadStudentsAndMarks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите правильные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMark(int studentID, int subjectID, int mark, int semesterID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Marks (Student_idStudent, Subject_idSubject, Mark, Semester_idSemester) VALUES (@studentID, @subjectID, @mark, @semesterID)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@subjectID", subjectID);
                cmd.Parameters.AddWithValue("@mark", mark);
                cmd.Parameters.AddWithValue("@semesterID", semesterID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Оценка добавлена успешно!");
            }
        }

        private void UpdateMark(int markID, int mark)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Marks SET Mark = @mark WHERE idMarks = @markID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@markID", markID);
                cmd.Parameters.AddWithValue("@mark", mark);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Оценка обновлена успешно!");
            }
        }

        private void DeleteMark(int markID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Marks WHERE idMarks = @markID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@markID", markID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Оценка удалена успешно!");
            }
        }

        private void LoadStudentsAndMarks()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"
                    SELECT 
                        s.idStudent AS 'ID Студента',
                        s.recordBook AS '№ Зачётной книжки',
                        s.FIOstudenst AS 'ФИО студента',
                        g.NameGroup AS 'Группа',
                        sub.idSubject AS 'ID Предмета',
                        sub.NameSubject AS 'Предмет',
                        m.idMarks AS 'ID Оценки',
                        m.Mark AS 'Оценка',
                        sem.idSemester AS 'ID Семестра',
                        sem.NumSemester AS 'Семестр'
                    FROM 
                        Marks m
                        JOIN Student s ON m.Student_idStudent = s.idStudent
                        JOIN `Group` g ON s.Group_idGroup = g.idGroup
                        JOIN Subject sub ON m.Subject_idSubject = sub.idSubject
                        JOIN Semester sem ON m.Semester_idSemester = sem.idSemester";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentsAndMarks();
        }
    }
}
