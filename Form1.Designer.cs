namespace NewTims
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridPanel1 = new DataGridPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(541, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(247, 275);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 60);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "StudentID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 98);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "StudentName";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 141);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Branch";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 186);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Mobile No";
            // 
            // button1
            // 
            button1.Location = new Point(78, 249);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(161, 249);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridPanel1
            // 
            dataGridPanel1.BackColor = Color.Transparent;
            dataGridPanel1.Location = new Point(306, 95);
            dataGridPanel1.Name = "dataGridPanel1";
            dataGridPanel1.Padding = new Padding(1);
            dataGridPanel1.Size = new Size(200, 100);
            dataGridPanel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 314);
            Controls.Add(dataGridPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private Button button2;
        private DataGridPanel dataGridPanel1;
    }
}