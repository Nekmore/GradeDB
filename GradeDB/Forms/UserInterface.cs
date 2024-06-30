using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class UserInterface : Form
    {
        DataSet ds;
        BindingSource bs = new BindingSource();

        public UserInterface()
        {
            InitializeComponent();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            // Подключение к базе данных
            string connectionString = "server=localhost; user=root; password=0000; database=university_db;";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            // Создание адаптера и команд
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Student", con);
            ds = new DataSet();
            adapter.Fill(ds, "Student");
            con.Close();

            // Настройка BingingSource на источник данных
            bs.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;

            // Установка привязки к источнику данных
            dataGridView1.DataSource = bs;

            // Последовательное создание столбцов элемента управления
            DataGridViewTextBoxColumn recordBookColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "recordBook",
                HeaderText = "Зачетная книжка"
            };
            dataGridView1.Columns.Add(recordBookColumn);

            DataGridViewTextBoxColumn fioColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FIOstudenst",
                HeaderText = "ФИО студента"
            };
            dataGridView1.Columns.Add(fioColumn);

            DataGridViewTextBoxColumn groupColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Group_idGroup",
                HeaderText = "Группа"
            };
            dataGridView1.Columns.Add(groupColumn);

            DataGridViewTextBoxColumn birthDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateBirth",
                HeaderText = "Дата рождения"
            };
            dataGridView1.Columns.Add(birthDateColumn);
        }
    }
}
