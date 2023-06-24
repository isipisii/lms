namespace LibraryManagementSystem.UserControls
{
    partial class StudentCardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCardUserControl));
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.courseCodeLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.deletePicBox = new System.Windows.Forms.PictureBox();
            this.editPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(83, 29);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(86, 20);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLbl.Location = new System.Drawing.Point(233, 29);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(86, 20);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(403, 29);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(48, 20);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email";
            // 
            // courseCodeLbl
            // 
            this.courseCodeLbl.AutoSize = true;
            this.courseCodeLbl.Location = new System.Drawing.Point(639, 29);
            this.courseCodeLbl.Name = "courseCodeLbl";
            this.courseCodeLbl.Size = new System.Drawing.Size(102, 20);
            this.courseCodeLbl.TabIndex = 3;
            this.courseCodeLbl.Text = "Course Code";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(767, 29);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(63, 20);
            this.genderLbl.TabIndex = 4;
            this.genderLbl.Text = "Gender";
            // 
            // deletePicBox
            // 
            this.deletePicBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePicBox.Image")));
            this.deletePicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("deletePicBox.InitialImage")));
            this.deletePicBox.Location = new System.Drawing.Point(931, 19);
            this.deletePicBox.Name = "deletePicBox";
            this.deletePicBox.Size = new System.Drawing.Size(33, 41);
            this.deletePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePicBox.TabIndex = 6;
            this.deletePicBox.TabStop = false;
            this.deletePicBox.Click += new System.EventHandler(this.deletePicBox_Click);
            // 
            // editPicBox
            // 
            this.editPicBox.Image = ((System.Drawing.Image)(resources.GetObject("editPicBox.Image")));
            this.editPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("editPicBox.InitialImage")));
            this.editPicBox.Location = new System.Drawing.Point(874, 19);
            this.editPicBox.Name = "editPicBox";
            this.editPicBox.Size = new System.Drawing.Size(33, 41);
            this.editPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editPicBox.TabIndex = 7;
            this.editPicBox.TabStop = false;
            this.editPicBox.Click += new System.EventHandler(this.editPicBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.selectBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectBtn.Image")));
            this.selectBtn.Location = new System.Drawing.Point(902, 19);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(37, 41);
            this.selectBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectBtn.TabIndex = 9;
            this.selectBtn.TabStop = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // StudentCardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editPicBox);
            this.Controls.Add(this.deletePicBox);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.courseCodeLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentCardUserControl";
            this.Size = new System.Drawing.Size(979, 83);
            this.Load += new System.EventHandler(this.StudentCardUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label courseCodeLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.PictureBox deletePicBox;
        private System.Windows.Forms.PictureBox editPicBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox selectBtn;
    }
}
