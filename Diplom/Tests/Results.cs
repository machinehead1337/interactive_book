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
    public partial class FormPic : Form
    {
        User user = new User();
        public Image SelectedImage { get; private set; }
        public FormPic()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            ////AuthForm auth = new AuthForm(user);
            ////auth.ShowDialog();
            ////toolStripStatusLabel1.Text = string.Format("{0} {1} ({2})", user.Name, user.SurName, user.UserRole);
            //FillTable();
        }
        private void FillTable()
        {
        //    dataGridView1.DataSource = null;
        //    SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
        //    SqlDataAdapter adapter = new SqlDataAdapter(string.Format("SELECT About,Result,DateTesting FROM resulttest inner join tests on resulttest.idTest=tests.idTests inner join users on resulttest.idUser = users.idUsers where idUsers={0}", user.ID), connect);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    dataGridView1.DataSource = table.DefaultView;
        //    // dataGridView1.Columns["idUsers"].Visible = false;
        }

        private void LoadPic()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.bmp, *.gif, *.png) | *.jpg; *.jpeg; *.jpe; *.bmp; *.gif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить изображение: " + ex.Message);
                }
            }
        }

        private void Picture_Load(object sender, EventArgs e)
        {
            LoadPic();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void открытьНовуюКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPic();
        }
    }
}
