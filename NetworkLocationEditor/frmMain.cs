using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NetworkLocationEditor
{
    public partial class frmMain : Form
    {
        private Dictionary<string, Guid> _sigProDic;
        public frmMain()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            List<NTSignature> list = RegistryHelper.GetNetworkLocationList();
            _sigProDic = new Dictionary<string, Guid>();
            foreach (NTSignature nts in list)
            {
                ListViewItem lvt = listView1.Items.Add(nts.SignatureName);
                lvt.SubItems.Add(nts.Description);
                lvt.SubItems.Add(nts.GatewayMAC);
                lvt.SubItems.Add(nts.DnsSuffix);
                if (nts.Profiles.Category == 1)
                {
                    lvt.SubItems.Add("专用网络");
                }
                else
                {
                    lvt.SubItems.Add("公用网络");
                }
                _sigProDic.Add(nts.SignatureName, nts.ProfileGuid);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this.listView1.Columns[e.Column].Tag == null)
            {
                this.listView1.Columns[e.Column].Tag = true;
            }
            bool flag = !(bool)this.listView1.Columns[e.Column].Tag;
            this.listView1.Columns[e.Column].Tag = flag;
            this.listView1.ListViewItemSorter = new ListViewSort(e.Column, flag);
            this.listView1.Sort();  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection slvic = listView1.SelectedItems;
            if (slvic.Count == 1)
            {
                ListViewItem lvt = slvic[0];
                txtDescription.Tag = lvt.SubItems[0].Text;
                txtDescription.Text = lvt.SubItems[1].Text;
                txtGatewayMAC.Text = lvt.SubItems[2].Text;
                txtDnsSuffix.Text = lvt.SubItems[3].Text;
                if (lvt.SubItems[4].Text == "专用网络")
                {
                    cbCategory.SelectedIndex = 1;
                }
                else
                {
                    cbCategory.SelectedIndex = 0;
                }
            }
            else
            {
                txtDescription.Tag = null;
                txtDescription.Text = "";
                txtGatewayMAC.Text = "";
                txtDnsSuffix.Text = "";
                cbCategory.SelectedIndex = -1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection slvic = listView1.SelectedItems;
            foreach (ListViewItem lvt in slvic)
            {
                lvt.Remove();
                string signatureName = lvt.SubItems[0].Text;
                Guid profileID = _sigProDic[signatureName];
                RegistryHelper.DelNTConfig(signatureName, profileID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NTSignature nts = new NTSignature();
            nts.SignatureName = txtDescription.Tag.ToString();
            nts.Description = txtDescription.Text;
            nts.FirstNetwork = txtDescription.Text;
            nts.Profiles.Description = txtDescription.Text;
            nts.Profiles.ProfileName = txtDescription.Text;
            nts.GatewayMAC = txtGatewayMAC.Text;
            nts.DnsSuffix = txtDnsSuffix.Text;
            nts.Profiles.Category = cbCategory.SelectedIndex;
            RegistryHelper.UpdateNTConfig(nts);
            ListViewItem lvt = listView1.FindItemWithText(nts.SignatureName);
            lvt.SubItems[1].Text = nts.Description;
            lvt.SubItems[2].Text = nts.GatewayMAC;
            lvt.SubItems[3].Text = nts.DnsSuffix;
            if (nts.Profiles.Category == 1)
            {
                lvt.SubItems[4].Text = "专用网络";
            }
            else
            {
                lvt.SubItems[4].Text = "公用网络";
            }
        }
    }
}
