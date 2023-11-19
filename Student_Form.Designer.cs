namespace NewTims
{
    partial class Student_Form
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("#");
            ListViewItem listViewItem2 = new ListViewItem("Date");
            ListViewItem listViewItem3 = new ListViewItem("Sbj");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Form));
            BizEntity_radioButton = new RadioButton();
            Surname_radioButton = new RadioButton();
            Surname_textBox = new TextBox();
            GivenName_label = new Label();
            GivenName_textBox = new TextBox();
            Sex_label = new Label();
            Male_radioButton = new RadioButton();
            Female_radioButton = new RadioButton();
            StudentID_label = new Label();
            StudentID_textBox = new TextBox();
            Other_label = new Label();
            StuID_label = new Label();
            OtherID_textBox = new TextBox();
            BizEntity_textBox = new TextBox();
            TelEmail_textBox = new TextBox();
            ListStu_button = new Button();
            FindStuByTelEmail_button = new Button();
            CopyStudent_button = new Button();
            ListMember_button = new Button();
            TelEmail_button = new Button();
            Address_label = new Label();
            Address_textBox = new TextBox();
            BillingAddress_textBox = new TextBox();
            BilingAddress_label = new Label();
            MemberOfLabel = new Label();
            PrintBillingAddress_pictureBox = new PictureBox();
            Address_pictureBox = new PictureBox();
            Test_label = new Label();
            MemberOf_textBox = new TextBox();
            Color_button = new Button();
            Notes_textBox = new TextBox();
            AlreadyConf_label = new Label();
            Email_radioButton = new RadioButton();
            Mail_radioButton = new RadioButton();
            Any_radioButton = new RadioButton();
            Fax_radioButton = new RadioButton();
            Notes_label = new Label();
            Courses_listView = new ListView();
            Number = new ColumnHeader();
            Date = new ColumnHeader();
            Sbj = new ColumnHeader();
            Courses_label = new Label();
            Payment_label = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            PaymentRmks_textBox = new TextBox();
            Payment_dataGridView = new DataGridView();
            SfDataGridBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PrintBillingAddress_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Address_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Payment_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SfDataGridBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BizEntity_radioButton
            // 
            BizEntity_radioButton.AutoSize = true;
            BizEntity_radioButton.Location = new Point(10, 8);
            BizEntity_radioButton.Name = "BizEntity_radioButton";
            BizEntity_radioButton.Size = new Size(73, 19);
            BizEntity_radioButton.TabIndex = 0;
            BizEntity_radioButton.TabStop = true;
            BizEntity_radioButton.Text = "Biz Entity";
            BizEntity_radioButton.UseVisualStyleBackColor = true;
            // 
            // Surname_radioButton
            // 
            Surname_radioButton.AutoSize = true;
            Surname_radioButton.Location = new Point(10, 26);
            Surname_radioButton.Name = "Surname_radioButton";
            Surname_radioButton.Size = new Size(72, 19);
            Surname_radioButton.TabIndex = 1;
            Surname_radioButton.TabStop = true;
            Surname_radioButton.Text = "Surname";
            Surname_radioButton.UseVisualStyleBackColor = true;
            // 
            // Surname_textBox
            // 
            Surname_textBox.Location = new Point(82, 15);
            Surname_textBox.Name = "Surname_textBox";
            Surname_textBox.Size = new Size(99, 23);
            Surname_textBox.TabIndex = 2;
            // 
            // GivenName_label
            // 
            GivenName_label.AutoSize = true;
            GivenName_label.Location = new Point(183, 19);
            GivenName_label.Name = "GivenName_label";
            GivenName_label.Size = new Size(72, 15);
            GivenName_label.TabIndex = 3;
            GivenName_label.Text = "Given Name";
            // 
            // GivenName_textBox
            // 
            GivenName_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GivenName_textBox.Location = new Point(259, 15);
            GivenName_textBox.Name = "GivenName_textBox";
            GivenName_textBox.Size = new Size(120, 23);
            GivenName_textBox.TabIndex = 4;
            // 
            // Sex_label
            // 
            Sex_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Sex_label.AutoSize = true;
            Sex_label.Location = new Point(380, 19);
            Sex_label.Name = "Sex_label";
            Sex_label.Size = new Size(25, 15);
            Sex_label.TabIndex = 5;
            Sex_label.Text = "Sex";
            // 
            // Male_radioButton
            // 
            Male_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Male_radioButton.AutoSize = true;
            Male_radioButton.Location = new Point(407, 17);
            Male_radioButton.Name = "Male_radioButton";
            Male_radioButton.Size = new Size(36, 19);
            Male_radioButton.TabIndex = 6;
            Male_radioButton.TabStop = true;
            Male_radioButton.Text = "M";
            Male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Female_radioButton
            // 
            Female_radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Female_radioButton.AutoSize = true;
            Female_radioButton.Location = new Point(443, 17);
            Female_radioButton.Name = "Female_radioButton";
            Female_radioButton.Size = new Size(31, 19);
            Female_radioButton.TabIndex = 7;
            Female_radioButton.TabStop = true;
            Female_radioButton.Text = "F";
            Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // StudentID_label
            // 
            StudentID_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentID_label.AutoSize = true;
            StudentID_label.Location = new Point(479, 19);
            StudentID_label.Name = "StudentID_label";
            StudentID_label.Size = new Size(62, 15);
            StudentID_label.TabIndex = 8;
            StudentID_label.Text = "Student ID";
            // 
            // StudentID_textBox
            // 
            StudentID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentID_textBox.Location = new Point(544, 15);
            StudentID_textBox.Name = "StudentID_textBox";
            StudentID_textBox.Size = new Size(42, 23);
            StudentID_textBox.TabIndex = 9;
            StudentID_textBox.Text = "000171";
            // 
            // Other_label
            // 
            Other_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Other_label.AutoSize = true;
            Other_label.Location = new Point(592, 12);
            Other_label.Name = "Other_label";
            Other_label.Size = new Size(37, 15);
            Other_label.TabIndex = 10;
            Other_label.Text = "Other";
            // 
            // StuID_label
            // 
            StuID_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StuID_label.AutoSize = true;
            StuID_label.Location = new Point(593, 26);
            StuID_label.Name = "StuID_label";
            StuID_label.Size = new Size(62, 15);
            StuID_label.TabIndex = 11;
            StuID_label.Text = "Student ID";
            // 
            // OtherID_textBox
            // 
            OtherID_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OtherID_textBox.Location = new Point(657, 15);
            OtherID_textBox.Name = "OtherID_textBox";
            OtherID_textBox.Size = new Size(133, 23);
            OtherID_textBox.TabIndex = 12;
            // 
            // BizEntity_textBox
            // 
            BizEntity_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BizEntity_textBox.Location = new Point(82, 15);
            BizEntity_textBox.Name = "BizEntity_textBox";
            BizEntity_textBox.Size = new Size(393, 23);
            BizEntity_textBox.TabIndex = 13;
            // 
            // TelEmail_textBox
            // 
            TelEmail_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TelEmail_textBox.Location = new Point(82, 47);
            TelEmail_textBox.Name = "TelEmail_textBox";
            TelEmail_textBox.Size = new Size(585, 23);
            TelEmail_textBox.TabIndex = 14;
            // 
            // ListStu_button
            // 
            ListStu_button.Location = new Point(672, 46);
            ListStu_button.Margin = new Padding(0, 3, 3, 0);
            ListStu_button.Name = "ListStu_button";
            ListStu_button.Size = new Size(118, 23);
            ListStu_button.TabIndex = 16;
            ListStu_button.Text = "List Stu Alphabet'ly";
            ListStu_button.UseVisualStyleBackColor = true;
            ListStu_button.Click += ListStu_button_Click;
            // 
            // FindStuByTelEmail_button
            // 
            FindStuByTelEmail_button.Location = new Point(672, 71);
            FindStuByTelEmail_button.Margin = new Padding(0, 3, 0, 3);
            FindStuByTelEmail_button.Name = "FindStuByTelEmail_button";
            FindStuByTelEmail_button.Size = new Size(118, 23);
            FindStuByTelEmail_button.TabIndex = 17;
            FindStuByTelEmail_button.Text = "Find Stu by Tel/Eml";
            FindStuByTelEmail_button.UseVisualStyleBackColor = true;
            FindStuByTelEmail_button.Click += FindStuByTelEmail_button_Click;
            // 
            // CopyStudent_button
            // 
            CopyStudent_button.Location = new Point(672, 121);
            CopyStudent_button.Name = "CopyStudent_button";
            CopyStudent_button.Size = new Size(118, 23);
            CopyStudent_button.TabIndex = 19;
            CopyStudent_button.Text = "Copy Student";
            CopyStudent_button.UseVisualStyleBackColor = true;
            CopyStudent_button.Click += CopyStudent_button_Click;
            // 
            // ListMember_button
            // 
            ListMember_button.Location = new Point(672, 96);
            ListMember_button.Name = "ListMember_button";
            ListMember_button.Size = new Size(118, 23);
            ListMember_button.TabIndex = 18;
            ListMember_button.Text = "List Members";
            ListMember_button.UseVisualStyleBackColor = true;
            ListMember_button.Click += ListMember_button_Click;
            // 
            // TelEmail_button
            // 
            TelEmail_button.Location = new Point(10, 47);
            TelEmail_button.Name = "TelEmail_button";
            TelEmail_button.Size = new Size(70, 23);
            TelEmail_button.TabIndex = 16;
            TelEmail_button.Text = "Tel/Email";
            TelEmail_button.UseVisualStyleBackColor = true;
            // 
            // Address_label
            // 
            Address_label.AutoSize = true;
            Address_label.Location = new Point(9, 77);
            Address_label.Name = "Address_label";
            Address_label.Size = new Size(49, 15);
            Address_label.TabIndex = 20;
            Address_label.Text = "Address";
            // 
            // Address_textBox
            // 
            Address_textBox.Location = new Point(82, 76);
            Address_textBox.Multiline = true;
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(202, 68);
            Address_textBox.TabIndex = 21;
            // 
            // BillingAddress_textBox
            // 
            BillingAddress_textBox.Location = new Point(338, 76);
            BillingAddress_textBox.Multiline = true;
            BillingAddress_textBox.Name = "BillingAddress_textBox";
            BillingAddress_textBox.Size = new Size(202, 68);
            BillingAddress_textBox.TabIndex = 23;
            // 
            // BilingAddress_label
            // 
            BilingAddress_label.Location = new Point(287, 76);
            BilingAddress_label.Name = "BilingAddress_label";
            BilingAddress_label.Size = new Size(52, 31);
            BilingAddress_label.TabIndex = 22;
            BilingAddress_label.Text = "Billing Address";
            // 
            // MemberOfLabel
            // 
            MemberOfLabel.AutoSize = true;
            MemberOfLabel.Location = new Point(546, 75);
            MemberOfLabel.Name = "MemberOfLabel";
            MemberOfLabel.Size = new Size(66, 15);
            MemberOfLabel.TabIndex = 25;
            MemberOfLabel.Text = "Member of";
            // 
            // PrintBillingAddress_pictureBox
            // 
            PrintBillingAddress_pictureBox.Image = Properties.Resources.ENVELOP;
            PrintBillingAddress_pictureBox.Location = new Point(290, 110);
            PrintBillingAddress_pictureBox.Name = "PrintBillingAddress_pictureBox";
            PrintBillingAddress_pictureBox.Size = new Size(21, 13);
            PrintBillingAddress_pictureBox.TabIndex = 26;
            PrintBillingAddress_pictureBox.TabStop = false;
            // 
            // Address_pictureBox
            // 
            Address_pictureBox.Image = Properties.Resources.ENVELOP;
            Address_pictureBox.Location = new Point(13, 95);
            Address_pictureBox.Name = "Address_pictureBox";
            Address_pictureBox.Size = new Size(21, 13);
            Address_pictureBox.TabIndex = 27;
            Address_pictureBox.TabStop = false;
            Address_pictureBox.Click += Address_pictureBox_Click;
            // 
            // Test_label
            // 
            Test_label.AutoSize = true;
            Test_label.Location = new Point(-4, 438);
            Test_label.Name = "Test_label";
            Test_label.Size = new Size(27, 15);
            Test_label.TabIndex = 28;
            Test_label.Text = "Test";
            Test_label.Visible = false;
            // 
            // MemberOf_textBox
            // 
            MemberOf_textBox.Location = new Point(546, 92);
            MemberOf_textBox.Multiline = true;
            MemberOf_textBox.Name = "MemberOf_textBox";
            MemberOf_textBox.Size = new Size(120, 23);
            MemberOf_textBox.TabIndex = 29;
            // 
            // Color_button
            // 
            Color_button.Location = new Point(543, 121);
            Color_button.Name = "Color_button";
            Color_button.Size = new Size(122, 23);
            Color_button.TabIndex = 30;
            Color_button.Text = "Color";
            Color_button.UseVisualStyleBackColor = true;
            Color_button.Click += Color_button_Click;
            // 
            // Notes_textBox
            // 
            Notes_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Notes_textBox.Location = new Point(14, 151);
            Notes_textBox.Multiline = true;
            Notes_textBox.Name = "Notes_textBox";
            Notes_textBox.Size = new Size(651, 58);
            Notes_textBox.TabIndex = 31;
            // 
            // AlreadyConf_label
            // 
            AlreadyConf_label.AutoSize = true;
            AlreadyConf_label.Location = new Point(671, 151);
            AlreadyConf_label.Name = "AlreadyConf_label";
            AlreadyConf_label.Size = new Size(119, 15);
            AlreadyConf_label.TabIndex = 32;
            AlreadyConf_label.Text = "Already Conf'med by";
            // 
            // Email_radioButton
            // 
            Email_radioButton.AutoSize = true;
            Email_radioButton.Location = new Point(684, 169);
            Email_radioButton.Name = "Email_radioButton";
            Email_radioButton.Size = new Size(54, 19);
            Email_radioButton.TabIndex = 33;
            Email_radioButton.TabStop = true;
            Email_radioButton.Text = "Email";
            Email_radioButton.UseVisualStyleBackColor = true;
            // 
            // Mail_radioButton
            // 
            Mail_radioButton.AutoSize = true;
            Mail_radioButton.Location = new Point(740, 169);
            Mail_radioButton.Name = "Mail_radioButton";
            Mail_radioButton.Size = new Size(48, 19);
            Mail_radioButton.TabIndex = 34;
            Mail_radioButton.TabStop = true;
            Mail_radioButton.Text = "Mail";
            Mail_radioButton.UseVisualStyleBackColor = true;
            // 
            // Any_radioButton
            // 
            Any_radioButton.AutoSize = true;
            Any_radioButton.Location = new Point(740, 186);
            Any_radioButton.Name = "Any_radioButton";
            Any_radioButton.Size = new Size(46, 19);
            Any_radioButton.TabIndex = 36;
            Any_radioButton.TabStop = true;
            Any_radioButton.Text = "Any";
            Any_radioButton.UseVisualStyleBackColor = true;
            // 
            // Fax_radioButton
            // 
            Fax_radioButton.AutoSize = true;
            Fax_radioButton.Location = new Point(684, 186);
            Fax_radioButton.Name = "Fax_radioButton";
            Fax_radioButton.Size = new Size(43, 19);
            Fax_radioButton.TabIndex = 35;
            Fax_radioButton.TabStop = true;
            Fax_radioButton.Text = "Fax";
            Fax_radioButton.UseVisualStyleBackColor = true;
            // 
            // Notes_label
            // 
            Notes_label.AutoSize = true;
            Notes_label.Location = new Point(10, 135);
            Notes_label.Name = "Notes_label";
            Notes_label.Size = new Size(38, 15);
            Notes_label.TabIndex = 37;
            Notes_label.Text = "Notes";
            // 
            // Courses_listView
            // 
            Courses_listView.Columns.AddRange(new ColumnHeader[] { Number, Date, Sbj });
            Courses_listView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            Courses_listView.Location = new Point(14, 232);
            Courses_listView.Name = "Courses_listView";
            Courses_listView.Size = new Size(450, 206);
            Courses_listView.TabIndex = 38;
            Courses_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Number
            // 
            Number.Width = 10;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 48;
            // 
            // Sbj
            // 
            Sbj.Text = "Sbj";
            Sbj.Width = 80;
            // 
            // Courses_label
            // 
            Courses_label.AutoSize = true;
            Courses_label.Location = new Point(13, 215);
            Courses_label.Name = "Courses_label";
            Courses_label.Size = new Size(57, 15);
            Courses_label.TabIndex = 39;
            Courses_label.Text = "Course(s)";
            // 
            // Payment_label
            // 
            Payment_label.AutoSize = true;
            Payment_label.Location = new Point(737, 215);
            Payment_label.Name = "Payment_label";
            Payment_label.Size = new Size(54, 15);
            Payment_label.TabIndex = 41;
            Payment_label.Text = "Payment";
            Payment_label.Click += Payment_label_Click;
            // 
            // button1
            // 
            button1.Location = new Point(468, 212);
            button1.Name = "button1";
            button1.Size = new Size(90, 22);
            button1.TabIndex = 42;
            button1.Text = "New Payment";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(558, 212);
            button2.Name = "button2";
            button2.Size = new Size(85, 22);
            button2.TabIndex = 43;
            button2.Text = "Edit Payment";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(643, 212);
            button3.Name = "button3";
            button3.Size = new Size(53, 22);
            button3.TabIndex = 44;
            button3.Text = "Refund";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(696, 212);
            button4.Name = "button4";
            button4.Size = new Size(38, 22);
            button4.TabIndex = 45;
            button4.Text = "Void";
            button4.UseVisualStyleBackColor = true;
            // 
            // PaymentRmks_textBox
            // 
            PaymentRmks_textBox.Location = new Point(469, 401);
            PaymentRmks_textBox.Multiline = true;
            PaymentRmks_textBox.Name = "PaymentRmks_textBox";
            PaymentRmks_textBox.Size = new Size(322, 37);
            PaymentRmks_textBox.TabIndex = 46;
            // 
            // Payment_dataGridView
            // 
            Payment_dataGridView.AllowUserToOrderColumns = true;
            Payment_dataGridView.AutoGenerateColumns = false;
            Payment_dataGridView.BackgroundColor = SystemColors.Window;
            Payment_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Payment_dataGridView.DataSource = SfDataGridBindingSource;
            Payment_dataGridView.Location = new Point(469, 232);
            Payment_dataGridView.Name = "Payment_dataGridView";
            Payment_dataGridView.RowTemplate.Height = 25;
            Payment_dataGridView.Size = new Size(322, 170);
            Payment_dataGridView.TabIndex = 47;
            // 
            // SfDataGridBindingSource
            // 
            SfDataGridBindingSource.DataSource = typeof(SfDataGrid);
            SfDataGridBindingSource.CurrentChanged += SfDataGridBindingSource_CurrentChanged;
            // 
            // Student_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Payment_dataGridView);
            Controls.Add(PaymentRmks_textBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Payment_label);
            Controls.Add(Courses_label);
            Controls.Add(Courses_listView);
            Controls.Add(Notes_label);
            Controls.Add(Any_radioButton);
            Controls.Add(Fax_radioButton);
            Controls.Add(Mail_radioButton);
            Controls.Add(Email_radioButton);
            Controls.Add(AlreadyConf_label);
            Controls.Add(Notes_textBox);
            Controls.Add(Color_button);
            Controls.Add(MemberOf_textBox);
            Controls.Add(Test_label);
            Controls.Add(Address_pictureBox);
            Controls.Add(PrintBillingAddress_pictureBox);
            Controls.Add(MemberOfLabel);
            Controls.Add(BillingAddress_textBox);
            Controls.Add(BilingAddress_label);
            Controls.Add(Address_textBox);
            Controls.Add(Address_label);
            Controls.Add(CopyStudent_button);
            Controls.Add(ListMember_button);
            Controls.Add(FindStuByTelEmail_button);
            Controls.Add(TelEmail_button);
            Controls.Add(ListStu_button);
            Controls.Add(TelEmail_textBox);
            Controls.Add(OtherID_textBox);
            Controls.Add(StuID_label);
            Controls.Add(Other_label);
            Controls.Add(StudentID_textBox);
            Controls.Add(StudentID_label);
            Controls.Add(Female_radioButton);
            Controls.Add(Male_radioButton);
            Controls.Add(Sex_label);
            Controls.Add(GivenName_textBox);
            Controls.Add(GivenName_label);
            Controls.Add(Surname_textBox);
            Controls.Add(Surname_radioButton);
            Controls.Add(BizEntity_radioButton);
            Controls.Add(BizEntity_textBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Form";
            Text = "Student";
            Load += Student_Form_Load;
            ((System.ComponentModel.ISupportInitialize)PrintBillingAddress_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Address_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Payment_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SfDataGridBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton BizEntity_radioButton;
        private RadioButton Surname_radioButton;
        private TextBox Surname_textBox;
        private Label GivenName_label;
        private TextBox GivenName_textBox;
        private Label Sex_label;
        private RadioButton Male_radioButton;
        private RadioButton Female_radioButton;
        private Label StudentID_label;
        private TextBox StudentID_textBox;
        private Label Other_label;
        private Label StuID_label;
        private TextBox OtherID_textBox;
        private TextBox BizEntity_textBox;
        private TextBox TelEmail_textBox;
        private Button ListStu_button;
        private Button FindStuByTelEmail_button;
        private Button CopyStudent_button;
        private Button ListMember_button;
        private Button TelEmail_button;
        private Label Address_label;
        private TextBox Address_textBox;
        private TextBox BillingAddress_textBox;
        private Label BilingAddress_label;
        private Label MemberOfLabel;
        private PictureBox PrintBillingAddress_pictureBox;
        private PictureBox Address_pictureBox;
        private Label Test_label;
        private TextBox MemberOf_textBox;
        private Button Color_button;
        private TextBox Notes_textBox;
        private Label AlreadyConf_label;
        private RadioButton Email_radioButton;
        private RadioButton Mail_radioButton;
        private RadioButton Any_radioButton;
        private RadioButton Fax_radioButton;
        private Label Notes_label;
        private ListView Courses_listView;
        private Label Courses_label;
        private Label Payment_label;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox PaymentRmks_textBox;
        private ColumnHeader Amount_columnHeader;
        private ColumnHeader PaidBy_columnHeader;
        private DataGridView Payment_dataGridView;
        private Panel DataGridPanel;
        private ColumnHeader Number;
        private ColumnHeader Date;
        private ColumnHeader Sbj;
        private BindingSource SfDataGridBindingSource;
    }
}