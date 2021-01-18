namespace Lab4
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
            this.gradepointlabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.GPAtextbox = new System.Windows.Forms.TextBox();
            this.scoretextbox = new System.Windows.Forms.TextBox();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.acceptlbl = new System.Windows.Forms.Label();
            this.acceptcount = new System.Windows.Forms.Label();
            this.rejectlbl = new System.Windows.Forms.Label();
            this.rejectcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradepointlabel
            // 
            this.gradepointlabel.AutoSize = true;
            this.gradepointlabel.Location = new System.Drawing.Point(58, 60);
            this.gradepointlabel.Name = "gradepointlabel";
            this.gradepointlabel.Size = new System.Drawing.Size(90, 13);
            this.gradepointlabel.TabIndex = 0;
            this.gradepointlabel.Text = "High School GPA";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(58, 106);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(109, 13);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "Admission Test Score";
            // 
            // GPAtextbox
            // 
            this.GPAtextbox.Location = new System.Drawing.Point(179, 60);
            this.GPAtextbox.Name = "GPAtextbox";
            this.GPAtextbox.Size = new System.Drawing.Size(100, 20);
            this.GPAtextbox.TabIndex = 2;
            // 
            // scoretextbox
            // 
            this.scoretextbox.Location = new System.Drawing.Point(179, 103);
            this.scoretextbox.Name = "scoretextbox";
            this.scoretextbox.Size = new System.Drawing.Size(100, 20);
            this.scoretextbox.TabIndex = 3;
            // 
            // calculatebtn
            // 
            this.calculatebtn.Location = new System.Drawing.Point(126, 160);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(93, 21);
            this.calculatebtn.TabIndex = 4;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // acceptlbl
            // 
            this.acceptlbl.AutoSize = true;
            this.acceptlbl.Location = new System.Drawing.Point(70, 210);
            this.acceptlbl.Name = "acceptlbl";
            this.acceptlbl.Size = new System.Drawing.Size(75, 13);
            this.acceptlbl.TabIndex = 5;
            this.acceptlbl.Text = "Accept Count:";
            // 
            // acceptcount
            // 
            this.acceptcount.Location = new System.Drawing.Point(151, 209);
            this.acceptcount.Name = "acceptcount";
            this.acceptcount.Size = new System.Drawing.Size(68, 23);
            this.acceptcount.TabIndex = 6;
            // 
            // rejectlbl
            // 
            this.rejectlbl.AutoSize = true;
            this.rejectlbl.Location = new System.Drawing.Point(74, 260);
            this.rejectlbl.Name = "rejectlbl";
            this.rejectlbl.Size = new System.Drawing.Size(72, 13);
            this.rejectlbl.TabIndex = 7;
            this.rejectlbl.Text = "Reject Count:";
            // 
            // rejectcount
            // 
            this.rejectcount.Location = new System.Drawing.Point(151, 258);
            this.rejectcount.Name = "rejectcount";
            this.rejectcount.Size = new System.Drawing.Size(68, 23);
            this.rejectcount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculatebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.rejectcount);
            this.Controls.Add(this.rejectlbl);
            this.Controls.Add(this.acceptcount);
            this.Controls.Add(this.acceptlbl);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.scoretextbox);
            this.Controls.Add(this.GPAtextbox);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.gradepointlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradepointlabel;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.TextBox GPAtextbox;
        private System.Windows.Forms.TextBox scoretextbox;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Label acceptlbl;
        private System.Windows.Forms.Label acceptcount;
        private System.Windows.Forms.Label rejectlbl;
        private System.Windows.Forms.Label rejectcount;
    }
}

