namespace GitHubApp
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAllOrgMembers = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnUploadAWS = new System.Windows.Forms.Button();
            this.lblMessageB = new System.Windows.Forms.Label();
            this.txtboxGitHubToken = new System.Windows.Forms.TextBox();
            this.txtboxAWS_AccessKey = new System.Windows.Forms.TextBox();
            this.txtboxAWS_SecretKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxSenderAddress = new System.Windows.Forms.TextBox();
            this.txtboxSMTP_Host = new System.Windows.Forms.TextBox();
            this.txtboxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxEmailPassword = new System.Windows.Forms.TextBox();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgMemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(329, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(454, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GitHub Organization Member Scanner";
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(232, 224);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(140, 22);
            this.txtboxInput.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 224);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(202, 34);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search a GitHub Organization:\r\n(e.g., \'Microsoft\' or \'Google\')";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(392, 224);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orgMemberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 348);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(632, 487);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(32, 281);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 5;
            // 
            // lblAllOrgMembers
            // 
            this.lblAllOrgMembers.AutoSize = true;
            this.lblAllOrgMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllOrgMembers.Location = new System.Drawing.Point(29, 326);
            this.lblAllOrgMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllOrgMembers.Name = "lblAllOrgMembers";
            this.lblAllOrgMembers.Size = new System.Drawing.Size(291, 17);
            this.lblAllOrgMembers.TabIndex = 6;
            this.lblAllOrgMembers.Text = "All public members of the organization:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.orgMemberBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(684, 348);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(433, 487);
            this.dataGridView2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Members without names that can be contacted:";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(688, 224);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(171, 49);
            this.btnSendEmail.TabIndex = 9;
            this.btnSendEmail.Text = "Email Nameless Members";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnUploadAWS
            // 
            this.btnUploadAWS.Location = new System.Drawing.Point(867, 224);
            this.btnUploadAWS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadAWS.Name = "btnUploadAWS";
            this.btnUploadAWS.Size = new System.Drawing.Size(171, 49);
            this.btnUploadAWS.TabIndex = 10;
            this.btnUploadAWS.Text = "Upload Nameless Member List to AWS";
            this.btnUploadAWS.UseVisualStyleBackColor = true;
            this.btnUploadAWS.Click += new System.EventHandler(this.btnUploadAWS_Click);
            // 
            // lblMessageB
            // 
            this.lblMessageB.AutoSize = true;
            this.lblMessageB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageB.ForeColor = System.Drawing.Color.Green;
            this.lblMessageB.Location = new System.Drawing.Point(688, 282);
            this.lblMessageB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageB.Name = "lblMessageB";
            this.lblMessageB.Size = new System.Drawing.Size(0, 17);
            this.lblMessageB.TabIndex = 11;
            // 
            // txtboxGitHubToken
            // 
            this.txtboxGitHubToken.Location = new System.Drawing.Point(159, 101);
            this.txtboxGitHubToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxGitHubToken.Name = "txtboxGitHubToken";
            this.txtboxGitHubToken.Size = new System.Drawing.Size(352, 22);
            this.txtboxGitHubToken.TabIndex = 12;
            // 
            // txtboxAWS_AccessKey
            // 
            this.txtboxAWS_AccessKey.Location = new System.Drawing.Point(159, 133);
            this.txtboxAWS_AccessKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxAWS_AccessKey.Name = "txtboxAWS_AccessKey";
            this.txtboxAWS_AccessKey.Size = new System.Drawing.Size(352, 22);
            this.txtboxAWS_AccessKey.TabIndex = 13;
            // 
            // txtboxAWS_SecretKey
            // 
            this.txtboxAWS_SecretKey.Location = new System.Drawing.Point(159, 165);
            this.txtboxAWS_SecretKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxAWS_SecretKey.Name = "txtboxAWS_SecretKey";
            this.txtboxAWS_SecretKey.Size = new System.Drawing.Size(352, 22);
            this.txtboxAWS_SecretKey.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "GitHub Token:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "AWS Access Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "AWS Secret Key:";
            // 
            // txtboxSenderAddress
            // 
            this.txtboxSenderAddress.Location = new System.Drawing.Point(803, 101);
            this.txtboxSenderAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSenderAddress.Name = "txtboxSenderAddress";
            this.txtboxSenderAddress.Size = new System.Drawing.Size(169, 22);
            this.txtboxSenderAddress.TabIndex = 18;
            // 
            // txtboxSMTP_Host
            // 
            this.txtboxSMTP_Host.Location = new System.Drawing.Point(803, 133);
            this.txtboxSMTP_Host.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSMTP_Host.Name = "txtboxSMTP_Host";
            this.txtboxSMTP_Host.Size = new System.Drawing.Size(169, 22);
            this.txtboxSMTP_Host.TabIndex = 19;
            // 
            // txtboxPort
            // 
            this.txtboxPort.Location = new System.Drawing.Point(1028, 133);
            this.txtboxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPort.Name = "txtboxPort";
            this.txtboxPort.Size = new System.Drawing.Size(55, 22);
            this.txtboxPort.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(688, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sender Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(688, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "SMTP Host:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(981, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(688, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Enter Email host information for Email functionality:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(25, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter credentials for app functionality:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(688, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Password:";
            // 
            // txtboxEmailPassword
            // 
            this.txtboxEmailPassword.Location = new System.Drawing.Point(803, 165);
            this.txtboxEmailPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxEmailPassword.Name = "txtboxEmailPassword";
            this.txtboxEmailPassword.Size = new System.Drawing.Size(169, 22);
            this.txtboxEmailPassword.TabIndex = 27;
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            this.loginDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Width = 180;
            // 
            // orgMemberBindingSource1
            // 
            this.orgMemberBindingSource1.DataSource = typeof(GitHubApp.OrgMember);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 180;
            // 
            // orgMemberBindingSource
            // 
            this.orgMemberBindingSource.DataSource = typeof(GitHubApp.OrgMember);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 862);
            this.Controls.Add(this.txtboxEmailPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxPort);
            this.Controls.Add(this.txtboxSMTP_Host);
            this.Controls.Add(this.txtboxSenderAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxAWS_SecretKey);
            this.Controls.Add(this.txtboxAWS_AccessKey);
            this.Controls.Add(this.txtboxGitHubToken);
            this.Controls.Add(this.lblMessageB);
            this.Controls.Add(this.btnUploadAWS);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblAllOrgMembers);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxInput);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHubApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgMemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orgMemberBindingSource;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAllOrgMembers;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource orgMemberBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnUploadAWS;
        private System.Windows.Forms.Label lblMessageB;
        private System.Windows.Forms.TextBox txtboxGitHubToken;
        private System.Windows.Forms.TextBox txtboxAWS_AccessKey;
        private System.Windows.Forms.TextBox txtboxAWS_SecretKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxSenderAddress;
        private System.Windows.Forms.TextBox txtboxSMTP_Host;
        private System.Windows.Forms.TextBox txtboxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtboxEmailPassword;
    }
}

