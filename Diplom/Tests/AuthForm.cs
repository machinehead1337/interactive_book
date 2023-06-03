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
    public partial class AuthForm : Form
    {
        User user;
        public AuthForm(User _user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = _user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format("select Name,SurName,Login,Role,idUsers from Users where Login = '{0}' and Password = '{1}'",textBox1.Text,textBox2.Text), connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count!=0)
                {
                    user.ID = int.Parse(table.Rows[0]["idUsers"].ToString());
                    user.Name = table.Rows[0]["Name"].ToString();
                    user.SurName = table.Rows[0]["SurName"].ToString();
                    user.Login = table.Rows[0]["Login"].ToString();
                    user.UserRole = (Role)int.Parse(table.Rows[0]["Role"].ToString());

                    Close();
                }
                else
                    MessageBox.Show("Логин или пароль неверны!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Поля логин и пароль не могут быть пустыми!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            pictureBox_unvisible.Visible = false;
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox_visible_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox_visible.Visible = false;
            pictureBox_unvisible.Visible = true;
        }

        private void pictureBox_unvisible_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox_visible.Visible = true;
            pictureBox_unvisible.Visible = false;
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
