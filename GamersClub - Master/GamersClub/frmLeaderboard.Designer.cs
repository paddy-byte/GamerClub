namespace GamersClub
{
    partial class frmLeaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderboard));
            this.dgvLeaderBoard = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaderBoard
            // 
            this.dgvLeaderBoard.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLeaderBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderBoard.Location = new System.Drawing.Point(1, 1);
            this.dgvLeaderBoard.Name = "dgvLeaderBoard";
            this.dgvLeaderBoard.RowHeadersWidth = 62;
            this.dgvLeaderBoard.RowTemplate.Height = 28;
            this.dgvLeaderBoard.Size = new System.Drawing.Size(947, 417);
            this.dgvLeaderBoard.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(756, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(948, 492);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvLeaderBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLeaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.frmLeaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaderBoard;
        private System.Windows.Forms.Button btnExit;
    }
}