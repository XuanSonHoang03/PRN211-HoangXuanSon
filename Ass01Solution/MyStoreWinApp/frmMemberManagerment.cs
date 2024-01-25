using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using DataAccess;
using BusinessObject;

namespace MyStoreWinApp
{
	public partial class frmMemberManagerment : Form
	{
		//interface manage
		public IMemberRepository memberRepository = new MemberRepository();
		//list save all member
		private List<MemberObject> ListStoreMember;
		//list for save item in search function
		private List<MemberObject> ListStoreSearch;
		//take data from List, connect data from list
		BindingSource Binding;
		public frmMemberManagerment()
		{
			InitializeComponent();
		}

		private void frmMemberManagerment_Load(object sender, EventArgs e)
		{
			cbSearch.SelectedIndex = 0;
			cbFilter.SelectedIndex = 0;
			cbCityOrCountry.SelectedIndex = 0;
			LoadMemberList();
			dgvListView.CellDoubleClick += DgvMemberList_CellDoubelClick;
		}

		private void DgvMemberList_CellDoubelClick(object? sender, DataGridViewCellEventArgs e)
		{
			frmMember frmMember = new frmMember()
			{
				Text = "Update Member",
				InsertOrUpdate = true,
				ValidAdmin = true,
				MemberObject = GetMemberObject(),
				MemberRepository = memberRepository
			};
			if (frmMember.ShowDialog() == DialogResult.OK)
			{
				LoadMemberList();
				Binding.Position = Binding.Count - 1;
			}
		}

