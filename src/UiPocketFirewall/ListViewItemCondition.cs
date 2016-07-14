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
    public class ListViewItemCondition : ListViewItem
    {
        public XmlElement Xml;

        public void Update()
        {
            while (SubItems.Count < 3)
                SubItems.Add("");

            string field = Xml.GetAttribute("field");
            string match = Xml.GetAttribute("match");
            SubItems[0].Text = Lang.GetText("field", field);
            SubItems[1].Text = Lang.GetText("match", match);

            string value = "";
            if (field == "ip_remote_address")
                value = Xml.GetAttribute("address") + "/" + Xml.GetAttribute("mask");
            else if (field == "ip_remote_port")
            {
                if (match == "range")
                    value = Xml.GetAttribute("port_from") + " - " + Xml.GetAttribute("port_to");
                else
                    value = Xml.GetAttribute("port");
            }
            else if (field == "ale_app_id")
                value = Xml.GetAttribute("path");
            else if (field == "ip_protocol")
                value = Xml.GetAttribute("protocol");
            else if (field == "ip_local_interface")
                value = Utils.GetTextFromNetworkInterface(Xml.GetAttribute("interface"));
            else if (field == "ip_local_address")
                value = Xml.GetAttribute("address") + "/" + Xml.GetAttribute("mask");
            else if (field == "ip_local_port")
            {
                if (match == "range")
                    value = Xml.GetAttribute("port_from") + " - " + Xml.GetAttribute("port_to");
                else
                    value = Xml.GetAttribute("port");
            }


            SubItems[2].Text = value;
            
        }
    }
}
