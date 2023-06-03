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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tests
{
    public partial class CreateTest : Form
    {
        List<Questions> list = new List<Questions>();
        User user;
        public CreateTest(User _user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = _user;

            if (user.UserRole == Role.студент)
                button3.Enabled = false;
            ReadQuestions();
        }
        private void ReadQuestions()
        {
            checkedListBox1.Items.Clear();
            list.Clear();
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from questions", connect);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(
                    new Questions
                    {
                        CategoryObj = (CategoryQuest)int.Parse(table.Rows[i]["Type"].ToString()),
                        Index = int.Parse(table.Rows[i]["idQuestions"].ToString()),
                        Value1 = table.Rows[i]["Value1"].ToString(),
                        Value2 = table.Rows[i]["Value1"].ToString(),
                        //images = table.Rows[i]["images"].ToString()
                    });
            }
            list.OrderBy(x => x.CategoryObj);

            foreach (var item in list)
            {
                checkedListBox1.Items.Add(string.Format("{0}", item.Value1));
            }
            //({0}) item.CategoryObj,
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTests addQuestions = new AddTests();
            addQuestions.ShowDialog();

            ReadQuestions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= String.Empty)
            {
                try
                {
                    SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
                    SqlCommand command = new SqlCommand(string.Format("insert into tests(About,idUser) values('{0}',{1}); SELECT CAST(scope_identity() AS int)", textBox1.Text, user.ID), connect);
                    connect.Open();
                    var idTest = (int)command.ExecuteScalar();
                    connect.Close();

                    List<string> values = new List<string>();

                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        values.Add(string.Format("({0},{1})", list[checkedListBox1.CheckedIndices[i]].Index, idTest));
                    }

                    var result = string.Join(",", values);

                    command = new SqlCommand(string.Format("insert into testwithquestions(idQuestion,idTest) values {0}", result), connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Создание прошло успешно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("При создании возникла ошибка!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Назовите тест!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
