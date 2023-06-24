namespace LibraryManagementSystem.UserControls
{
    partial class BorrowCardUserControl
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
            this.bookPb = new System.Windows.Forms.PictureBox();
            this.borrowerFNameLbl = new System.Windows.Forms.Label();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.dueDateLbl = new System.Windows.Forms.Label();
            this.borrowDateLbl = new System.Windows.Forms.Label();
            this.courseCodeLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.borrowState = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookPb)).BeginInit();
            this.SuspendLayout();
            // 
            // bookPb
            // 
            this.bookPb.Location = new System.Drawing.Point(28, 30);
            this.bookPb.Name = "bookPb";
            this.bookPb.Size = new System.Drawing.Size(195, 322);
            this.bookPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPb.TabIndex = 0;
            this.bookPb.TabStop = false;
            this.bookPb.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // borrowerFNameLbl
            // 
            this.borrowerFNameLbl.AutoSize = true;
            this.borrowerFNameLbl.Location = new System.Drawing.Point(322, 115);
            this.borrowerFNameLbl.Name = "borrowerFNameLbl";
            this.borrowerFNameLbl.Size = new System.Drawing.Size(51, 20);
            this.borrowerFNameLbl.TabIndex = 1;
            this.borrowerFNameLbl.Text = "label1";
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLbl.Location = new System.Drawing.Point(326, 81);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(57, 20);
            this.bookTitleLbl.TabIndex = 2;
            this.bookTitleLbl.Text = "label2";
            this.bookTitleLbl.Click += new System.EventHandler(this.bookTitleLbl_Click);
            // 
            // dueDateLbl
            // 
            this.dueDateLbl.AutoSize = true;
            this.dueDateLbl.Location = new System.Drawing.Point(331, 252);
            this.dueDateLbl.Name = "dueDateLbl";
            this.dueDateLbl.Size = new System.Drawing.Size(51, 20);
            this.dueDateLbl.TabIndex = 4;
            this.dueDateLbl.Text = "label3";
            // 
            // borrowDateLbl
            // 
            this.borrowDateLbl.AutoSize = true;
            this.borrowDateLbl.Location = new System.Drawing.Point(369, 216);
            this.borrowDateLbl.Name = "borrowDateLbl";
            this.borrowDateLbl.Size = new System.Drawing.Size(51, 20);
            this.borrowDateLbl.TabIndex = 5;
            this.borrowDateLbl.Text = "label3";
            this.borrowDateLbl.Click += new System.EventHandler(this.borrowDateLbl_Click);
            // 
            // courseCodeLbl
            // 
            this.courseCodeLbl.AutoSize = true;
            this.courseCodeLbl.Location = new System.Drawing.Point(351, 147);
            this.courseCodeLbl.Name = "courseCodeLbl";
            this.courseCodeLbl.Size = new System.Drawing.Size(51, 20);
            this.courseCodeLbl.TabIndex = 6;
            this.courseCodeLbl.Text = "label2";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(312, 179);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(51, 20);
            this.genderLbl.TabIndex = 7;
            this.genderLbl.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Borrower:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Course Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Borrowed: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Due Date: ";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(373, 314);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(103, 42);
            this.returnBtn.TabIndex = 16;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(252, 314);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 42);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // borrowState
            // 
            this.borrowState.AutoSize = true;
            this.borrowState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowState.Location = new System.Drawing.Point(419, 20);
            this.borrowState.Name = "borrowState";
            this.borrowState.Size = new System.Drawing.Size(51, 20);
            this.borrowState.TabIndex = 18;
            this.borrowState.Text = "label6";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Red;
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(253, 327);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(235, 42);
            this.delBtn.TabIndex = 19;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowCardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.borrowState);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.courseCodeLbl);
            this.Controls.Add(this.borrowDateLbl);
            this.Controls.Add(this.dueDateLbl);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.borrowerFNameLbl);
            this.Controls.Add(this.bookPb);
            this.Name = "BorrowCardUserControl";
            this.Size = new System.Drawing.Size(533, 395);
            this.Load += new System.EventHandler(this.BorrowCardUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bookPb;
        private System.Windows.Forms.Label borrowerFNameLbl;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.Label dueDateLbl;
        private System.Windows.Forms.Label borrowDateLbl;
        private System.Windows.Forms.Label courseCodeLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label borrowState;
        private System.Windows.Forms.Button delBtn;
    }
}
