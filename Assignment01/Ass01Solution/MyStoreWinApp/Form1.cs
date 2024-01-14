using DataAccess;
using BussinessObject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BussinessObject;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private readonly string DefaultAdminEmail = "admin@fstore.com";
        private readonly string DefaultAdminPassword = "admin@@";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool checkSession = false;
            List<member> ListMember = DataAccess.MemberDAO.Instance.GetMemberList;

            if (ListMember == null)
            {
                MessageBox.Show("List member is empty");
            }
            else
            {
                string role = cbRole.Text;
                string user = tbUsername.Text;
                string pass = tbPassword.Text;

                if (role == "Admin")
                {
                    if (String.Equals(user, DefaultAdminEmail, StringComparison.OrdinalIgnoreCase) && pass == DefaultAdminPassword)
                    {
                        checkSession = true;
                    }
                }
                else
                {
                    foreach (member mem in ListMember)
                    {
                        if (mem.Email.Equals(user) && mem.Password.Equals(pass))
                        {
                            checkSession = true;
                            break;
                        }
                    }
                }
            }

            if (checkSession)
            {
                frmMemberManagerment frmMemberManagerment = new frmMemberManagerment();
                this.Hide();
                frmMemberManagerment.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password");
            }
        }
    }
}
