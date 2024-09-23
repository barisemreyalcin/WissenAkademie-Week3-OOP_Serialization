namespace StudentSerialization
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
            grpStudentInfo = new GroupBox();
            rtxtAbout = new RichTextBox();
            dtBirthDate = new DateTimePicker();
            txtGpa = new TextBox();
            txtDepartment = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSerialize = new Button();
            btnDeserialize = new Button();
            grpStudentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grpStudentInfo
            // 
            grpStudentInfo.Controls.Add(rtxtAbout);
            grpStudentInfo.Controls.Add(dtBirthDate);
            grpStudentInfo.Controls.Add(txtGpa);
            grpStudentInfo.Controls.Add(txtDepartment);
            grpStudentInfo.Controls.Add(txtPhone);
            grpStudentInfo.Controls.Add(txtEmail);
            grpStudentInfo.Controls.Add(txtFullName);
            grpStudentInfo.Controls.Add(label7);
            grpStudentInfo.Controls.Add(label6);
            grpStudentInfo.Controls.Add(label5);
            grpStudentInfo.Controls.Add(label4);
            grpStudentInfo.Controls.Add(label3);
            grpStudentInfo.Controls.Add(label2);
            grpStudentInfo.Controls.Add(label1);
            grpStudentInfo.Location = new Point(23, 24);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Size = new Size(408, 405);
            grpStudentInfo.TabIndex = 0;
            grpStudentInfo.TabStop = false;
            grpStudentInfo.Text = "Student Information";
            // 
            // rtxtAbout
            // 
            rtxtAbout.Location = new Point(6, 289);
            rtxtAbout.Name = "rtxtAbout";
            rtxtAbout.Size = new Size(390, 103);
            rtxtAbout.TabIndex = 6;
            rtxtAbout.Text = "";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(126, 74);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(270, 27);
            dtBirthDate.TabIndex = 1;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(126, 222);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(270, 27);
            txtGpa.TabIndex = 5;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(126, 185);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(270, 27);
            txtDepartment.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(126, 148);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(270, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(126, 37);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(270, 27);
            txtFullName.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 266);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 6;
            label7.Text = "About You: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 229);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 5;
            label6.Text = "GPA: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 187);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Department: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 152);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone Number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Birth Date: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name: ";
            // 
            // btnSerialize
            // 
            btnSerialize.Location = new Point(23, 454);
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(94, 43);
            btnSerialize.TabIndex = 1;
            btnSerialize.Text = "SERIALIZE";
            btnSerialize.UseVisualStyleBackColor = true;
            btnSerialize.Click += btnSerialize_Click;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(320, 454);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(111, 43);
            btnDeserialize.TabIndex = 2;
            btnDeserialize.Text = "DESERIALIZE";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 534);
            Controls.Add(btnDeserialize);
            Controls.Add(btnSerialize);
            Controls.Add(grpStudentInfo);
            Name = "Form1";
            Text = "Form1";
            grpStudentInfo.ResumeLayout(false);
            grpStudentInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpStudentInfo;
        private TextBox txtGpa;
        private TextBox txtDepartment;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtBirthDate;
        private RichTextBox rtxtAbout;
        private Button btnSerialize;
        private Button btnDeserialize;
    }
}
