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

namespace UiPocketFirewall
{
    public class LangGroup
    {
        public Dictionary<string, string> KeyToText = new Dictionary<string, string>();
        public Dictionary<string, string> TextToKey = new Dictionary<string, string>();
    }

    public static class Lang
    {
        public static Dictionary<string, LangGroup> Groups = new Dictionary<string, LangGroup>();

        public static void Init()
        {
            Add("enabled", "true", "Yes");
            Add("enabled", "false", "No");

            Add("layer", "all", "All");
            Add("layer", "ipv4", "All IPv4");
            Add("layer", "ipv6", "All IPv6");
            Add("layer", "ale_auth_recv_accept_v4", "Accept - IPv4");
            Add("layer", "ale_auth_recv_accept_v6", "Accept - IPv6");
            Add("layer", "ale_auth_connect_v4", "Connect - IPv4");
            Add("layer", "ale_auth_connect_v6", "Connect - IPv6");
            Add("layer", "ale_flow_established_v4", "Established - IPv4");
            Add("layer", "ale_flow_established_v6", "Established - IPv6");

            Add("action", "block", "Block");
            Add("action", "permit", "Allow");

            Add("weight", "auto", "Automatic");
            Add("weight", "max", "Max priority");
            Add("weight", "1", "1 - Low");
            Add("weight", "2", "2");
            Add("weight", "3", "3");
            Add("weight", "4", "4");
            Add("weight", "5", "5 - High");

            // Many not yet supported: https://msdn.microsoft.com/en-us/library/windows/desktop/aa363996(v=vs.85).aspx
            Add("field", "ale_app_id", "Application");
            Add("field", "ip_local_address", "Local Address");
            Add("field", "ip_local_interface", "Local Interface");
            Add("field", "ip_local_port", "Local Port");
            Add("field", "ip_protocol", "Protocol");
            Add("field", "ip_remote_address", "Remote Address");
            Add("field", "ip_remote_port", "Remote Port");
            
            Add("match", "equal", "= (Equal)");
            Add("match", "greater", "> (Greater)");
            Add("match", "less", "< (Less)");
            Add("match", "greater_or_equal", ">= (Greater or Equal)");
            Add("match", "less_or_equal", "< (Less or Equal)");
            Add("match", "range", "Range"); // Not yet supported
            //Add("match", "flags_all_set", "Equal"); // Not yet supported
            //Add("match", "flags_any_set", "Equal"); // Not yet supported
            //Add("match", "flags_none_set", "Equal"); // Not yet supported
            //Add("match", "equal_case_insensitive", "Equal"); // Not yet supported
            Add("match", "not_equal", "Not Equal");
            //Add("match", "type_max", "Equal"); // Not yet supported            
        }

        public static string GetText(string group, string key)
        {
            LangGroup g = Groups[group];

            if (g.KeyToText.ContainsKey(key))
                return g.KeyToText[key];
            else
                return "Unknown '" + key + "'";
        }

        public static string GetKey(string group, string text)
        {
            LangGroup g = Groups[group];

            if (g.TextToKey.ContainsKey(text))
                return g.TextToKey[text];
            else
                return "";
        }

        private static void Add(string group, string key, string text)
        {
            LangGroup g;
            if (Groups.ContainsKey(group))
                g = Groups[group];
            else
            {
                g = new LangGroup();
                Groups[group] = g;
            }

            g.KeyToText[key] = text;
            g.TextToKey[text] = key;
        }
    }
}
