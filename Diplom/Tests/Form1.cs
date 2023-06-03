using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AuthForm auth = new AuthForm(user);
            auth.ShowDialog();
            this.Text = string.Format("InteractiveBook " + "{0} {1} ({2})", user.Name, user.SurName, user.UserRole);
            FillTable();
            if (user.UserRole == Role.студент)
                создатьТестToolStripMenuItem.Enabled = false;
        }

        private void FillTable()
        {
            dataGridView1.DataSource = null;
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("SELECT About,Result,DateTesting FROM resulttest inner join tests on resulttest.idTest=tests.idTests inner join users on resulttest.idUser = users.idUsers where idUsers={0}", user.ID), connect);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table.DefaultView;
           // dataGridView1.Columns["idUsers"].Visible = false;
        }

        private void создатьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTest createTest = new CreateTest(user);
            createTest.ShowDialog();
        }

        private void пройтиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTest selectTest = new SelectTest(user);
            selectTest.ShowDialog();
            FillTable();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = !dataGridView1.Visible;
            if (pdfViewer1.Visible == false)
            {
                label1.Visible = false;
            }
            label1.Visible = !label1.Visible;
            pdfViewer1.Visible= !pdfViewer1.Visible;
        }

        private void открытьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "pdf files(*.pdf)|*.pdf|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                openfile(dialog.FileName);
            }
        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdfViewer1.Document = pdfDocument;
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите выйти?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoPlayerForm VPF = new VideoPlayerForm();
            VPF.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
