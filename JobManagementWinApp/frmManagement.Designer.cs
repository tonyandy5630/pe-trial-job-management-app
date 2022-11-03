namespace JobManagementWinApp
{
    partial class frmManagement
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
            this.lbCandidateID = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfileShortDesription = new System.Windows.Forms.TextBox();
            this.txtProfileURL = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPositingID = new System.Windows.Forms.TextBox();
            this.dgvCandidateProfile = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCandidateID
            // 
            this.lbCandidateID.AutoSize = true;
            this.lbCandidateID.Location = new System.Drawing.Point(80, 38);
            this.lbCandidateID.Name = "lbCandidateID";
            this.lbCandidateID.Size = new System.Drawing.Size(24, 20);
            this.lbCandidateID.TabIndex = 0;
            this.lbCandidateID.Text = "ID";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(80, 76);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(69, 20);
            this.lbFullname.TabIndex = 1;
            this.lbFullname.Text = "Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProfileShortDescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ProfileURL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthday";
            // 
            // txtProfileShortDesription
            // 
            this.txtProfileShortDesription.Location = new System.Drawing.Point(638, 35);
            this.txtProfileShortDesription.Name = "txtProfileShortDesription";
            this.txtProfileShortDesription.Size = new System.Drawing.Size(157, 27);
            this.txtProfileShortDesription.TabIndex = 5;
            // 
            // txtProfileURL
            // 
            this.txtProfileURL.Location = new System.Drawing.Point(638, 80);
            this.txtProfileURL.Name = "txtProfileURL";
            this.txtProfileURL.Size = new System.Drawing.Size(157, 27);
            this.txtProfileURL.TabIndex = 5;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(191, 35);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.Size = new System.Drawing.Size(166, 27);
            this.txtCandidateID.TabIndex = 5;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(191, 76);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(166, 27);
            this.txtFullname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "PostingID";
            // 
            // txtPositingID
            // 
            this.txtPositingID.Location = new System.Drawing.Point(638, 126);
            this.txtPositingID.Name = "txtPositingID";
            this.txtPositingID.Size = new System.Drawing.Size(157, 27);
            this.txtPositingID.TabIndex = 5;
            // 
            // dgvCandidateProfile
            // 
            this.dgvCandidateProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateProfile.Location = new System.Drawing.Point(-2, 274);
            this.dgvCandidateProfile.Name = "dgvCandidateProfile";
            this.dgvCandidateProfile.RowHeadersWidth = 51;
            this.dgvCandidateProfile.RowTemplate.Height = 29;
            this.dgvCandidateProfile.Size = new System.Drawing.Size(765, 169);
            this.dgvCandidateProfile.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(769, 274);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(769, 324);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(769, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(769, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(505, 207);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(166, 27);
            this.txtSearchName.TabIndex = 5;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(701, 205);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(191, 126);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(250, 27);
            this.dtBirthday.TabIndex = 8;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvCandidateProfile);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.txtPositingID);
            this.Controls.Add(this.txtProfileURL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProfileShortDesription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.lbCandidateID);
            this.Name = "frmManagement";
            this.Text = "frmManagement";
            this.Load += new System.EventHandler(this.frmManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCandidateID;
        private Label lbFullname;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProfileShortDesription;
        private TextBox txtProfileURL;
        private TextBox txtCandidateID;
        private TextBox txtFullname;
        private Label label6;
        private TextBox txtPositingID;
        private DataGridView dgvCandidateProfile;
        private Button btnLoad;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox txtSearchName;
        private Button btnSearch;
        private DateTimePicker dtBirthday;
    }
}