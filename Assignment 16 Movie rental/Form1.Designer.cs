
namespace Assignment_16_Movie_rental
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.MoviePicker = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieLengthLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieAvailableLabel = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Coral;
            this.LabelTitle.Font = new System.Drawing.Font("Old English Text MT", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Black;
            this.LabelTitle.Location = new System.Drawing.Point(12, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(215, 46);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Cat Carnivale";
            // 
            // MoviePicker
            // 
            this.MoviePicker.FormattingEnabled = true;
            this.MoviePicker.Location = new System.Drawing.Point(12, 54);
            this.MoviePicker.Name = "MoviePicker";
            this.MoviePicker.Size = new System.Drawing.Size(225, 21);
            this.MoviePicker.TabIndex = 1;
            this.MoviePicker.SelectedIndexChanged += new System.EventHandler(this.MoviePicker_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.63433F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.36567F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MovieNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MovieLengthLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MovieAvailableLabel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(252, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 164);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name:";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(194, 0);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(35, 13);
            this.MovieNameLabel.TabIndex = 1;
            this.MovieNameLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration:";
            // 
            // MovieLengthLabel
            // 
            this.MovieLengthLabel.AutoSize = true;
            this.MovieLengthLabel.Location = new System.Drawing.Point(194, 57);
            this.MovieLengthLabel.Name = "MovieLengthLabel";
            this.MovieLengthLabel.Size = new System.Drawing.Size(35, 13);
            this.MovieLengthLabel.TabIndex = 3;
            this.MovieLengthLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available:";
            // 
            // MovieAvailableLabel
            // 
            this.MovieAvailableLabel.AutoSize = true;
            this.MovieAvailableLabel.Location = new System.Drawing.Point(194, 114);
            this.MovieAvailableLabel.Name = "MovieAvailableLabel";
            this.MovieAvailableLabel.Size = new System.Drawing.Size(35, 13);
            this.MovieAvailableLabel.TabIndex = 5;
            this.MovieAvailableLabel.Text = "label6";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(252, 210);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(247, 40);
            this.BorrowButton.TabIndex = 3;
            this.BorrowButton.Text = "Borrow";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(505, 210);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(283, 40);
            this.ReturnButton.TabIndex = 4;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(818, 351);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MoviePicker);
            this.Controls.Add(this.LabelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox MoviePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MovieLengthLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MovieAvailableLabel;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}

