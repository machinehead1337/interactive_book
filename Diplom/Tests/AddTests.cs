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
using System.IO;

namespace Tests
{
    public partial class AddTests : Form
    {
        public AddTests()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Задание с открытым ответом!
            //Задание с выбором ответа!
            //Задание на упорядочивание последовательности!
            //Задание на устоновление соответствия!
            switch(comboBox1.SelectedIndex)
            {
                case 0: panelType1.BringToFront(); break;
                case 1: panelType2.BringToFront(); break;
                case 2: panelType3.BringToFront(); break;
                case 3: panelType4.BringToFront(); break;
                default: break;
            }
        }

        int index = 1;
        private void AddInListView()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { index.ToString(), textBox4.Text, DateTime.Now.ToLongTimeString(), labelPath.Text });
            listView1.Items.Add(listViewItem1);
            index++;
        }

        private bool WriteDataInDB(string commandText)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.connectionString);
            SqlCommand command = new SqlCommand(commandText, connect);
            try
            {
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch {
                return false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Задание на установление соответствия!
            var result = WriteDataInDB(string.Format("insert into questions(Type,Value1) values({0},'{1}')",comboBox1.SelectedIndex,textBox5.Text));
           
            if(result)
                AddInListView();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Задание на упорядочивание последовательности!
            var result = WriteDataInDB(string.Format("insert into questions(Type,Value1) values({0},'{1}')", comboBox1.SelectedIndex, textBox6.Text));

            if (result)
                AddInListView(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Задание с открытым ответом!
            var result = WriteDataInDB(string.Format("insert into questions(Type,Value1,Value2) values({0},'{1}','{2}')", comboBox1.SelectedIndex, textBox1.Text,textBox2.Text));

            if (result)
                AddInListView(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Задание с выбором ответа!
            var result = WriteDataInDB(string.Format("insert into questions(Type,Value1,Value2,Image) values({0},'{1}','{2}','{3}','{4}')", comboBox1.SelectedIndex, textBox4.Text, textBox3.Text, labelPath.Text, checkBox1.Checked));

            if (result)
                AddInListView(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ButWithoutPicture_Click(object sender, EventArgs e)
        {
            int checkBoxValue = checkBox1.Checked ? 1 : 0;
            var result = WriteDataInDB(string.Format("insert into questions(Type,Value1,Value2,image1) values({0},'{1}','{2}','{3}')", comboBox1.SelectedIndex, textBox4.Text, textBox3.Text, checkBoxValue));

            if (result)
                AddInListView();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                labelPath.Visible = true;
                AddPicture.Visible = true;
                ButWithPicture.Visible = true;
                ButWithoutPicture.Visible = false;
            }
            else if(checkBox1.Checked == false)
            {
                labelPath.Visible = false;
                AddPicture.Visible = false;
                ButWithPicture.Visible = false;
                ButWithoutPicture.Visible = true;
            }
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            //ButWithPicture.Visible = false;
            //ButWithoutPicture.Visible = true;

            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openImageDialog.FileName;
                labelPath.Text = selectedFileName;
            }
        }

        private void ButWithPicture_Click(object sender, EventArgs e)
        {
            //Задание с выбором ответа!
            int checkBoxValue = checkBox1.Checked ? 1 : 0;
            var result = WriteDataInDB(string.Format("insert into questions(Type,Value1,Value2,Image,image1) values({0},'{1}','{2}','{3}','{4}')", comboBox1.SelectedIndex, textBox4.Text, textBox3.Text, labelPath.Text, checkBoxValue));;

            if (result)
                AddInListView();
        }
    }
}
