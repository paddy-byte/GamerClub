namespace GamersClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnMessageBoard = new System.Windows.Forms.Button();
            this.tabController.SuspendLayout();
            this.tabMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabMember);
            this.tabController.Controls.Add(this.tabEvents);
            this.tabController.Controls.Add(this.tabGames);
            this.tabController.Location = new System.Drawing.Point(5, 2);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1214, 436);
            this.tabController.TabIndex = 0;
            this.tabController.Tag = "Members";
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.dgvMember);
            this.tabMember.Location = new System.Drawing.Point(4, 29);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabMember.Size = new System.Drawing.Size(1206, 403);
            this.tabMember.TabIndex = 0;
            this.tabMember.Text = "Members";
            this.tabMember.UseVisualStyleBackColor = true;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(3, 3);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 62;
            this.dgvMember.RowTemplate.Height = 28;
            this.dgvMember.Size = new System.Drawing.Size(1200, 397);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // tabEvents
            // 
            this.tabEvents.Location = new System.Drawing.Point(4, 29);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(1206, 403);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // tabGames
            // 
            this.tabGames.Location = new System.Drawing.Point(4, 29);
            this.tabGames.Name = "tabGames";
            this.tabGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabGames.Size = new System.Drawing.Size(1206, 403);
            this.tabGames.TabIndex = 2;
            this.tabGames.Text = "Games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 508);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(116, 38);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1093, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(763, 440);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(440, 444);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 26);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search by name or gender...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(279, 440);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(124, 35);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click_1);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLeaderboard.Location = new System.Drawing.Point(12, 440);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(166, 38);
            this.btnLeaderboard.TabIndex = 6;
            this.btnLeaderboard.Text = "V&iew Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnMessageBoard
            // 
            this.btnMessageBoard.Location = new System.Drawing.Point(1043, 440);
            this.btnMessageBoard.Name = "btnMessageBoard";
            this.btnMessageBoard.Size = new System.Drawing.Size(166, 38);
            this.btnMessageBoard.TabIndex = 7;
            this.btnMessageBoard.Text = "Message Board";
            this.btnMessageBoard.UseVisualStyleBackColor = true;
            this.btnMessageBoard.Click += new System.EventHandler(this.btnMessageBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1221, 558);
            this.Controls.Add(this.btnMessageBoard);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.tabController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GamersClub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabController.ResumeLayout(false);
            this.tabMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabMember;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnMessageBoard;
    }
}

