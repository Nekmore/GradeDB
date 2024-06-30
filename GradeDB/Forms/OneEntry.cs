using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class OneEntry : Form
    {
        DataSet ds;
        BindingSource bs = new BindingSource();

        public OneEntry()
        {
            InitializeComponent();

            // Подключение к базе данных
            string connectionString = "server=localhost; user=root; password=0000; database=university_db;";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();

                // Создание адаптера и команды для заполнения данных
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM student", con);
                ds = new DataSet();
                adapter.Fill(ds, "student");

                // Настройка BingingSource на источник данных
                bs.DataSource = ds.Tables["student"];

                // Отображение данных в текстовые поля для выбранного значения
                tB_group.DataBindings.Add("Text", bs, "Group_idGroup");
                tB_name.DataBindings.Add("Text", bs, "FIOstudenst");
                tB_date.DataBindings.Add("Text", bs, "DateBirth");

                // Настройка BindingNavigator на источник данных
                bindingNavigator1.BindingSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
