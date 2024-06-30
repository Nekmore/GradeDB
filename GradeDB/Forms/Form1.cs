using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using MySql.Data.MySqlClient;

namespace GradeDB.Forms
{
    public partial class Form1 : Form
    {
        private WebBrowser webBrowserReport;

        public Form1()
        {
            InitializeComponent();
            InitializeWebBrowser();
        }

        private void InitializeWebBrowser()
        {
            webBrowserReport = new WebBrowser();
            webBrowserReport.Dock = DockStyle.Fill;
            this.Controls.Add(webBrowserReport);
        }

        private void btnGenerateXML_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost; user=root; password=0000; database=university_db;";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM student", con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "student");
                    con.Close();

                    // Создание XML-документа
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlElement root = xmlDoc.CreateElement("students");

                    foreach (DataRow row in ds.Tables["student"].Rows)
                    {
                        XmlElement student = xmlDoc.CreateElement("student");

                        XmlElement idStudent = xmlDoc.CreateElement("idStudent");
                        idStudent.InnerText = row["idStudent"].ToString();
                        student.AppendChild(idStudent);

                        XmlElement FIOstudenst = xmlDoc.CreateElement("FIOstudenst");
                        FIOstudenst.InnerText = row["FIOstudenst"].ToString();
                        student.AppendChild(FIOstudenst);

                        XmlElement DateBirth = xmlDoc.CreateElement("DateBirth");
                        DateBirth.InnerText = row["DateBirth"].ToString();
                        student.AppendChild(DateBirth);

                        XmlElement Group_idGroup = xmlDoc.CreateElement("Group_idGroup");
                        Group_idGroup.InnerText = row["Group_idGroup"].ToString();
                        student.AppendChild(Group_idGroup);

                        root.AppendChild(student);
                    }

                    xmlDoc.AppendChild(root);
                    string xmlFilePath = "report.xml";
                    xmlDoc.Save(xmlFilePath);

                    // Применение XSLT-шаблона
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load("transform.xslt");
                    string htmlFilePath = "report.html";
                    xslt.Transform(xmlFilePath, htmlFilePath);

                    // Открытие HTML-файла в WebBrowser
                    webBrowserReport.Navigate(Path.GetFullPath(htmlFilePath));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
