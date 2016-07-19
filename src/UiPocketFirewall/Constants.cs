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
    public class Constants
    {
        public static string AppName = "Windows Pocket Firewall";
        public static string WfpName = "PocketFirewall-da9274bcecd082c202d71ffa3b50c2c115b3b7e1";
        public static string Version = "0.1 Alpha";
        public static int VersionNumber = 1;

        // TOFIX: Persistent mode give a fatal error if executed on Windows 7. Still unknown issue.
        // https://social.msdn.microsoft.com/Forums/windowsdesktop/en-US/006cd03a-1f7b-402f-86ed-6ab96cd9f0d7/fwpmsublayerflagpersistent-cause-fwpedynamicsessioninprogress-only-in-win7?forum=wfp
        public static bool PersistentMode = false;        
    }
}
