namespace GamersClub
{
    partial class frmAddOrModifyMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrModifyMember));
            this.lblName = new System.Windows.Forms.Label();
            this.lbldateJoined = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblFGenre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.dtpJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExitFormModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lbldateJoined
            // 
            this.lbldateJoined.AutoSize = true;
            this.lbldateJoined.Location = new System.Drawing.Point(93, 162);
            this.lbldateJoined.Name = "lbldateJoined";
            this.lbldateJoined.Size = new System.Drawing.Size(95, 20);
            this.lbldateJoined.TabIndex = 0;
            this.lbldateJoined.Text = "Date Joined";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(93, 112);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(103, 20);
            this.lblDob.TabIndex = 0;
            this.lblDob.Text = "Date of Birth:";
            // 
            // lblFGenre
            // 
            this.lblFGenre.AutoSize = true;
            this.lblFGenre.Location = new System.Drawing.Point(100, 425);
            this.lblFGenre.Name = "lblFGenre";
            this.lblFGenre.Size = new System.Drawing.Size(128, 20);
            this.lblFGenre.TabIndex = 0;
            this.lblFGenre.Text = "Favourite Genre:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 367);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(100, 314);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(97, 267);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(51, 20);
            this.lblRank.TabIndex = 0;
            this.lblRank.Text = "Rank:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(93, 215);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(289, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(289, 264);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(100, 26);
            this.txtRank.TabIndex = 5;
            this.txtRank.Tag = "Rank";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(289, 311);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Tag = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(289, 364);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Tag = "Email";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(289, 419);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 26);
            this.txtGenre.TabIndex = 8;
            this.txtGenre.Tag = "Favourite Genre";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(289, 212);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 26);
            this.txtGender.TabIndex = 4;
            this.txtGender.Tag = "Gender";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(289, 107);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 26);
            this.dtpDob.TabIndex = 2;
            // 
            // dtpJoinedDate
            // 
            this.dtpJoinedDate.Location = new System.Drawing.Point(289, 157);
            this.dtpJoinedDate.Name = "dtpJoinedDate";
            this.dtpJoinedDate.Size = new System.Drawing.Size(200, 26);
            this.dtpJoinedDate.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(97, 515);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(148, 62);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExitFormModify
            // 
            this.btnExitFormModify.Location = new System.Drawing.Point(438, 515);
            this.btnExitFormModify.Name = "btnExitFormModify";
            this.btnExitFormModify.Size = new System.Drawing.Size(148, 62);
            this.btnExitFormModify.TabIndex = 10;
            this.btnExitFormModify.Text = "E&xit";
            this.btnExitFormModify.UseVisualStyleBackColor = true;
            // 
            // frmAddOrModifyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.btnExitFormModify);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dtpJoinedDate);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFGenre);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lbldateJoined);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddOrModifyMember";
            this.Text = "frmAddOrModifyMember";
            this.Load += new System.EventHandler(this.frmAddOrModifyMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbldateJoined;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblFGenre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.DateTimePicker dtpJoinedDate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExitFormModify;
    }
}