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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UiPocketFirewall
{
    public class ListViewItemRule : ListViewItem
    {
        public List<UInt64> FirewallIds = new List<UInt64>();
        public XmlElement Xml;
        
        public void Update()
        {
            while (SubItems.Count < 5)
                SubItems.Add("");

            SubItems[0].Text = Xml.GetAttribute("name");
            SubItems[1].Text = Lang.GetText("enabled", Xml.GetAttribute("enabled"));
            if (FirewallIds.Count == 0)
            {
                SubItems[2].Text = "No";
            }
            else
            {
                SubItems[2].Text = "Yes";
                SubItems[2].Text += " (" + FirewallIds.Count + " filters)";
            }
            
            SubItems[3].Text = Lang.GetText("layer", Xml.GetAttribute("layer"));
            SubItems[4].Text = Lang.GetText("action", Xml.GetAttribute("action"));

            if (Xml.GetAttribute("enabled") == "true")
                ForeColor = System.Drawing.SystemColors.WindowText;
            else
                ForeColor = System.Drawing.Color.Gray;
        }

        public void FirewallEnable()
        {
            FirewallDisable();

            if (Xml.GetAttribute("enabled") != "true")
                return;

            List<string> layers = new List<string>();

            if (Xml.GetAttribute("layer") == "all")
            {
                layers.Add("ale_auth_recv_accept_v4");
                layers.Add("ale_auth_recv_accept_v6");
                layers.Add("ale_auth_connect_v4");
                layers.Add("ale_auth_connect_v6");
                layers.Add("ale_flow_established_v4");
                layers.Add("ale_flow_established_v6");
            }
            else if (Xml.GetAttribute("layer") == "ipv4")
            {
                layers.Add("ale_auth_recv_accept_v4");
                layers.Add("ale_auth_connect_v4");
                layers.Add("ale_flow_established_v4");                
            }
            else if (Xml.GetAttribute("layer") == "ipv6")
            {
                layers.Add("ale_auth_recv_accept_v6");
                layers.Add("ale_auth_connect_v6");
                layers.Add("ale_flow_established_v6");
            }
            else
                layers.Add(Xml.GetAttribute("layer"));

            foreach(string layer in layers)
            {
                XmlElement xmlClone = Xml.CloneNode(true) as XmlElement;
                xmlClone.SetAttribute("layer", layer);
                //xmlClone.SetAttribute("persistent", "true");           
                string xml = xmlClone.OuterXml;
                UInt64 id1 = FormMain.LibPocketFirewallAddRule(xml);

                if (id1 == 0)
                {
                    MessageBox.Show("Error in rule '" + Text + "': " + FormMain.LibPocketFirewallGetLastError2());
                }
                else
                {
                    FirewallIds.Add(id1);
                }
            }            
        }

        public void FirewallDisable()
        {
            foreach(UInt64 id in FirewallIds)
            {
                bool result = FormMain.LibPocketFirewallRemoveRule(id);
            }
            FirewallIds.Clear();
        }

        
    }
}
