using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

public class Database
{
    private MySqlConnection connection;

    public Database()
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
        connection = new MySqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(string query)
    {
        MySqlCommand cmd = new MySqlCommand(query, connection);
        DataTable dt = new DataTable();
        try
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return dt;
    }

    public bool ExecuteNonQuery(string query)
    {
        MySqlCommand cmd = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
        finally
        {
            connection.Close();
        }
    }
}