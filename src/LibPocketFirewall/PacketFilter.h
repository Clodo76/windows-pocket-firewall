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

/******************************************************************************
  PacketFilter.h  - PacketFilter class declaration.
 
  Original WFP source code by Mahesh S
  swatkat_thinkdigit@yahoo.co.in
  http://swatrant.blogspot.com/
  and code by ValdikSS
******************************************************************************/

#ifndef _PACKETFILTER_H_
#define _PACKETFILTER_H_

// Standard includes.
#include <Winsock2.h>
#include <conio.h>
#include <strsafe.h>
#include <fwpmu.h>
#include <stdint.h>
#include <vector>

#define XMLBUFSIZE 4096

// Utils: Guid
std::string createGUIDString();

// Firewall sublayer GUID.
GUID m_subLayerGUID;

std::string lastError;
std::string subLayerName;
std::wstring subLayerWName;
std::wstring serviceWName;

// Save filter IDs here
std::vector<UINT64> filterids;

UINT16 maxSubLayerWeight = 65535;
UINT64 maxFilterWeight = 18446744073709551615;
UINT64 zeroInterface = 0;

// Firewall engine handle.
HANDLE m_hEngineHandle;

extern "C" { __declspec(dllexport) void LibPocketFirewallInit(const char* name); }

extern "C" { __declspec(dllexport) BOOL LibPocketFirewallStart(const char* xml); }
extern "C" { __declspec(dllexport) BOOL LibPocketFirewallStop(); }

extern "C" { __declspec(dllexport) UINT64 LibPocketFirewallAddRule(const char* xml); }
extern "C" { __declspec(dllexport) BOOL LibPocketFirewallRemoveRule(const UINT64 id); }
extern "C" { __declspec(dllexport) BOOL LibPocketFirewallRemoveRuleDirect(const UINT64 id); }

extern "C" { __declspec(dllexport) const char* LibPocketFirewallGetLastError(); }

extern "C" { __declspec(dllexport) UINT64 LibPocketFirewallTest(); }

#endif