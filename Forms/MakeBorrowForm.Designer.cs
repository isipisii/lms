namespace LibraryManagementSystem.Forms
{
    partial class MakeBorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeBorrowForm));
            this.bookPb = new System.Windows.Forms.PictureBox();
            this.modalText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.borrowerLbl = new System.Windows.Forms.Label();
            this.dateBorrowedPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.showStudentBtn = new System.Windows.Forms.Button();
            this.showBooksBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bookPb
            // 
            this.bookPb.Location = new System.Drawing.Point(31, 86);
            this.bookPb.Name = "bookPb";
            this.bookPb.Size = new System.Drawing.Size(335, 405);
            this.bookPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPb.TabIndex = 0;
            this.bookPb.TabStop = false;
            // 
            // modalText
            // 
            this.modalText.AutoSize = true;
            this.modalText.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modalText.Location = new System.Drawing.Point(26, 29);
            this.modalText.Name = "modalText";
            this.modalText.Size = new System.Drawing.Size(217, 30);
            this.modalText.TabIndex = 30;
            this.modalText.Text = "Create a Borrow";
            this.modalText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Borrower:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Book\'s Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLbl.Location = new System.Drawing.Point(164, 512);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(47, 25);
            this.bookTitleLbl.TabIndex = 35;
            this.bookTitleLbl.Text = "-----";
            // 
            // borrowerLbl
            // 
            this.borrowerLbl.AutoSize = true;
            this.borrowerLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLbl.Location = new System.Drawing.Point(146, 553);
            this.borrowerLbl.Name = "borrowerLbl";
            this.borrowerLbl.Size = new System.Drawing.Size(47, 25);
            this.borrowerLbl.TabIndex = 36;
            this.borrowerLbl.Text = "-----";
            // 
            // dateBorrowedPicker
            // 
            this.dateBorrowedPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBorrowedPicker.Location = new System.Drawing.Point(428, 165);
            this.dateBorrowedPicker.Name = "dateBorrowedPicker";
            this.dateBorrowedPicker.Size = new System.Drawing.Size(352, 30);
            this.dateBorrowedPicker.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date Borrowed:";
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDatePicker.Location = new System.Drawing.Point(428, 246);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(352, 30);
            this.dueDatePicker.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Due Date:";
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.borrowBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Location = new System.Drawing.Point(428, 502);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(352, 54);
            this.borrowBtn.TabIndex = 48;
            this.borrowBtn.Text = "Borrow Book";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // showStudentBtn
            // 
            this.showStudentBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.showStudentBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentBtn.ForeColor = System.Drawing.Color.White;
            this.showStudentBtn.Image = ((System.Drawing.Image)(resources.GetObject("showStudentBtn.Image")));
            this.showStudentBtn.Location = new System.Drawing.Point(428, 318);
            this.showStudentBtn.Name = "showStudentBtn";
            this.showStudentBtn.Size = new System.Drawing.Size(176, 144);
            this.showStudentBtn.TabIndex = 49;
            this.showStudentBtn.Text = "Choose Student";
            this.showStudentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showStudentBtn.UseVisualStyleBackColor = false;
            this.showStudentBtn.Click += new System.EventHandler(this.showStudentBtn_Click);
            // 
            // showBooksBtn
            // 
            this.showBooksBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.showBooksBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBooksBtn.ForeColor = System.Drawing.Color.White;
            this.showBooksBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBooksBtn.Image")));
            this.showBooksBtn.Location = new System.Drawing.Point(610, 318);
            this.showBooksBtn.Name = "showBooksBtn";
            this.showBooksBtn.Size = new System.Drawing.Size(170, 144);
            this.showBooksBtn.TabIndex = 50;
            this.showBooksBtn.Text = "Choose Book";
            this.showBooksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showBooksBtn.UseVisualStyleBackColor = false;
            this.showBooksBtn.Click += new System.EventHandler(this.showBooksBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(801, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(428, 506);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(352, 54);
            this.updateBtn.TabIndex = 52;
            this.updateBtn.Text = "Update Borrow";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // MakeBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 608);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showBooksBtn);
            this.Controls.Add(this.showStudentBtn);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateBorrowedPicker);
            this.Controls.Add(this.borrowerLbl);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modalText);
            this.Controls.Add(this.bookPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeBorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeBorrowForm";
            this.Load += new System.EventHandler(this.MakeBorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bookPb;
        private System.Windows.Forms.Label modalText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.Label borrowerLbl;
        private System.Windows.Forms.DateTimePicker dateBorrowedPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button showStudentBtn;
        private System.Windows.Forms.Button showBooksBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button updateBtn;
    }
}