using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class VideoPlayerForm : Form
    {
        public VideoPlayerForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void VideoPlayerForm_Load(object sender, EventArgs e)
        {
            if (openVideoDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string file = openVideoDialog.FileName;

            axWindowsMediaPlayer1.URL = file;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void открытьВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openVideoDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string file = openVideoDialog.FileName;

            axWindowsMediaPlayer1.URL = file;
        }
    }
}
