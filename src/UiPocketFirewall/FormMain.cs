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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using System.Runtime.InteropServices;

namespace UiPocketFirewall
{
    public partial class FormMain : Form
    {
        public static FormMain Instance;

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LibPocketFirewallInit(string name);

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LibPocketFirewallStart(string xml);

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LibPocketFirewallStop();

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt64 LibPocketFirewallAddRule(string xml);

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LibPocketFirewallRemoveRule(UInt64 id);

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LibPocketFirewallRemoveRuleDirect(UInt64 id);

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr LibPocketFirewallGetLastError();

        [DllImport("LibPocketFirewall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 LibPocketFirewallGetLastErrorCode();

        public static string LibPocketFirewallGetLastError2()
        {
            IntPtr result = LibPocketFirewallGetLastError();
            string s = Marshal.PtrToStringAnsi(result);
            UInt32 code = LibPocketFirewallGetLastErrorCode();
            if(code != 0)
                s += " (0x" + code.ToString("x") + ")";
            return s;
        }

        private string m_path = "";
        private bool m_started = false;
        
        public FormMain()
        {
            Instance = this;

            InitializeComponent();                        
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CommandLine.InitSystem(Environment.CommandLine);

            Lang.Init();

            Utils.Init();

            cboWeight.Items.Clear();
            cboWeight.Items.Add(Lang.GetText("weight", "auto"));
            cboWeight.Items.Add(Lang.GetText("weight", "max"));
            cboWeight.Items.Add(Lang.GetText("weight", "1"));
            cboWeight.Items.Add(Lang.GetText("weight", "2"));
            cboWeight.Items.Add(Lang.GetText("weight", "3"));
            cboWeight.Items.Add(Lang.GetText("weight", "4"));
            cboWeight.Items.Add(Lang.GetText("weight", "5"));

            LibPocketFirewallInit(Constants.WfpName);
            
            // If commandline empty
            string defaultProfilePath = GetAppPath() + "\\default.xml";
            if (System.IO.File.Exists(defaultProfilePath))
                ProfileLoad(defaultProfilePath);
            else
            {
                ProfileNew();
                ProfileSave(defaultProfilePath);
            }
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            StopFirewall();
        }

        private void cmdStartStop_Click(object sender, EventArgs e)
        {
            if (m_started == false)
            {
                StartFirewall();
            }
            else
            {
                StopFirewall();
            }
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            ProfileNew();            
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Profile files (*.xml)|*.xml|All files (*.*)|*.*";
            if (m_path == "")
                dlg.InitialDirectory = GetAppPath();
            else
                dlg.InitialDirectory = System.IO.Path.GetDirectoryName(m_path);
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ProfileLoad(dlg.FileName);
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (m_path == "")
                mnuFileSaveAs_Click(sender, e);
            else
                ProfileSave("");
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Profile files (*.xml)|*.xml|All files (*.*)|*.*";
            if (m_path == "")
                dlg.InitialDirectory = GetAppPath();
            else
                dlg.InitialDirectory = System.IO.Path.GetDirectoryName(m_path);
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ProfileSave(dlg.FileName);
            }
        }

        private void mnuFileReport_Click(object sender, EventArgs e)
        {
            FormReport dlg = new FormReport();
            dlg.ShowDialog();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void lstRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledUI();
        }

        private void lstRules_DoubleClick(object sender, EventArgs e)
        {
            cmdRuleEdit_Click(sender, e);
        }

        private void cmdRuleAdd_Click(object sender, EventArgs e)
        {
            ListViewItemRule listViewItem = new ListViewItemRule();
            listViewItem.Xml = new XmlDocument().CreateElement("rule");
            listViewItem.Xml.SetAttribute("name", "New rule");
            listViewItem.Xml.SetAttribute("enabled", "true");
            listViewItem.Xml.SetAttribute("layer", "all");
            listViewItem.Xml.SetAttribute("action", "block");
            listViewItem.Xml.SetAttribute("weight", "auto");

            if (RuleEdit(listViewItem) == true)
                lstRules.Items.Add(listViewItem);

            EnabledUI();
        }

        private void cmdRuleRemove_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem listItem in lstRules.SelectedItems)
            {
                listItem.Remove();
            }

            EnabledUI();
        }

