using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class SyncDatabase : Form
    {
        public SyncDatabase()
        {
            InitializeComponent();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            // Подключение к базе данных
            string connectionString = "server=localhost; user=root; password=0000; database=university_db;";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            // Создание адаптера и команд
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Student", con);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            // Создание DataSet и заполнение таблицы Student
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Student");

            // Добавление новой строки в таблицу Student
            DataRow newRow = ds.Tables["Student"].NewRow();
            newRow["recordBook"] = "RB2023001";
            newRow["FIOstudenst"] = "Иванов Иван Иванович";
            newRow["Group_idGroup"] = 1;
            newRow["DateBirth"] = new DateTime(2002, 5, 14);
            ds.Tables["Student"].Rows.Add(newRow);

            // Синхронизация изменений с базой данных
            adapter.Update(ds.Tables["Student"]);

            // Закрытие подключения
            con.Close();

            MessageBox.Show("Синхронизация завершена успешно!");
        }
    }
}
