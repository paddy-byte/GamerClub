using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GamersClub
{
    public partial class Form1 : Form
    {
        List<Member> memberList = new List<Member>();
        List<Member> temp = new List<Member>();
        List<Message> messages = new List<Message>();
        private Member selectedMember;
        public Form1()
        {
            MessageData();
            loadDataToList();
            InitializeComponent();
        }
        private void loadDataToList()
        {

            Member m1 = new Member("Patrick Davis", DateTime.Parse("1985/03/17"), DateTime.Parse("2022/04/05"), "male", 10, "Ennistymon,Co clare", "paChef@gmail.com", "RPG");
            Member m2 = new Member("John Wick", DateTime.Parse("1980/07/12"), DateTime.Parse("2021/03/05"), "male", 9, "Glennamaddy,Co Roscommon", "matrix@gmail.com", "FPS");
            Member m3 = new Member("Jessica Rabbit", DateTime.Parse("2000/03/03"), DateTime.Parse("2022/12/03"), "female", 6, "Moi Ross,Co Limeerick", "Wheresroger@gmail.com", "BeatemUp");
            Member m4 = new Member("Mary Shelly", DateTime.Parse("2018/09/27"), DateTime.Parse("2021/02/18"), "female", 7, "Oranmore,Co Galway", "brideoffrank@gmail.com", "Horror");
            Member m5 = new Member("Arnold Schwart", DateTime.Parse("2002/07/07"), DateTime.Parse("2023/01/10"), "male", 3, "Birr,Co Offaly", "olympia@gmail.com", "Animal crossing");
            Member m6 = new Member("Jason statham", DateTime.Parse("1999/10/14"), DateTime.Parse("2020/06/06"), "male", 8, "Killybegs,Co Donegal", "baldy@gmail.com", "BeatemUp");
            Member m7 = new Member("Megan fox", DateTime.Parse("2001/03/18"), DateTime.Parse("2021/05/03"), "female", 10, "Ennis,Co clare", "fifthturtle@gmail.com", "Driving");
            Member m8 = new Member("Johnny Depp", DateTime.Parse("1990/12/19"), DateTime.Parse("2023/01/01"), "male", 4, "Tallaght,Co Dublin", "pirate@gmail.com", "TPS");
            Member m9 = new Member("Amber Heard", DateTime.Parse("2002/03/16"), DateTime.Parse("2022/11/12"), "female", 1, "Westport,Co Mayo", "aturd@gmail.com", "Open world");
            Member m10 = new Member("Tony Stark", DateTime.Parse("1998/08/10"), DateTime.Parse("2021/06/22"), "male", 5, "Gorey,Co Wexford", "ironman@gmail.com", "RPG");

            memberList.Add(m1);
            memberList.Add(m2);
            memberList.Add(m3);
            memberList.Add(m4);
            memberList.Add(m5);
            memberList.Add(m6);
            memberList.Add(m7);
            memberList.Add(m8);
            memberList.Add(m9);
            memberList.Add(m10);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayMember();
        }
        private void DisplayMember()
        {
            dgvMember.Columns.Clear();
            dgvMember.DataSource = new BindingList<Member>(this.memberList.ToList());

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvMember.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvMember.Columns.Add(deleteColumn);

            // format the column header
            dgvMember.EnableHeadersVisualStyles = false;
            dgvMember.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvMember.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvMember.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvMember.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // format the first column
            dgvMember.Columns[0].HeaderText = "Name";
            dgvMember.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[0].Width = 110;

            // format the second column
            dgvMember.Columns[1].HeaderText = "Date of Birth";
            dgvMember.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[1].Width = 90;

            // format the third column
            dgvMember.Columns[2].HeaderText = "Date Joined";
            dgvMember.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[2].Width = 90;
            dgvMember.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the forth column
            dgvMember.Columns[3].HeaderText = "Gender";
            dgvMember.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[3].Width = 90;
            dgvMember.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the fifth column
            dgvMember.Columns[4].HeaderText = "Rank";
            dgvMember.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[4].Width = 90;
            dgvMember.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the sixth column
            dgvMember.Columns[5].HeaderText = "Address";
            dgvMember.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[5].Width = 200;
            dgvMember.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the seventh column
            dgvMember.Columns[6].HeaderText = "E-mail";
            dgvMember.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[6].Width = 180;
            dgvMember.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the eighth column
            dgvMember.Columns[7].HeaderText = "Favourit Genre";
            dgvMember.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[7].Width = 110;
            dgvMember.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the ninth column
            dgvMember.Columns[8].HeaderText = "Modify";
            dgvMember.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[8].Width = 110;
            dgvMember.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the tenth column
            dgvMember.Columns[9].HeaderText = "Delete";
            dgvMember.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMember.Columns[9].Width = 110;
            dgvMember.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void DeleteMember()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedMember.name.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                    if (memberList.Remove(selectedMember))
                    {
                        DisplayMember();
                    }

                

               
            }
        }

        private Member GetMember(string MemName)
        {
            foreach (Member m in memberList)
            {
                if (m.name.Equals(MemName))
                {
                    return m;
                }
                else if(m.gender.Equals(MemName)) { return m;}
               
               
            }
          
            return null;

        }
        

        private void ModifyMember(int indexOfOld)
        {

            var oldMember = new Member
            {
                name = selectedMember.name,
                DOB = selectedMember.DOB,
                dateJoined = selectedMember.dateJoined,
                gender = selectedMember.gender,
                rank = selectedMember.rank,
                address = selectedMember.address,
                email = selectedMember.email,
                favouriteGenre = selectedMember.favouriteGenre
            };
            frmAddOrModifyMember addModifyMemberForm = new frmAddOrModifyMember()
            {
                AddMember = false,
                Member = selectedMember
            };
            DialogResult result = addModifyMemberForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                    this.memberList[indexOfOld] = selectedMember;
                DisplayMember();
               
            }

        }
        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addModifyMemberForm = new frmAddOrModifyMember()
            {
                AddMember = true
            };
            DialogResult result = addModifyMemberForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                    selectedMember = addModifyMemberForm.Member;
                    this.memberList.Add(selectedMember);
                    DisplayMember();  
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Modify and Delete button columns
            const int ModifyIndex = 8;
            const int DeleteIndex = 9;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string memName = dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedMember = GetMember(memName);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyMember(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteMember();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            string search=txtSearch.Text;
            selectedMember = GetMember(search);
            foreach (Member m in memberList)
            {
                if (m.gender == search)
                {
                    temp.Add(m);
                }
            }
            if (GetMember(search)!= null) 
            {
                temp.Add(selectedMember);
                dgvMember.DataSource = new BindingList<Member>(this.temp.ToList());
               
            }
            else
            {
                MessageBox.Show($"Not found?",
                "Name not in table", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
           



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length > 1)
            {   temp.Clear();
                dgvMember.DataSource = new BindingList<Member>(this.memberList.ToList());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click_1(object sender, EventArgs e)
        {
            string copy = txtSearch.Text;
            selectedMember = GetMember(copy);
            if (GetMember(copy) != null)
            {
                memberList.Add(selectedMember);
                dgvMember.DataSource = new BindingList<Member>(this.memberList.ToList());
            }
            else
            {
                MessageBox.Show($"Not found?",
                "Name not in table", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by name or gender...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search by name or gender...";
            }
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            frmLeaderboard leaderboard = new frmLeaderboard(memberList);
            DialogResult selectedButton = leaderboard.ShowDialog();
        }

        private void btnMessageBoard_Click(object sender, EventArgs e)
        {
            MessageBoard messageBoard = new MessageBoard(messages);
            DialogResult selectedButton = messageBoard.ShowDialog();
        }
        private void MessageData()
        {
            Message m1 = new Message("hello");
            Message m2 = new Message("Have you logged on yet John Wick?");
            Message m3 = new Message("That Patrick needs to be knocked down from the leaderboard");
            Message m4 = new Message("Liverpool, Liverpool");
            Message m5 = new Message("Kick out the scousers");
            Message m6 = new Message("who's seen the mario movie yet?");
            Message m7 = new Message("God of War is insane!");

            messages.Add(m1);
            messages.Add(m2);
            messages.Add(m3);
            messages.Add(m4);
            messages.Add(m5);
            messages.Add(m6);
            messages.Add(m7);
        }
    }
}
