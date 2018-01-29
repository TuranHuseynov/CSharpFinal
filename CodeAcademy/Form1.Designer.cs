namespace CodeAcademy
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Brown;
            this.button3.Location = new System.Drawing.Point(110, 442);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Student";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(569, 442);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mentor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacher
            // 
            this.teacher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teacher.BackColor = System.Drawing.Color.Silver;
            this.teacher.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.teacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.teacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.Brown;
            this.teacher.Location = new System.Drawing.Point(309, 442);
            this.teacher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(219, 52);
            this.teacher.TabIndex = 5;
            this.teacher.Text = "Teacher";
            this.teacher.UseVisualStyleBackColor = false;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.FlatAppearance.BorderSize = 0;
            this.admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Silver;
            this.admin.Location = new System.Drawing.Point(84, 340);
            this.admin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(92, 34);
            this.admin.TabIndex = 6;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.Color.Transparent;
            this.code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.code.Font = new System.Drawing.Font("Gabriola", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.DimGray;
            this.code.Location = new System.Drawing.Point(379, -22);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(503, 147);
            this.code.TabIndex = 7;
            this.code.Text = "Code  Academy ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 502);
            this.Controls.Add(this.code);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.teacher);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Label code;
    }
}

