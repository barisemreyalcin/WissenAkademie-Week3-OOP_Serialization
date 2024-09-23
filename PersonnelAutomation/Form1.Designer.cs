namespace PersonnelAutomation
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
            grpPersonnelInfo = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbTitle = new ComboBox();
            dtEmploymentStartDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            btnChoosePicture = new Button();
            pbPicture = new PictureBox();
            txtPhone = new TextBox();
            dtBirthYear = new DateTimePicker();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtRepOfTurId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvPersonnels = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            grpPersonnelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // grpPersonnelInfo
            // 
            grpPersonnelInfo.Controls.Add(btnDelete);
            grpPersonnelInfo.Controls.Add(btnUpdate);
            grpPersonnelInfo.Controls.Add(btnAdd);
            grpPersonnelInfo.Controls.Add(cmbTitle);
            grpPersonnelInfo.Controls.Add(dtEmploymentStartDate);
            grpPersonnelInfo.Controls.Add(label8);
            grpPersonnelInfo.Controls.Add(label7);
            grpPersonnelInfo.Controls.Add(btnChoosePicture);
            grpPersonnelInfo.Controls.Add(pbPicture);
            grpPersonnelInfo.Controls.Add(txtPhone);
            grpPersonnelInfo.Controls.Add(dtBirthYear);
            grpPersonnelInfo.Controls.Add(txtEmail);
            grpPersonnelInfo.Controls.Add(txtLastName);
            grpPersonnelInfo.Controls.Add(txtFirstName);
            grpPersonnelInfo.Controls.Add(txtRepOfTurId);
            grpPersonnelInfo.Controls.Add(label6);
            grpPersonnelInfo.Controls.Add(label5);
            grpPersonnelInfo.Controls.Add(label4);
            grpPersonnelInfo.Controls.Add(label3);
            grpPersonnelInfo.Controls.Add(label2);
            grpPersonnelInfo.Controls.Add(label1);
            grpPersonnelInfo.Location = new Point(22, 23);
            grpPersonnelInfo.Name = "grpPersonnelInfo";
            grpPersonnelInfo.Size = new Size(836, 401);
            grpPersonnelInfo.TabIndex = 0;
            grpPersonnelInfo.TabStop = false;
            grpPersonnelInfo.Text = "Personnel Info";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(465, 346);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 41);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(350, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 41);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(235, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 41);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbTitle
            // 
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Location = new Point(234, 298);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(326, 28);
            cmbTitle.TabIndex = 7;
            // 
            // dtEmploymentStartDate
            // 
            dtEmploymentStartDate.Location = new Point(234, 260);
            dtEmploymentStartDate.Name = "dtEmploymentStartDate";
            dtEmploymentStartDate.Size = new Size(326, 27);
            dtEmploymentStartDate.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 304);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 17;
            label8.Text = "Title:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 267);
            label7.Name = "label7";
            label7.Size = new Size(167, 20);
            label7.TabIndex = 16;
            label7.Text = "Employment Start Date:";
            // 
            // btnChoosePicture
            // 
            btnChoosePicture.Location = new Point(595, 283);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.Size = new Size(214, 46);
            btnChoosePicture.TabIndex = 8;
            btnChoosePicture.Text = "Choose a picture";
            btnChoosePicture.UseVisualStyleBackColor = true;
            btnChoosePicture.Click += btnChoosePicture_Click;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(595, 35);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(214, 232);
            pbPicture.TabIndex = 14;
            pbPicture.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(234, 222);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(326, 27);
            txtPhone.TabIndex = 5;
            // 
            // dtBirthYear
            // 
            dtBirthYear.Location = new Point(234, 146);
            dtBirthYear.Name = "dtBirthYear";
            dtBirthYear.Size = new Size(326, 27);
            dtBirthYear.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(234, 184);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(234, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(326, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(234, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(326, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtRepOfTurId
            // 
            txtRepOfTurId.Location = new Point(234, 32);
            txtRepOfTurId.Name = "txtRepOfTurId";
            txtRepOfTurId.Size = new Size(326, 27);
            txtRepOfTurId.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 230);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 6;
            label6.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 191);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 153);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Birth Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Republic of Turkey Id:";
            // 
            // lvPersonnels
            // 
            lvPersonnels.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvPersonnels.GridLines = true;
            lvPersonnels.Location = new Point(22, 442);
            lvPersonnels.Name = "lvPersonnels";
            lvPersonnels.Size = new Size(836, 230);
            lvPersonnels.TabIndex = 1;
            lvPersonnels.UseCompatibleStateImageBehavior = false;
            lvPersonnels.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Rep. Of Turkey Id";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Full Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Birth Date";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Empl. Start Date";
            columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Title";
            columnHeader7.Width = 110;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 698);
            Controls.Add(lvPersonnels);
            Controls.Add(grpPersonnelInfo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpPersonnelInfo.ResumeLayout(false);
            grpPersonnelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonnelInfo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private DateTimePicker dtBirthYear;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtRepOfTurId;
        private Button btnChoosePicture;
        private PictureBox pbPicture;
        private Label label8;
        private Label label7;
        private ComboBox cmbTitle;
        private DateTimePicker dtEmploymentStartDate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ListView lvPersonnels;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
