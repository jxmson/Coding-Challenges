namespace Christmas_Gift
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
            this.btnDone = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ChkBook = new System.Windows.Forms.CheckBox();
            this.ChkLego = new System.Windows.Forms.CheckBox();
            this.ChkVoucher = new System.Windows.Forms.CheckBox();
            this.radBicycle = new System.Windows.Forms.RadioButton();
            this.radBarbie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPlay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(18, 336);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(123, 336);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // ChkBook
            // 
            this.ChkBook.AutoSize = true;
            this.ChkBook.Location = new System.Drawing.Point(11, 54);
            this.ChkBook.Name = "ChkBook";
            this.ChkBook.Size = new System.Drawing.Size(110, 17);
            this.ChkBook.TabIndex = 2;
            this.ChkBook.Text = "Harry Potter Book";
            this.ChkBook.UseVisualStyleBackColor = true;
            // 
            // ChkLego
            // 
            this.ChkLego.AutoSize = true;
            this.ChkLego.Location = new System.Drawing.Point(11, 77);
            this.ChkLego.Name = "ChkLego";
            this.ChkLego.Size = new System.Drawing.Size(94, 17);
            this.ChkLego.TabIndex = 3;
            this.ChkLego.Text = "20 piece Lego";
            this.ChkLego.UseVisualStyleBackColor = true;
            // 
            // ChkVoucher
            // 
            this.ChkVoucher.AutoSize = true;
            this.ChkVoucher.Location = new System.Drawing.Point(11, 31);
            this.ChkVoucher.Name = "ChkVoucher";
            this.ChkVoucher.Size = new System.Drawing.Size(138, 17);
            this.ChkVoucher.TabIndex = 4;
            this.ChkVoucher.Text = "Movie gift voucher for 2";
            this.ChkVoucher.UseVisualStyleBackColor = true;
            // 
            // radBicycle
            // 
            this.radBicycle.AutoSize = true;
            this.radBicycle.Location = new System.Drawing.Point(6, 31);
            this.radBicycle.Name = "radBicycle";
            this.radBicycle.Size = new System.Drawing.Size(59, 17);
            this.radBicycle.TabIndex = 5;
            this.radBicycle.TabStop = true;
            this.radBicycle.Text = "Bicycle";
            this.radBicycle.UseVisualStyleBackColor = true;
            // 
            // radBarbie
            // 
            this.radBarbie.AutoSize = true;
            this.radBarbie.Location = new System.Drawing.Point(6, 54);
            this.radBarbie.Name = "radBarbie";
            this.radBarbie.Size = new System.Drawing.Size(76, 17);
            this.radBarbie.TabIndex = 6;
            this.radBarbie.TabStop = true;
            this.radBarbie.Text = "Barbie Doll";
            this.radBarbie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPlay);
            this.groupBox1.Controls.Add(this.radBicycle);
            this.groupBox1.Controls.Add(this.radBarbie);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category A";
            // 
            // radPlay
            // 
            this.radPlay.AutoSize = true;
            this.radPlay.Location = new System.Drawing.Point(6, 77);
            this.radPlay.Name = "radPlay";
            this.radPlay.Size = new System.Drawing.Size(76, 17);
            this.radPlay.TabIndex = 7;
            this.radPlay.TabStop = true;
            this.radPlay.Text = "Playstation";
            this.radPlay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkLego);
            this.groupBox2.Controls.Add(this.ChkBook);
            this.groupBox2.Controls.Add(this.ChkVoucher);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Only pick 2 gifts from this category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Only pick 1 gift from this category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnDone);
            this.Name = "Form1";
            this.Text = "Christmas Gift";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.CheckBox ChkBook;
        private System.Windows.Forms.CheckBox ChkLego;
        private System.Windows.Forms.CheckBox ChkVoucher;
        private System.Windows.Forms.RadioButton radBicycle;
        private System.Windows.Forms.RadioButton radBarbie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

