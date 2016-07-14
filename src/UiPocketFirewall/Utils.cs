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
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiPocketFirewall
{
    public class Utils
    {
        public static NetworkInterface[] NetworkInterfaces;

        public static void Init()
        {
            NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        }

        public static Dictionary<string, string> GetNetworksInterfaces()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict["loopback"] = "> Loopback";

            foreach (NetworkInterface adapter in Utils.NetworkInterfaces)
            {
                string key = adapter.Id;
                string desc = adapter.Name + " - " + adapter.Description + ", ID:" + adapter.Id;
                //dict[adapter.Id] = adapter.Description + " (" + adapter.Id + ")";
                dict[key] = desc;
            }
            return dict;
        }

        public static string GetTextFromNetworkInterface(string id)
        {
            Dictionary<string, string> adapters = Utils.GetNetworksInterfaces();
            foreach (KeyValuePair<string, string> pair in adapters)
            {
                if (pair.Key == id)
                    return pair.Value;
            }
            return "Unknown interface";
        }

        public static string GetWindowTitle(string title)
        {
            return Constants.AppName + " - " + title;
        }

        public static void MessageError(string message)
        {
            MessageBox.Show(message, GetWindowTitle("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}
