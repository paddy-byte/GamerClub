using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GamersClub
{
    public partial class MessageBoard : Form
    {
        List<Message> messagelist = new List<Message>();

        
        public MessageBoard(List<Message> messages)
        {

            InitializeComponent();
            messagelist = messages;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayMessages()
        {

            dgvMessage.DataSource = new List<Message>(this.messagelist.ToList());
            dgvMessage.EnableHeadersVisualStyles = false;
            dgvMessage.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvMessage.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvMessage.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvMessage.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dgvMessage.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // format the first column
            //dgvMessage.Columns[0].HeaderText = "Message";
            dgvMessage.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMessage.Columns[0].Width = 520;




        }


        private void MessageBoard_Load(object sender, EventArgs e)
        {
            DisplayMessages();

        }
       
        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string newMessage = txtMessage.Text;

                Message m = new Message(newMessage);
                messagelist.Add(m);
                DisplayMessages();
                txtMessage.Clear();
            }

        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtMessage.Text, txtMessage.Tag.ToString());


            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
}
