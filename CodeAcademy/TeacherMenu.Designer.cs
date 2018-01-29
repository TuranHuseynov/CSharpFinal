namespace CodeAcademy
{
    partial class TeacherMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMenu));
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_info = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_phone = new System.Windows.Forms.TextBox();
            this.t_surname = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridTeacher = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.teacherPhoto = new System.Windows.Forms.PictureBox();
            this.selectPhoto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // t_name
            // 
            this.t_name.BackColor = System.Drawing.SystemColors.Control;
            this.t_name.Location = new System.Drawing.Point(154, 185);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(128, 20);
            this.t_name.TabIndex = 0;
            // 
            // t_email
            // 
            this.t_email.BackColor = System.Drawing.SystemColors.Control;
            this.t_email.Location = new System.Drawing.Point(353, 42);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(128, 20);
            this.t_email.TabIndex = 0;
            // 
            // t_info
            // 
            this.t_info.BackColor = System.Drawing.SystemColors.Control;
            this.t_info.Location = new System.Drawing.Point(672, 12);
            this.t_info.Multiline = true;
            this.t_info.Name = "t_info";
            this.t_info.Size = new System.Drawing.Size(104, 51);
            this.t_info.TabIndex = 0;
            // 
            // t_password
            // 
            this.t_password.BackColor = System.Drawing.SystemColors.Control;
            this.t_password.Location = new System.Drawing.Point(651, 79);
            this.t_password.Multiline = true;
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(128, 20);
            this.t_password.TabIndex = 0;
            this.t_password.UseSystemPasswordChar = true;
            // 
            // t_phone
            // 
            this.t_phone.BackColor = System.Drawing.SystemColors.Control;
            this.t_phone.Location = new System.Drawing.Point(352, 8);
            this.t_phone.Name = "t_phone";
            this.t_phone.Size = new System.Drawing.Size(128, 20);
            this.t_phone.TabIndex = 0;
            // 
            // t_surname
            // 
            this.t_surname.BackColor = System.Drawing.SystemColors.Control;
            this.t_surname.Location = new System.Drawing.Point(154, 219);
            this.t_surname.Name = "t_surname";
            this.t_surname.Size = new System.Drawing.Size(128, 20);
            this.t_surname.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.Control;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(353, 79);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(128, 21);
            this.cmbGender.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teacher Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teacher Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Teacher info :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Teacher Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teacher Password :";
            // 
            // dataGridTeacher
            // 
            this.dataGridTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridTeacher.Location = new System.Drawing.Point(394, 351);
            this.dataGridTeacher.Name = "dataGridTeacher";
            this.dataGridTeacher.Size = new System.Drawing.Size(646, 159);
            this.dataGridTeacher.TabIndex = 3;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 71.06599F;
            this.Column7.HeaderText = "id";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 104.8223F;
            this.Column1.HeaderText = "Teacher Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 104.8223F;
            this.Column2.HeaderText = "Teacher Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 104.8223F;
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 104.8223F;
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 104.8223F;
            this.Column5.HeaderText = "Info";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 104.8223F;
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(776, 140);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(78, 26);
            this.btnAddTeacher.TabIndex = 4;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeacher.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdateTeacher.Location = new System.Drawing.Point(106, 319);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(97, 38);
            this.btnUpdateTeacher.TabIndex = 5;
            this.btnUpdateTeacher.Text = "Update";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(107, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // teacherPhoto
            // 
            this.teacherPhoto.Location = new System.Drawing.Point(860, 12);
            this.teacherPhoto.Name = "teacherPhoto";
            this.teacherPhoto.Size = new System.Drawing.Size(177, 116);
            this.teacherPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherPhoto.TabIndex = 7;
            this.teacherPhoto.TabStop = false;
            // 
            // selectPhoto
            // 
            this.selectPhoto.Location = new System.Drawing.Point(938, 134);
            this.selectPhoto.Name = "selectPhoto";
            this.selectPhoto.Size = new System.Drawing.Size(93, 26);
            this.selectPhoto.TabIndex = 8;
            this.selectPhoto.Text = "Select Photo";
            this.selectPhoto.UseVisualStyleBackColor = true;
            this.selectPhoto.Click += new System.EventHandler(this.selectPhoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(795, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Photo :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(946, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Teachers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(87, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "Code Academy";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(313, 487);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 24;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 513);
            this.Controls.Add(this.export);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectPhoto);
            this.Controls.Add(this.teacherPhoto);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.dataGridTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.t_phone);
            this.Controls.Add(this.t_info);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_surname);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TeacherMenu";
            this.Text = "TeacherMenu";
            this.Load += new System.EventHandler(this.TeacherMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_info;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_phone;
        private System.Windows.Forms.TextBox t_surname;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox teacherPhoto;
        private System.Windows.Forms.Button selectPhoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button export;
    }
}