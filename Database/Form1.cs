using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private string querySaveFile = "SqlQuery.txt";

        private string sampleQuery = "SELECT * FROM Клиенты";

        public Form1()
        {
            InitializeComponent();

            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(querySaveFile, SqlQueryTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(querySaveFile))
                SqlQueryTextBox.Text = File.ReadAllText(querySaveFile);

            var sqlDataAdapter = new SqlDataAdapter();
            var sampleDataSet = new sampleDataSet();

            connectionString = ConfigurationManager.ConnectionStrings["sample"].ConnectionString;

            TableDataGridView.DataSource = sampleDataSet.Заказы;
        }

        private void SqlQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSet = SqlQuery(SqlQueryTextBox.Text, this.connectionString);
                TableDataGridView.DataSource = dataSet.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet SqlQuery(string sql, string connectionString)
        {
            var dataSet = new DataSet();
            using(var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                var adapter = new OleDbDataAdapter(sql, connection);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }
    }
}