		private MemberObject GetMemberObject()
		{
			MemberObject member = null;
			try
			{
				member = new MemberObject();

				member.MemberID = int.Parse(tbID.Text);
				member.MemberName = tbName.Text;
				member.Email = tbEmail.Text;
				member.City = tbCity.Text;
				member.Country = tbCountry.Text;

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return member;
		}

		private void LoadMemberList()
		{
			var member = memberRepository.GetListAllMember();
			this.ListStoreMember = member;
			try
			{
				Binding = new BindingSource();
				Binding.DataSource = member;

				tbID.DataBindings.Clear();
				tbName.DataBindings.Clear();
				tbEmail.DataBindings.Clear();
				tbCity.DataBindings.Clear();
				tbCountry.DataBindings.Clear();

				tbID.DataBindings.Add("Text", Binding, "MemberID");
				tbName.DataBindings.Add("Text", Binding, "MemberName");
				tbEmail.DataBindings.Add("Text", Binding, "Email");
				tbCity.DataBindings.Add("Text", Binding, "City");
				tbCountry.DataBindings.Add("Text", Binding, "Country");

				dgvListView.DataSource = null;
				dgvListView.DataSource = Binding;

				if (member == null)
				{
					ClearText();
					btDelete.Enabled = false;
					btUpdate.Enabled = false;
					btAdd.Enabled = false;
				}
				else
				{
					btDelete.Enabled = true;
					btUpdate.Enabled = true;
					btAdd.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "invalid");
			}
		}

		private void ClearText()
		{
			tbID.Text = string.Empty;
			tbName.Text = string.Empty;
			tbEmail.Text = string.Empty;
			tbCity.Text = string.Empty;
			tbCountry.Text = string.Empty;
		}

		private void btAdd_Click(object sender, EventArgs e)
		{
			frmMember frmMember = new frmMember()
			{
				InsertOrUpdate = false,
				Text = "New Member",
				memberRepository = memberRepository
			};
			if (frmMember.ShowDialog() == DialogResult.OK)
			{
				LoadMemberList();
				Binding.Position = Binding.Count - 1;
			}
			LoadMemberList();
		}

		private void btDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var member = GetMemberObject();
				memberRepository.DeleteMember(member.MemberID);
				LoadMemberList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btUpdate_Click(object sender, EventArgs e)
		{
			frmMember frmMember = new frmMember()
			{
				Text = "Update Member",
				InsertOrUpdate = true,
				ValidAdmin = true,
				MemberObject = GetMemberObject(),
				MemberRepository = memberRepository
			};
			if (frmMember.ShowDialog() == DialogResult.OK)
			{
				LoadMemberList();
				Binding.Position = Binding.Count - 1;
			}
			LoadMemberList();
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				String textSearch = tbSearch.Text;

				if (cbSearch.SelectedIndex == 0)
				{
					if (string.IsNullOrWhiteSpace(textSearch))
					{
						ListStoreSearch = memberRepository.GetListAllMember();
						LoadSearchMember(ListStoreSearch);
					}
					else
					{
						ListStoreSearch = memberRepository.searchMemberById(int.Parse(textSearch), null);
						LoadSearchMember(ListStoreSearch);
					}
				}
				else
				{
					if (string.IsNullOrWhiteSpace(textSearch))
					{
						ListStoreSearch = memberRepository.GetListAllMember();
						LoadSearchMember(ListStoreSearch);
					}
					else
					{
						ListStoreSearch = memberRepository.searchMemberByName(textSearch, null);
						LoadSearchMember(ListStoreSearch);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadSearchMember(List<MemberObject> listStoreSearch)
		{
			Binding = new BindingSource();
			Binding.DataSource = listStoreSearch;

			tbID.DataBindings.Clear();
			tbName.DataBindings.Clear();
			tbEmail.DataBindings.Clear();
			tbCountry.DataBindings.Clear();
			tbCity.DataBindings.Clear();

			tbID.DataBindings.Add("Text", Binding, "MemberID");
			tbName.DataBindings.Add("Text", Binding, "MemberName");
			tbEmail.DataBindings.Add("Text", Binding, "Email");
			tbCountry.DataBindings.Add("Text", Binding, "Country");
			tbCity.DataBindings.Add("Text", Binding, "City");

			dgvListView.DataSource = null;
			dgvListView.DataSource = Binding;

			if (listStoreSearch == null)
			{
				ClearText();
				btDelete.Enabled = false;
				btAdd.Enabled = false;
				btUpdate.Enabled = false;
			}
			else
			{
				btDelete.Enabled = true;
				btAdd.Enabled = true;
				btUpdate.Enabled = true;
			}
		}

		private void cbCityOrCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListStoreSearch = memberRepository.GetListAllMember();

			if (cbFilter.SelectedIndex == 0)
			{
				ListStoreSearch = memberRepository.filterByCity(cbCityOrCountry.Text.ToString(), ListStoreSearch);
				LoadSearchMember(ListStoreSearch);
			}
			else
			{
				ListStoreSearch = memberRepository.filterByCountry(cbCityOrCountry.Text.ToString(), ListStoreSearch);
				LoadSearchMember(ListStoreSearch);
			}
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<String> ListCityOrCountry = null;
			switch (cbFilter.SelectedIndex)
			{
				case 0:
					ListCityOrCountry = GetListCity();
					break;
				case 1:
					ListCityOrCountry = GetListCountry();
					break;
			}
			cbCityOrCountry.Items.Clear();
			if (ListCityOrCountry != null)
			{
				cbCityOrCountry.Items.AddRange(ListCityOrCountry.ToArray());
			}
			cbCityOrCountry.SelectedIndex = 0;
		}

		private List<string>? GetListCountry()
		{
			return memberRepository.GetListAllMember().Select(mb => mb.Country).Distinct().ToList();
		}

		private List<string>? GetListCity()
		{
			return memberRepository.GetListAllMember().Select(mb => mb.City).Distinct().ToList();
		}

		private void btSort_Click(object sender, EventArgs e)
		{
			List<MemberObject> listMemberSort = null;
			if (ListStoreMember == null)
			{
				listMemberSort = memberRepository.GetListAllMember();
			}
			else
			{
				listMemberSort = ListStoreMember;
			}

			if (btSort.Text.Trim().Equals("DESC"))
			{
				LoadSearchMember(listMemberSort.OrderByDescending(x => x.MemberName).ToList());
				btSort.Text = "ASC";
			}
			else if (btSort.Text.Trim().Equals("ASC"))
			{
				LoadSearchMember(listMemberSort.OrderBy(x => x.MemberName).ToList());
				btSort.Text = "DESC";
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			ListStoreMember = memberRepository.GetListAllMember();
			dgvListView.DataSource = ListStoreMember;
		}
	}
}
