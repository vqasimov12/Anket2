namespace Task2
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
            name = new TextBox();
            panel3 = new Panel();
            surname = new TextBox();
            panel4 = new Panel();
            email = new TextBox();
            panel5 = new Panel();
            phone = new TextBox();
            panel6 = new Panel();
            birthday = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            Load = new Button();
            listBox = new ListBox();
            search = new TextBox();
            SaveChanges = new Button();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            Add = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(191, 40);
            name.Name = "name";
            name.Size = new Size(218, 30);
            name.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Brown;
            panel3.Location = new Point(191, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 10);
            panel3.TabIndex = 2;
            // 
            // surname
            // 
            surname.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            surname.Location = new Point(191, 105);
            surname.Name = "surname";
            surname.Size = new Size(218, 30);
            surname.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Location = new Point(191, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 10);
            panel4.TabIndex = 4;
            // 
            // email
            // 
            email.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(191, 171);
            email.Name = "email";
            email.Size = new Size(218, 30);
            email.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Brown;
            panel5.Location = new Point(191, 194);
            panel5.Name = "panel5";
            panel5.Size = new Size(218, 10);
            panel5.TabIndex = 6;
            // 
            // phone
            // 
            phone.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(191, 241);
            phone.Name = "phone";
            phone.Size = new Size(218, 30);
            phone.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Brown;
            panel6.Location = new Point(191, 264);
            panel6.Name = "panel6";
            panel6.Size = new Size(218, 10);
            panel6.TabIndex = 12;
            // 
            // birthday
            // 
            birthday.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            birthday.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            birthday.Location = new Point(191, 307);
            birthday.Name = "birthday";
            birthday.Size = new Size(218, 27);
            birthday.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 110);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 16;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 179);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(62, 247);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 20;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(62, 311);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 21;
            label7.Text = "BirthDay";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(636, 363);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save_Click;
            // 
            // Load
            // 
            Load.FlatStyle = FlatStyle.Popup;
            Load.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Load.Location = new Point(471, 363);
            Load.Name = "Load";
            Load.Size = new Size(117, 35);
            Load.TabIndex = 24;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(471, 38);
            listBox.Name = "listBox";
            listBox.Size = new Size(282, 244);
            listBox.TabIndex = 26;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // search
            // 
            search.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.Location = new Point(471, 311);
            search.Name = "search";
            search.Size = new Size(282, 30);
            search.TabIndex = 27;
            // 
            // SaveChanges
            // 
            SaveChanges.BackColor = Color.Cyan;
            SaveChanges.FlatStyle = FlatStyle.Popup;
            SaveChanges.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveChanges.Location = new Point(311, 363);
            SaveChanges.Name = "SaveChanges";
            SaveChanges.Size = new Size(98, 35);
            SaveChanges.TabIndex = 28;
            SaveChanges.Text = "Save Changes";
            SaveChanges.UseVisualStyleBackColor = false;
            SaveChanges.Click += SaveChanges_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(471, 334);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 10);
            panel1.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Add
            // 
            Add.BackColor = Color.Cyan;
            Add.FlatStyle = FlatStyle.Popup;
            Add.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(191, 363);
            Add.Name = "Add";
            Add.Size = new Size(98, 35);
            Add.TabIndex = 30;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 416);
            Controls.Add(Add);
            Controls.Add(SaveChanges);
            Controls.Add(search);
            Controls.Add(button1);
            Controls.Add(Load);
            Controls.Add(listBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(birthday);
            Controls.Add(phone);
            Controls.Add(panel6);
            Controls.Add(email);
            Controls.Add(panel5);
            Controls.Add(surname);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox name;
        private Panel panel3;
        private TextBox surname;
        private Panel panel4;
        private TextBox email;
        private Panel panel5;
        private TextBox phone;
        private Panel panel6;
        private DateTimePicker birthday;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button Load;
        private ListBox listBox;
        private TextBox search;
        private Button SaveChanges;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button Add;
    }
}