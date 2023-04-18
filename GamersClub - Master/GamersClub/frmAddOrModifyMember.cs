using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GamersClub
{
    public partial class frmAddOrModifyMember : Form
    {
        public Member Member { get; set; }
        public bool AddMember { get; set; }
        public frmAddOrModifyMember()
        {
            InitializeComponent();
        }

        private void frmAddOrModifyMember_Load(object sender, EventArgs e)
        {
            if (AddMember)
            {
                this.Text = "Add Member";
                txtName.ReadOnly = false;
            }
            else
            {
                this.Text = "Modify Member";
                txtName.ReadOnly = true;   // can't change existing name
               this.DisplayMember();
            }
        }
        private void DisplayMember()
        {
            txtName.Text = Member.name;
            txtGender.Text = Member.gender.ToLower();
            txtRank.Text = Member.rank.ToString();
            txtAddress.Text = Member.address;
            txtEmail.Text = Member.email;
            txtGenre.Text = Member.favouriteGenre;
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtGender.Text, txtGender.ToString());
            errorMessage += Validator.IsPresent(txtAddress.Text, txtAddress.Tag.ToString());
            errorMessage += Validator.IsInt32(txtRank.Text, txtRank.Tag.ToString());
            errorMessage += Validator.IsPresent(txtEmail.Text, txtEmail.Tag.ToString());
            errorMessage += Validator.IsPresent(txtGenre.Text, txtGenre.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void LoadMemberData()
        {
            Member.name = txtName.Text;
            Member.DOB = Convert.ToDateTime(dtpDob.Text);
            Member.dateJoined = Convert.ToDateTime(dtpJoinedDate.Text);
            Member.gender = txtGender.Text.ToLower();
            Member.rank=Convert.ToInt32(txtRank.Text);
            Member.email = txtEmail.Text;
            Member.address = txtAddress.Text;
            Member.favouriteGenre = txtGenre.Text;
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddMember)
                {
                    // initialize the Product property with new Products object
                    this.Member = new Member();
                }
                this.LoadMemberData();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
