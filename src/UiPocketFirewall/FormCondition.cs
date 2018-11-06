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
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UiPocketFirewall
{
    public partial class FormCondition : Form
    {
        public XmlElement Xml;

        public FormCondition()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = Utils.GetWindowTitle("Condition");
                        
            cboField.Items.Add(Lang.GetText("field", "ip_remote_address"));
            cboField.Items.Add(Lang.GetText("field", "ip_remote_port"));            
            cboField.Items.Add(Lang.GetText("field", "ale_app_id"));            
            cboField.Items.Add(Lang.GetText("field", "ip_protocol"));
            cboField.Items.Add(Lang.GetText("field", "ip_local_interface"));
            cboField.Items.Add(Lang.GetText("field", "ip_local_address"));
            cboField.Items.Add(Lang.GetText("field", "ip_local_port"));

            cboOperator.Items.Add(Lang.GetText("match", "equal"));
            cboOperator.Items.Add(Lang.GetText("match", "not_equal"));
            cboOperator.Items.Add(Lang.GetText("match", "greater"));
            cboOperator.Items.Add(Lang.GetText("match", "less"));
            cboOperator.Items.Add(Lang.GetText("match", "greater_or_equal"));
            cboOperator.Items.Add(Lang.GetText("match", "less_or_equal"));
            cboOperator.Items.Add(Lang.GetText("match", "range"));

            cboField.Text = Lang.GetText("field", Xml.GetAttribute("field"));
            cboOperator.Text = Lang.GetText("match", Xml.GetAttribute("match"));



            tabValue.Appearance = TabAppearance.FlatButtons;
            tabValue.ItemSize = new Size(0, 1);
            tabValue.SizeMode = TabSizeMode.Fixed;

            cboProtocol.Items.Add("TCP");
            cboProtocol.Items.Add("UDP");
            cboProtocol.Items.Add("ICMP");

            ChangeField();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            /*
            if( (Lang.GetKey(cboField.Text) == "ip_remote_port") ||
                (Lang.GetKey(cboField.Text) == "ip_local_port") )
            {
                int port;
                if(int.TryParse(txtValue.Text, out port) == false)
                {
                    Utils.MessageError("Port must be a number.");
                    e.Cancel = true;
                }
            }
            */
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (this.DialogResult == DialogResult.OK)
            {
                Xml.RemoveAllAttributes();

                Xml.SetAttribute("field", Lang.GetKey("field", cboField.Text));
                Xml.SetAttribute("match", Lang.GetKey("match", cboOperator.Text));
                
                string field = Xml.GetAttribute("field");
                string match = Xml.GetAttribute("match");

                if (field == "ip_remote_address")
                {
					int posSlash = txtAddressIp.Text.IndexOf("/");
					if (posSlash != -1)
					{
						Xml.SetAttribute("address", txtAddressIp.Text.Substring(0,posSlash));
						Xml.SetAttribute("mask", txtAddressIp.Text.Substring(posSlash+1));
					}
					else
					{
						Xml.SetAttribute("address", txtAddressIp.Text);
						Xml.SetAttribute("mask", "");
					}
                }
                else if (field == "ip_remote_port")
                {
                    if (match == "range")
                    {
                        Xml.SetAttribute("port_from", Convert.ToUInt16(txtPortFrom.Value).ToString());
                        Xml.SetAttribute("port_to", Convert.ToUInt16(txtPortTo.Value).ToString());
                    }
                    else
                    {
                        Xml.SetAttribute("port", Convert.ToUInt16(txtPort.Value).ToString());
                    }
                }
                else if (field == "ale_app_id")
                {
                    Xml.SetAttribute("path", txtPath.Text);
                }
                else if (field == "ip_protocol")
                {
                    Xml.SetAttribute("protocol", cboProtocol.Text.ToLowerInvariant());
                }
                else if (field == "ip_local_interface")
                {
                    Dictionary<string, string> adapters = Utils.GetNetworksInterfaces();
                    foreach (KeyValuePair<string, string> pair in adapters)
                    {
                        if (cboInterface.Text == pair.Value)
                        {
                            Xml.SetAttribute("interface", pair.Key);
                            break;
                        }
                    }
                }
                if (field == "ip_local_address")
                {
					int posSlash = txtAddressIp.Text.IndexOf("/");
					if (posSlash != -1)
					{
						Xml.SetAttribute("address", txtAddressIp.Text.Substring(0, posSlash));
						Xml.SetAttribute("mask", txtAddressIp.Text.Substring(posSlash + 1));
					}
					else
					{
						Xml.SetAttribute("address", txtAddressIp.Text);
						Xml.SetAttribute("mask", "");
					}
				}
                else if (field == "ip_local_port")
                {
                    if (match == "range")
                    {
                        Xml.SetAttribute("port_from", Convert.ToUInt16(txtPortFrom.Value).ToString());
                        Xml.SetAttribute("port_to", Convert.ToUInt16(txtPortTo.Value).ToString());
                    }
                    else
                    {
                        Xml.SetAttribute("port", Convert.ToUInt16(txtPort.Value).ToString());
                    }
                }


            }
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeField();
        }

        private void cboOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeField();
        }

        private void cmdPathBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = txtPath.Text;
            dlg.Filter = "Application (*.exe)|*.exe|All files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }



        private void ChangeField()
        {
            string field = Lang.GetKey("field", cboField.Text);
            string match = Lang.GetKey("match", cboOperator.Text);

            if ( (field == "ip_remote_port") ||
                 (field == "ip_local_port") )
            {
                if(match == "range")
                {
                    tabValue.SelectedTab = tabValuePortRange;

                    txtPortFrom.Text = Xml.GetAttribute("port_from");
                    txtPortTo.Text = Xml.GetAttribute("port_to");
                }
                else
                {
                    tabValue.SelectedTab = tabValuePort;

                    txtPort.Text = Xml.GetAttribute("port");
                }
                
            }
            else if( (field == "ip_local_address") ||
                     (field == "ip_remote_address") )
            {
                tabValue.SelectedTab = tabValueAddress;
								
                txtAddressIp.Text = Xml.GetAttribute("address");
				if (Xml.GetAttribute("mask") != "")
					txtAddressIp.Text += "/" + Xml.GetAttribute("mask");					
            }
            else if(field == "ale_app_id")
            {
                tabValue.SelectedTab = tabValueApplication;     
                           
                txtPath.Text = Xml.GetAttribute("path");
            }
            else if(field == "ip_local_interface")
            {
                tabValue.SelectedTab = tabValueInterface;

                cboInterface.Items.Clear();

                Dictionary<string, string> adapters = Utils.GetNetworksInterfaces();
                foreach(KeyValuePair<string,string> pair in adapters)
                {
                    cboInterface.Items.Add(pair.Value);

                    if (pair.Key == Xml.GetAttribute("interface"))
                        cboInterface.SelectedIndex = cboInterface.Items.Count - 1;
                }
            }
            else if(field == "ip_protocol")
            {
                tabValue.SelectedTab = tabValueProtocol;

                cboProtocol.Text = Xml.GetAttribute("protocol").ToUpperInvariant();
            }
        }
        
    }
}