        private void cmdRuleEdit_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedItems.Count == 1)
            {
                ListViewItemRule listViewItem = lstRules.SelectedItems[0] as ListViewItemRule;
                RuleEdit(listViewItem);                
            }            
        }

        private void cmdRuleUp_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedItems.Count != 1)
                return;

            ListViewItem item = lstRules.SelectedItems[0];
            int index = item.Index;
            lstRules.Items.RemoveAt(index);
            lstRules.Items.Insert(index - 1, item);
            item.Selected = true;
            lstRules.Focus();
        }

        private void cmdRuleDown_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedItems.Count != 1)
                return;

            ListViewItem item = lstRules.SelectedItems[0];
            int index = item.Index;
            lstRules.Items.RemoveAt(index);
            lstRules.Items.Insert(index + 1, item);
            item.Selected = true;
            lstRules.Focus();
        }

        private string GetAppPath()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void EnabledUI()
        {
            mnuFileSaveAs.Enabled = (m_path != "");
            cmdRuleEdit.Enabled = (lstRules.SelectedItems.Count == 1);
            cmdRuleRemove.Enabled = (lstRules.SelectedItems.Count >= 1);
            cmdRuleUp.Enabled = ((lstRules.SelectedItems.Count == 1) && (lstRules.SelectedIndices[0] > 0));
            cmdRuleDown.Enabled = ((lstRules.SelectedItems.Count == 1) && (lstRules.SelectedIndices[0] < lstRules.Items.Count-1));

            if (m_path == "")
                Text = "Untitled";
            else
                Text = m_path;
            Text += " - " + Constants.AppName;
        }

        private void UpdateRules()
        {
            foreach(ListViewItemRule item in lstRules.Items)
            {
                item.Update();
            }
        }

        private void ProfileNew()
        {
            StopFirewall();
            txtDescription.Text = "";
            cboWeight.SelectedIndex = 0;
            lstRules.Items.Clear();
            m_path = "";

            EnabledUI();
        }

        private void ProfileLoad(string path)
        {
            FileInfo f = new FileInfo(path);
            path = f.FullName;

            StopFirewall();

            XmlDocument xmlDoc = new XmlDocument();

            lstRules.Items.Clear();

            xmlDoc.Load(path);
            foreach(XmlElement xmlRule in xmlDoc.SelectNodes("//rule"))
            {
                ListViewItemRule listViewItem = new ListViewItemRule();
                listViewItem.Xml = xmlRule;
                listViewItem.Update();
                lstRules.Items.Add(listViewItem);
            }

            txtDescription.Text = xmlDoc.DocumentElement.GetAttribute("description");
            cboWeight.Text = Lang.GetText("weight", xmlDoc.DocumentElement.GetAttribute("weight"));

            m_path = path;

            EnabledUI();
        }

        private void ProfileSave(string newPath)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement xmlRules = xmlDoc.CreateElement("rules");
            xmlDoc.AppendChild(xmlRules);

            xmlRules.SetAttribute("description", txtDescription.Text);
            xmlRules.SetAttribute("weight", Lang.GetKey("weight", cboWeight.Text));

            xmlDoc.InsertBefore(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null), xmlRules);

            foreach (ListViewItemRule listViewItem in lstRules.Items)
            {
                XmlElement xmlRule = xmlDoc.ImportNode(listViewItem.Xml, true) as XmlElement;
                xmlRules.AppendChild(xmlRule);
            }

            if (newPath != "")
                m_path = newPath;
            xmlDoc.Save(m_path);

            EnabledUI();
        }

        private void StartFirewall()
        {
            if (m_started == false)
            {
                XmlDocument xmlStart = new XmlDocument();
                XmlElement xmlInfo = xmlStart.CreateElement("firewall");
                xmlInfo.SetAttribute("description", "PocketFirewall");
                xmlInfo.SetAttribute("weight", Lang.GetKey("weight", cboWeight.Text));

                xmlInfo.SetAttribute("persistent", chkPersistent.Checked ? "true" : "false");

                xmlInfo.SetAttribute("dynamic", chkDynamic.Checked ? "true" : "false");

                try
                {
                    if (LibPocketFirewallStart(xmlInfo.OuterXml))
                    {
                        ClearRules(Constants.WfpName);

                        foreach (ListViewItemRule listViewItem in lstRules.Items)
                        {
                            if (listViewItem.Xml.GetAttribute("enabled") != "true")
                                continue;

                            listViewItem.FirewallEnable();
                        }

                        UpdateRules();

                        m_started = true;
                        cmdStartStop.Text = "Running. Click to stop";
                        cmdStartStop.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        throw new Exception("Unable to start: " + FormMain.LibPocketFirewallGetLastError2());                        
                    }
                }
                catch(Exception e)
                {
                    Utils.MessageError(e.Message);
                }
            }
        }

        private void StopFirewall()
        {
            if (m_started == true)
            {
                foreach(ListViewItemRule itemRule in lstRules.Items)
                {
                    itemRule.FirewallDisable();                    
                }

                UpdateRules();

                if (LibPocketFirewallStop() == false)
                    return;
            }

            m_started = false;
            cmdStartStop.Text = "Not running. Click to start";
            cmdStartStop.BackColor = Color.Red;
        }

        public UInt64 AddRule(XmlElement xml)
        {
            xml.SetAttribute("persistent", chkPersistent.Checked ? "true" : "false");

            string xmlStr = xml.OuterXml;

            return FormMain.LibPocketFirewallAddRule(xmlStr);
        }

        private bool RuleEdit(ListViewItemRule listViewItem)
        {            
            FormRule form = new FormRule();

            form.Xml = listViewItem.Xml.CloneNode(true) as XmlElement;

            if(form.ShowDialog() == DialogResult.OK)
            {
                listViewItem.Xml = form.Xml;

                listViewItem.FirewallDisable();

                if (m_started)
                {
                    listViewItem.FirewallEnable();                    
                }

                listViewItem.Update();

                EnabledUI();

                return true;
            }
            
            return false;
        }
        
        private void ClearRules(string WfpName)
        {
            string path = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".xml";

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "NetSh.exe";
            p.StartInfo.Arguments = "WFP Show Filters file=\"" + path + "\"";
            p.StartInfo.WorkingDirectory = Path.GetTempPath();
            p.Start();            
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            int nClean = 0;
            System.Xml.XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            foreach(XmlElement xmlFilter in xmlDoc.DocumentElement.GetElementsByTagName("filters"))
            {
                foreach (XmlElement xmlItem in xmlFilter.GetElementsByTagName("item"))
                {
                    foreach(XmlElement xmlName in xmlItem.SelectNodes("displayData/name"))
                    {
                        string name = xmlName.InnerText;
                        if(name == WfpName)
                        {
                            foreach (XmlNode xmlFilterId in xmlItem.GetElementsByTagName("filterId"))
                            {
                                ulong id;
                                if(ulong.TryParse(xmlFilterId.InnerText, out id))
                                {
                                    bool result = LibPocketFirewallRemoveRuleDirect(id);
                                    nClean++;
                                }
                            }                                
                        }
                    }
                }
            }

            if (nClean > 0)
                Utils.MessageError("N. " + nClean + " rule pending and removed.");

            File.Delete(path);
        }
        
    }
}
