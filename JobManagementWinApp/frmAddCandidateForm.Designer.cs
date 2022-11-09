namespace JobManagementWinApp
{
    partial class frmAddCandidateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCandidateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfileDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPostingTitle = new System.Windows.Forms.ComboBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCandidateId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate\'s Name";
            // 
            // txtCandidateName
            // 
            this.txtCandidateName.Location = new System.Drawing.Point(223, 82);
            this.txtCandidateName.Name = "txtCandidateName";
            this.txtCandidateName.Size = new System.Drawing.Size(125, 27);
            this.txtCandidateName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birthday";
            // 
            // txtProfileDesc
            // 
            this.txtProfileDesc.Location = new System.Drawing.Point(223, 176);
            this.txtProfileDesc.Name = "txtProfileDesc";
            this.txtProfileDesc.Size = new System.Drawing.Size(125, 27);
            this.txtProfileDesc.TabIndex = 5;
            this.txtProfileDesc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ProfileShortDescription";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(223, 224);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(125, 27);
            this.txtURL.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ProfileURL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posting Title";
            // 
            // comboPostingTitle
            // 
            this.comboPostingTitle.FormattingEnabled = true;
            this.comboPostingTitle.Location = new System.Drawing.Point(223, 269);
            this.comboPostingTitle.Name = "comboPostingTitle";
            this.comboPostingTitle.Size = new System.Drawing.Size(125, 28);
            this.comboPostingTitle.TabIndex = 9;
            // 
            // dtBirthday
            // 
            this.dtBirthday.CustomFormat = "yyyy-mm-dd";
            this.dtBirthday.Location = new System.Drawing.Point(223, 130);
            this.dtBirthday.MaxDate = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            this.dtBirthday.MinDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(246, 27);
            this.dtBirthday.TabIndex = 10;
            this.dtBirthday.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtBirthday.ValueChanged += new System.EventHandler(this.dtBirthday_ValueChanged);
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.Location = new System.Drawing.Point(152, 366);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(94, 29);
            this.btnAddCandidate.TabIndex = 11;
            this.btnAddCandidate.Text = "Add";
            this.btnAddCandidate.UseVisualStyleBackColor = true;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Candidate Id";
            // 
            // txtCandidateId
            // 
            this.txtCandidateId.Location = new System.Drawing.Point(223, 35);
            this.txtCandidateId.Name = "txtCandidateId";
            this.txtCandidateId.Size = new System.Drawing.Size(125, 27);
            this.txtCandidateId.TabIndex = 13;
            // 
            // frmAddCandidateForm
            // 
            this.AcceptButton = this.btnAddCandidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.txtCandidateId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddCandidate);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.comboPostingTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProfileDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCandidateName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCandidateForm";
            this.Text = "frmAddCandidateForm";
            this.Load += new System.EventHandler(this.frmAddCandidateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCandidateName;
        private Label label2;
        private TextBox txtProfileDesc;
        private Label label3;
        private TextBox txtURL;
        private Label label4;
        private Label label5;
        private ComboBox comboPostingTitle;
        private DateTimePicker dtBirthday;
        private Button btnAddCandidate;
        private Label label6;
        private TextBox txtCandidateId;
    }
}