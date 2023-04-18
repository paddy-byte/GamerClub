namespace GamersClub
{
    partial class MessageBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoard));
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMessage
            // 
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Location = new System.Drawing.Point(3, 1);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.RowHeadersWidth = 62;
            this.dgvMessage.RowTemplate.Height = 28;
            this.dgvMessage.Size = new System.Drawing.Size(890, 436);
            this.dgvMessage.TabIndex = 0;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(40, 475);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(131, 38);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(728, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(271, 481);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(340, 26);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Tag = "MessageBox";
            // 
            // MessageBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 592);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.dgvMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoard";
            this.Text = "MessageBoard";
            this.Load += new System.EventHandler(this.MessageBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMessage;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMessage;
    }
}