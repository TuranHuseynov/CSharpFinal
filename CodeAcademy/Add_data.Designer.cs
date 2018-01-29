namespace CodeAcademy
{
    partial class Add_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_data));
            this.addTeacher = new System.Windows.Forms.Button();
            this.addMentor = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTeacher
            // 
            this.addTeacher.BackColor = System.Drawing.Color.Transparent;
            this.addTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacher.Location = new System.Drawing.Point(233, 13);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(142, 52);
            this.addTeacher.TabIndex = 0;
            this.addTeacher.Text = "Add Teacher";
            this.addTeacher.UseVisualStyleBackColor = false;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // addMentor
            // 
            this.addMentor.BackColor = System.Drawing.Color.Transparent;
            this.addMentor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMentor.Location = new System.Drawing.Point(395, 12);
            this.addMentor.Name = "addMentor";
            this.addMentor.Size = new System.Drawing.Size(147, 53);
            this.addMentor.TabIndex = 1;
            this.addMentor.Text = "Add Mentor";
            this.addMentor.UseVisualStyleBackColor = false;
            this.addMentor.Click += new System.EventHandler(this.addMentor_Click);
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.Transparent;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.Location = new System.Drawing.Point(559, 12);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(147, 53);
            this.addStudent.TabIndex = 2;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(725, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(145, 53);
            this.group.TabIndex = 3;
            this.group.Text = "Add Group";
            this.group.UseVisualStyleBackColor = false;
            this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.Color.Transparent;
            this.code.Font = new System.Drawing.Font("Gabriola", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.DarkRed;
            this.code.Location = new System.Drawing.Point(471, 398);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(334, 99);
            this.code.TabIndex = 8;
            this.code.Text = "Code  Academy ...";
            // 
            // Add_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 485);
            this.Controls.Add(this.code);
            this.Controls.Add(this.group);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.addMentor);
            this.Controls.Add(this.addTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Add_data";
            this.Text = "Add_data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.Button addMentor;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button group;
        private System.Windows.Forms.Label code;
    }
}