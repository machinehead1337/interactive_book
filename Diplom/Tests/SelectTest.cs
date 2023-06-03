using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class SelectTest : Form
    {
        User user;
        List<Test> testsList = new List<Test>();
        public SelectTest(User _user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            user = _user;
            GetTests();
            if (user.UserRole == Role.студент)
                button3.Enabled = false;
        }
        private void GetTests()
        {
            testsList.Clear();
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT idTests,About,Name,SurName FROM tests, users where users.idUsers = tests.idUser", connect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                testsList.Add(new Test
                {
                    About = table.Rows[i]["About"].ToString(),
                    Name = table.Rows[i]["Name"].ToString(),
                    SurName = table.Rows[i]["SurName"].ToString(),
                    Index = int.Parse(table.Rows[i]["idTests"].ToString())
                });
            }
            AddTestsInListView();
        }

        private void AddTestsInListView()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < testsList.Count; i++)
            {
                listBox1.Items.Add(string.Format("{0} (Автор: {1} {2})",testsList[i].About,testsList[i].Name,testsList[i].SurName));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateTest createTest = new CreateTest(user);
            createTest.ShowDialog();

            GetTests();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestingForm formTest = new TestingForm(testsList[listBox1.SelectedIndex],user);
            formTest.ShowDialog();
            Close();
        }

        private void deletedRow()
        {
            int index = listBox1.SelectedIndex;
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ////DELETE FROM имя_таблицы WHERE имя_столбца = значение;
            ////listBox1.Items.Remove(listBox1.SelectedIndex);
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //listBox1.SelectedIndex = ("DELETE FROM")
        }
    }
}
