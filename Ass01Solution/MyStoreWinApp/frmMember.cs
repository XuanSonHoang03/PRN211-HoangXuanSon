using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMember : Form
    {
        public MemberObject MemberObject { get; set; }
        public IMemberRepository MemberRepository = new MemberRepository();
        internal IMemberRepository memberRepository;

        public bool InsertOrUpdate { get; set; } // true: update, false: insert
        public bool ValidAdmin { get; set; }
        public frmMember()
        {
            InitializeComponent();
        }

        private void btSaveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    MemberObject.MemberName = tbName.Text;
                    MemberObject.Email = tbEmail.Text;
                    MemberObject.Password = tbPassword.Text;
                    MemberObject.City = tbCity.Text;
                    MemberObject.Country = tbCountry.Text;

                    MemberRepository.UpdateMember(MemberObject);
                    MessageBox.Show("Update successfully");
                    Close();
                }
                else if (!InsertOrUpdate)
                {
                    var memNew = new MemberObject()
                    {
                        MemberID = int.Parse(tbID.Text),
                        MemberName = tbName.Text,
                        Email = tbEmail.Text,
                        Password = tbPassword.Text,
                        City = tbCity.Text,
                        Country = tbCountry.Text


                    };

                    MemberRepository.InsertMember(memNew);
                    MessageBox.Show("Insert successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid");
            }
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            try
            {
                if (ValidAdmin)
                {
                    tbEmail.Enabled = false;
                    tbPassword.Enabled = false;
                    tbID.Enabled = false;
                }
                if (InsertOrUpdate)
                {
                    tbID.Enabled = false;
                    tbID.Text = MemberObject.MemberID.ToString();
                    tbName.Text = MemberObject.MemberName;
                    tbEmail.Text = MemberObject.Email;
                    tbPassword.Text = MemberObject.Password;
                    tbCity.Text = MemberObject.City;
                    tbCountry.Text = MemberObject.Country;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid information");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
