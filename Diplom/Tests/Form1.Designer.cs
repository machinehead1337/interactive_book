namespace Tests
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВидеоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пройтиТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.openBookDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКнигуToolStripMenuItem,
            this.открытьВидеоToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.файлToolStripMenuItem.Text = "Книги";
            // 
            // открытьКнигуToolStripMenuItem
            // 
            this.открытьКнигуToolStripMenuItem.Name = "открытьКнигуToolStripMenuItem";
            this.открытьКнигуToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.открытьКнигуToolStripMenuItem.Text = "Открыть книгу";
            this.открытьКнигуToolStripMenuItem.Click += new System.EventHandler(this.открытьКнигуToolStripMenuItem_Click);
            // 
            // открытьВидеоToolStripMenuItem
            // 
            this.открытьВидеоToolStripMenuItem.Name = "открытьВидеоToolStripMenuItem";
            this.открытьВидеоToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.открытьВидеоToolStripMenuItem.Text = "Открыть видео";
            this.открытьВидеоToolStripMenuItem.Click += new System.EventHandler(this.открытьВидеоToolStripMenuItem_Click);
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пройтиТестToolStripMenuItem,
            this.результатыToolStripMenuItem,
            this.toolStripSeparator1,
            this.создатьТестToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // пройтиТестToolStripMenuItem
            // 
            this.пройтиТестToolStripMenuItem.Name = "пройтиТестToolStripMenuItem";
            this.пройтиТестToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.пройтиТестToolStripMenuItem.Text = "Пройти тест";
            this.пройтиТестToolStripMenuItem.Click += new System.EventHandler(this.пройтиТестToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // создатьТестToolStripMenuItem
            // 
            this.создатьТестToolStripMenuItem.Name = "создатьТестToolStripMenuItem";
            this.создатьТестToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.создатьТестToolStripMenuItem.Text = "Создать тест";
            this.создатьТестToolStripMenuItem.Click += new System.EventHandler(this.создатьТестToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(594, 761);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 24);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.ShowBookmarks = false;
            this.pdfViewer1.ShowToolbar = false;
            this.pdfViewer1.Size = new System.Drawing.Size(594, 761);
            this.pdfViewer1.TabIndex = 1;
            // 
            // openBookDialog
            // 
            this.openBookDialog.FileName = "openFileDialog";
            this.openBookDialog.Filter = "PDF|*.pdf";
            this.openBookDialog.ShowHelp = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "Чтобы открыть книгу или видео, нажмите на кнопку \"Книги\",\r\nдалее выберите нужное " +
    "вам действие и\r\nоткройте нужную вам книгу на компьютере\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteractiveBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пройтиТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem создатьТестToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВидеоToolStripMenuItem;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.OpenFileDialog openBookDialog;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

