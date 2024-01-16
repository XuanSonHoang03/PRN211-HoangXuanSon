using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        public MemberObject MemberObject { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string email = tbUsername.Text.Trim();
            string password = tbPasword.Text.Trim();
            MemberObject = memberRepository.GetMemberByEmailPassword(email, password);
            if (MemberObject != null && email.Equals("admin@fstore.com"))
            {
                frmMemberManagerment frmMemberManagerment = new frmMemberManagerment();
                this.Hide();
                frmMemberManagerment.ShowDialog();
                this.Show();
            } else if(MemberObject != null)
            {
                frmMember frmMember = new frmMember()
                {
                    MemberObject = MemberObject,
                    InsertOrUpdate = true
                };
                this.Hide();
                frmMember.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}