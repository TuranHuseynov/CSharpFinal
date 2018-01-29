namespace CodeAcademy
{
    partial class Add_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Group));
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbMentor = new System.Windows.Forms.ComboBox();
            this.cmbTypeNumber = new System.Windows.Forms.ComboBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridGroup = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTypes = new System.Windows.Forms.Button();
            this.groupSchedule = new System.Windows.Forms.Button();
            this.taskType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(367, 69);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(135, 21);
            this.cmbTeacher.TabIndex = 1;
            // 
            // cmbMentor
            // 
            this.cmbMentor.FormattingEnabled = true;
            this.cmbMentor.Location = new System.Drawing.Point(367, 25);
            this.cmbMentor.Name = "cmbMentor";
            this.cmbMentor.Size = new System.Drawing.Size(135, 21);
            this.cmbMentor.TabIndex = 2;
            // 
            // cmbTypeNumber
            // 
            this.cmbTypeNumber.FormattingEnabled = true;
            this.cmbTypeNumber.Location = new System.Drawing.Point(85, 69);
            this.cmbTypeNumber.Name = "cmbTypeNumber";
            this.cmbTypeNumber.Size = new System.Drawing.Size(172, 21);
            this.cmbTypeNumber.TabIndex = 3;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(124, 111);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(133, 20);
            this.dateTimeStart.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(286, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(367, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Upload";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(448, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teacher :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mentor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Date :";
            // 
            // dataGridGroup
            // 
            this.dataGridGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGroup.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridGroup.Location = new System.Drawing.Point(12, 260);
            this.dataGridGroup.Name = "dataGridGroup";
            this.dataGridGroup.Size = new System.Drawing.Size(731, 194);
            this.dataGridGroup.TabIndex = 9;
            this.dataGridGroup.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridGroup_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60.9137F;
            this.Column6.HeaderText = "id";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 107.8173F;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 107.8173F;
            this.Column2.HeaderText = "Type Number";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 107.8173F;
            this.Column3.HeaderText = "Teacher";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 107.8173F;
            this.Column4.HeaderText = "Mentor";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 107.8173F;
            this.Column5.HeaderText = "Start Date";
            this.Column5.Name = "Column5";
            // 
            // groupTypes
            // 
            this.groupTypes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTypes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupTypes.Location = new System.Drawing.Point(669, 69);
            this.groupTypes.Name = "groupTypes";
            this.groupTypes.Size = new System.Drawing.Size(134, 31);
            this.groupTypes.TabIndex = 10;
            this.groupTypes.Text = "Add Group Types";
            this.groupTypes.UseVisualStyleBackColor = false;
            this.groupTypes.Click += new System.EventHandler(this.groupTypes_Click);
            // 
            // groupSchedule
            // 
            this.groupSchedule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupSchedule.Location = new System.Drawing.Point(651, 32);
            this.groupSchedule.Name = "groupSchedule";
            this.groupSchedule.Size = new System.Drawing.Size(134, 32);
            this.groupSchedule.TabIndex = 11;
            this.groupSchedule.Text = "Add Group Schedule";
            this.groupSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.groupSchedule.UseVisualStyleBackColor = false;
            this.groupSchedule.Click += new System.EventHandler(this.groupSchedule_Click);
            // 
            // taskType
            // 
            this.taskType.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.taskType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taskType.Location = new System.Drawing.Point(696, 106);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(134, 31);
            this.taskType.TabIndex = 12;
            this.taskType.Text = "Add Task Type";
            this.taskType.UseVisualStyleBackColor = false;
            this.taskType.Click += new System.EventHandler(this.taskType_Click);
            // 
            // Add_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 466);
            this.Controls.Add(this.taskType);
            this.Controls.Add(this.groupSchedule);
            this.Controls.Add(this.groupTypes);
            this.Controls.Add(this.dataGridGroup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.cmbTypeNumber);
            this.Controls.Add(this.cmbMentor);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Add_Group";
            this.Text = "Add_Group";
            this.Load += new System.EventHandler(this.Add_Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbMentor;
        private System.Windows.Forms.ComboBox cmbTypeNumber;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridGroup;
        private System.Windows.Forms.Button groupTypes;
        private System.Windows.Forms.Button groupSchedule;
        private System.Windows.Forms.Button taskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}