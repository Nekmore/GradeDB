using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeDB.Forms
{
    public partial class Parameter : Form
    {
        private string connectionString = "server=localhost;port=3306;user=root;password=0000;database=university_db;";
        public Parameter()
        {
            InitializeComponent();
        }
        private void btnGetPlan_Click(object sender, EventArgs e)
        {
            int groupID = int.Parse(txtGroupID.Text);
            GetSessionPlanByGroup(groupID);
        }

        private void GetSessionPlanByGroup(int groupID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT s.FIOstudenst, m.Mark, sb.NameSubject, sem.NumSemester
                                 FROM Marks m
                                 JOIN Student s ON m.Student_idStudent = s.idStudent
                                 JOIN Subject sb ON m.Subject_idSubject = sb.idSubject
                                 JOIN Semester sem ON m.Semester_idSemester = sem.idSemester
                                 WHERE s.Group_idGroup = @groupID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@groupID", groupID);
                MySqlDataReader reader = cmd.ExecuteReader();
                listBoxPlan.Items.Clear();
                while (reader.Read())
                {
                    string planData = $"{reader["FIOstudenst"]} - {reader["NameSubject"]}: {reader["Mark"]} ({reader["NumSemester"]})";
                    listBoxPlan.Items.Add(planData);
                }
            }
        }
    }
}
