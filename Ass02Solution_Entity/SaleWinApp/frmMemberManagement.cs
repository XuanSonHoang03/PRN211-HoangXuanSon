using BusinessObject.Models;
using DataAccess.Repository.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMemberManagement : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();

        public List<Member> ListMembers;
        public List<Member> ListSearchMember;

        BindingSource bindingSources;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            dgvMember.CellDoubleClick += DgvMember_CellDoubleClick;
        }

        private void DgvMember_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Update Member",
                memberRepository = memberRepository,
                member = ListMembers[dgvMember.CurrentRow.Index],
                InsertOrUpdate = true,
                isAdmin = true
            };
            frmMember.ShowDialog();
            this.Show();
        }


        private void LoadMemberList()
        {
            var member = memberRepository.GetMembers();
            this.ListMembers = member.ToList();
            try
            {
                bindingSources = new BindingSource();
                bindingSources.DataSource = ListMembers;

                tbCity.DataBindings.Clear();
                tbCompany.DataBindings.Clear();
                tbCountry.DataBindings.Clear();
                tbEmail.DataBindings.Clear();
                tbID.DataBindings.Clear();
                tbPassword.DataBindings.Clear();

                tbCity.DataBindings.Add("Text", bindingSources, "City");
                tbCompany.DataBindings.Add("Text", bindingSources, "CompanyName");
                tbCountry.DataBindings.Add("Text", bindingSources, "Country");
                tbEmail.DataBindings.Add("Text", bindingSources, "Email");
                tbID.DataBindings.Add("Text", bindingSources, "MemberId");
                tbPassword.DataBindings.Add("Text", bindingSources, "Password");

                dgvMember.DataSource = bindingSources;

                if (member == null)
                {
                    btNew.Enabled = false;
                    btDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Add Member",
                memberRepository = memberRepository,
                InsertOrUpdate = false
            };
            frmMember.ShowDialog();
            this.Show();
        }
    }
}
