// <windows_pocket_firewall_source_header>
// This file is part of Windows Pocket Firewall software.
// Copyright (C)2014-2016 AirVPN (support@airvpn.org) / https://airvpn.org
//
// Windows Pocket Firewall is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Windows Pocket Firewall is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Windows Pocket Firewall. If not, see <http://www.gnu.org/licenses/>.
// </windows_pocket_firewall_source_header>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UiPocketFirewall
{
    public partial class FormRule : Form
    {
        public XmlElement Xml;

        public FormRule()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = Utils.GetWindowTitle("Rule");

            cboLayer.Items.Add(Lang.GetText("layer","all"));
            cboLayer.Items.Add(Lang.GetText("layer", "ipv4"));
            cboLayer.Items.Add(Lang.GetText("layer", "ipv6"));
            cboLayer.Items.Add(Lang.GetText("layer", "ale_auth_recv_accept_v4"));
            cboLayer.Items.Add(Lang.GetText("layer", "ale_auth_recv_accept_v6"));
            cboLayer.Items.Add(Lang.GetText("layer", "ale_auth_connect_v4"));
            cboLayer.Items.Add(Lang.GetText("layer", "ale_auth_connect_v6"));
            cboLayer.Items.Add(Lang.GetText("layer", "ale_flow_established_v4"));
            cboLayer.Items.Add(Lang.GetText("layer", "ale_flow_established_v6"));

            cboAction.Items.Add(Lang.GetText("action","block"));
            cboAction.Items.Add(Lang.GetText("action","permit"));

            cboWeight.Items.Clear();
            cboWeight.Items.Add(Lang.GetText("weight", "auto"));
            cboWeight.Items.Add(Lang.GetText("weight", "max"));
            cboWeight.Items.Add(Lang.GetText("weight", "1"));
            cboWeight.Items.Add(Lang.GetText("weight", "2"));
            cboWeight.Items.Add(Lang.GetText("weight", "3"));
            cboWeight.Items.Add(Lang.GetText("weight", "4"));
            cboWeight.Items.Add(Lang.GetText("weight", "5"));

            txtName.Text = Xml.GetAttribute("name");
            chkEnabled.Checked = (Xml.GetAttribute("enabled") == "true");
            cboLayer.Text = Lang.GetText("layer", Xml.GetAttribute("layer"));
            cboAction.Text = Lang.GetText("action", Xml.GetAttribute("action"));
            cboWeight.Text = Lang.GetText("weight", Xml.GetAttribute("weight"));
            
            foreach(XmlElement xmlCondition in Xml.SelectNodes("//if"))
            {
                ListViewItemCondition listItem = new ListViewItemCondition();
                listItem.Xml = xmlCondition;
                listItem.Update();
                lstConditions.Items.Add(listItem);
            }
            
            EnabledUI();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            // Check
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (this.DialogResult == DialogResult.OK)
            {
                Xml.RemoveAll();

                Xml.SetAttribute("name", txtName.Text);
                Xml.SetAttribute("enabled", (chkEnabled.Checked) ? "true" : "false");
                Xml.SetAttribute("layer", Lang.GetKey("layer", cboLayer.Text));
                Xml.SetAttribute("weight", Lang.GetKey("weight", cboWeight.Text));
                Xml.SetAttribute("action", Lang.GetKey("action", cboAction.Text));
                
                foreach(ListViewItemCondition listItem in lstConditions.Items)
                {
                    Xml.AppendChild(Xml.OwnerDocument.ImportNode(listItem.Xml, true));
                }
            }
            
        }

        private void cmdConditionAdd_Click(object sender, EventArgs e)
        {
            ListViewItemCondition listViewItem = new ListViewItemCondition();
            listViewItem.Xml = new XmlDocument().CreateElement("if");
            listViewItem.Xml.SetAttribute("field", "ip_remote_address");
            listViewItem.Xml.SetAttribute("match", "equal");

            if (ConditionEdit(listViewItem) == true)
                lstConditions.Items.Add(listViewItem);

            EnabledUI();
        }

        private void cmdConditionRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in lstConditions.SelectedItems)
            {
                listItem.Remove();
            }

            EnabledUI();
        }

        private void cmdConditionEdit_Click(object sender, EventArgs e)
        {
            if (lstConditions.SelectedItems.Count == 1)
            {
                ListViewItemCondition listViewItem = lstConditions.SelectedItems[0] as ListViewItemCondition;
                ConditionEdit(listViewItem);
            }
        }

        private void cmdConditionUp_Click(object sender, EventArgs e)
        {
            if (lstConditions.SelectedItems.Count != 1)
                return;

            ListViewItem item = lstConditions.SelectedItems[0];
            int index = item.Index;
            lstConditions.Items.RemoveAt(index);
            lstConditions.Items.Insert(index - 1, item);
            item.Selected = true;
            lstConditions.Focus();
        }

        private void cmdConditionDown_Click(object sender, EventArgs e)
        {
            if (lstConditions.SelectedItems.Count != 1)
                return;

            ListViewItem item = lstConditions.SelectedItems[0];
            int index = item.Index;
            lstConditions.Items.RemoveAt(index);
            lstConditions.Items.Insert(index + 1, item);
            item.Selected = true;
            lstConditions.Focus();
        }

        private void lstConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledUI();
        }

        private void lstConditions_DoubleClick(object sender, EventArgs e)
        {
            cmdConditionEdit_Click(sender, e);
        }

        private void EnabledUI()
        {
            cmdConditionEdit.Enabled = (lstConditions.SelectedItems.Count == 1);
            cmdConditionRemove.Enabled = (lstConditions.SelectedItems.Count >= 1);
            cmdConditionUp.Enabled = ((lstConditions.SelectedItems.Count == 1) && (lstConditions.SelectedIndices[0] > 0));
            cmdConditionDown.Enabled = ((lstConditions.SelectedItems.Count == 1) && (lstConditions.SelectedIndices[0] < lstConditions.Items.Count - 1));
        }

        private bool ConditionEdit(ListViewItemCondition listViewItem)
        {
            FormCondition form = new FormCondition();

            form.Xml = listViewItem.Xml.CloneNode(true) as XmlElement;

            if (form.ShowDialog() == DialogResult.OK)
            {
                listViewItem.Xml = form.Xml;

                listViewItem.Update();

                EnabledUI();

                return true;
            }

            return false;
        }
        
    }
}
