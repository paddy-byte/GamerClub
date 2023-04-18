using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamersClub
{
    public partial class frmLeaderboard : Form
    {
        List<Member> members = new List<Member>();
        public frmLeaderboard(List<Member> memberList)
        {
            InitializeComponent();
            members = memberList;   
        }

        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            DisplayLeader();
           
            
        }
        private void DisplayLeader()
        {

            dgvLeaderBoard.DataSource = new BindingList<Member>(members.OrderByDescending(m => m.rank).ToList());
            dgvLeaderBoard.EnableHeadersVisualStyles = false;
            dgvLeaderBoard.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvLeaderBoard.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvLeaderBoard.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvLeaderBoard.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dgvLeaderBoard.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // format the first column
            dgvLeaderBoard.Columns[0].HeaderText = "Name";
            dgvLeaderBoard.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvLeaderBoard.Columns[0].Width = 110;




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
