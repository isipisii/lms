namespace LibraryManagementSystem.UserControls
{
    partial class UpcomingDuesUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borrowerLbl = new System.Windows.Forms.Label();
            this.dueDateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookPb)).BeginInit();
            this.SuspendLayout();
            // 
            // bookPb
            // 
            this.bookPb.Location = new System.Drawing.Point(25, 24);
            this.bookPb.Name = "bookPb";
            this.bookPb.Size = new System.Drawing.Size(137, 186);
            this.bookPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPb.TabIndex = 0;
            this.bookPb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title: ";
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLbl.Location = new System.Drawing.Point(192, 65);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(58, 19);
            this.bookTitleLbl.TabIndex = 3;
            this.bookTitleLbl.Text = "label3";
            this.bookTitleLbl.Click += new System.EventHandler(this.bookTitleLbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Borrower:";
            // 
            // borrowerLbl
            // 
            this.borrowerLbl.AutoSize = true;
            this.borrowerLbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLbl.Location = new System.Drawing.Point(192, 114);
            this.borrowerLbl.Name = "borrowerLbl";
            this.borrowerLbl.Size = new System.Drawing.Size(57, 21);
            this.borrowerLbl.TabIndex = 5;
            this.borrowerLbl.Text = "label2";
            this.borrowerLbl.Click += new System.EventHandler(this.borrowerLbl_Click);
            // 
            // dueDateLbl
            // 
            this.dueDateLbl.AutoSize = true;
            this.dueDateLbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLbl.Location = new System.Drawing.Point(192, 167);
            this.dueDateLbl.Name = "dueDateLbl";
            this.dueDateLbl.Size = new System.Drawing.Size(57, 21);
            this.dueDateLbl.TabIndex = 7;
            this.dueDateLbl.Text = "label6";
            this.dueDateLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Due Date:";
            // 
            // UpcomingDuesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dueDateLbl);
            this.Controls.Add(this.borrowerLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookPb);
            this.Name = "UpcomingDuesUserControl";
            this.Size = new System.Drawing.Size(343, 231);
            this.Load += new System.EventHandler(this.UpcomingDuesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bookPb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label borrowerLbl;
        private System.Windows.Forms.Label dueDateLbl;
        private System.Windows.Forms.Label label2;
    }
}
