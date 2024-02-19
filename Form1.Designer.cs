namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup15 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup16 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem22 = new ListViewItem(new string[] { "Nombre" }, -1, Color.Empty, Color.MistyRose, null);
            ListViewItem listViewItem23 = new ListViewItem(new string[] { "País" }, -1, Color.Empty, Color.PeachPuff, null);
            ListViewItem listViewItem24 = new ListViewItem(new string[] { "Genero M" }, -1, Color.Empty, Color.MistyRose, null);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            Ingresar = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            pictureBox2 = new PictureBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBoxFiltrado = new ListBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Ingresar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(371, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 52);
            label1.Name = "label1";
            label1.Size = new Size(129, 34);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 128, 255);
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 113);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 2;
            label2.Text = "País";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Location = new Point(125, 206);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 3;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Pink;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pop", "Rock", "Country", "Rap", "Musica Clasica" });
            comboBox1.Location = new Point(151, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Pink;
            textBox1.Location = new Point(151, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 37);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Pink;
            textBox2.Location = new Point(151, 105);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 37);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 255);
            label3.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 172);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 7;
            label3.Text = "Genero Musical";
            label3.Click += label3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Ingresar
            // 
            Ingresar.Controls.Add(tabPage1);
            Ingresar.Controls.Add(tabPage2);
            Ingresar.Controls.Add(tabPage3);
            Ingresar.Location = new Point(2, 2);
            Ingresar.Name = "Ingresar";
            Ingresar.SelectedIndex = 0;
            Ingresar.Size = new Size(797, 415);
            Ingresar.TabIndex = 8;
            Ingresar.Tag = "Ingresar";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 192, 255);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingresar";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 192, 255);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 192, 255);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(listBoxFiltrado);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 382);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Filtrar";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(107, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LavenderBlush;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewGroup15.Header = "ListViewGroup";
            listViewGroup15.Name = "listViewGroup1";
            listViewGroup16.Header = "ListViewGroup";
            listViewGroup16.Name = "listViewGroup2";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup15, listViewGroup16 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem22, listViewItem23, listViewItem24 });
            listView1.Location = new Point(442, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(225, 92);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.Location = new Point(280, 265);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Anterior";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Location = new Point(426, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Siguiente";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(46, 37);
            button4.Name = "button4";
            button4.Size = new Size(55, 29);
            button4.TabIndex = 4;
            button4.Text = "Ver";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBoxFiltrado
            // 
            listBoxFiltrado.BackColor = Color.FromArgb(247, 167, 222);
            listBoxFiltrado.BorderStyle = BorderStyle.FixedSingle;
            listBoxFiltrado.FormattingEnabled = true;
            listBoxFiltrado.Location = new Point(386, 69);
            listBoxFiltrado.Name = "listBoxFiltrado";
            listBoxFiltrado.Size = new Size(245, 182);
            listBoxFiltrado.TabIndex = 0;
            listBoxFiltrado.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(242, 68, 232);
            label4.Location = new Point(106, 110);
            label4.Name = "label4";
            label4.Size = new Size(145, 30);
            label4.TabIndex = 1;
            label4.Text = "Genero Musical";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Pop", "Rock", "Country", "Rap", "Musica Clasica" });
            comboBox2.Location = new Point(106, 160);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 28);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(130, 218);
            button5.Name = "button5";
            button5.Size = new Size(104, 33);
            button5.TabIndex = 3;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(Ingresar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Ingresar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private TabControl Ingresar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private TabPage tabPage3;
        private ListView listView1;
        private Button button3;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button4;
        private ListBox listBoxFiltrado;
        private Label label4;
        private Button button5;
        private ComboBox comboBox2;
    }
}