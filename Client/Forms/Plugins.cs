// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace Vexis
{
	public partial class Plugins
	{
		public Plugins()
		{
			InitializeComponent();
		}
		
		private Versidyne.Plugins.Services.AvailablePlugin[] Plugins_Renamed;
		private Versidyne.Plugins.Host ObjHost;
		
		public void Plugins_Load(System.Object sender, System.EventArgs e)
		{
			
			RetreivePlugins();
			
		}
		
		private void RetreivePlugins()
		{
			
			Plugins_Renamed = Versidyne.Plugins.Services.FindPlugins(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Versidyne.Plugins.Plugin");
			
			if (Plugins_Renamed == null)
			{
				
				ListView1.Items.Clear();
				ListView1.Items.Add("No plugins available");
				
			}
			else
			{
				
				AddDescriptions();
				
				ObjHost = new PluginHost();
				
			}
			
		}
		
		private void AddDescriptions()
		{
			
			Versidyne.Plugins.Plugin ObjPlugin = default(Versidyne.Plugins.Plugin);
			long IntIndex = default(long);
			
			//Loop through available plugins, creating instances and adding them to listbox
			for (IntIndex = 0; IntIndex <= Plugins_Renamed.Length - 1; IntIndex++)
			{
				
				ObjPlugin = (Versidyne.Plugins.Plugin) (Versidyne.Plugins.Services.CreateInstance(Plugins_Renamed[IntIndex]));
				ListView1.Items.Add(ObjPlugin.Name, 0);
				
			}
			
			//ListBox1.SelectedIndex = 0
			ListView1.SelectedItems.Clear();
			
		}
		
		private void Enable()
		{
			
			Versidyne.Plugins.Plugin ObjPlugin = default(Versidyne.Plugins.Plugin);
			int ReturnCode = default(int);
			Array Args = (Array) null;
			
			//Retreive Selected Data
			ListView.SelectedListViewItemCollection SelPlugins = default(ListView.SelectedListViewItemCollection);
			ListViewItem SelPlugin = default(ListViewItem);
			
			SelPlugins = ListView1.SelectedItems;
			
			foreach (ListViewItem tempLoopVar_SelPlugin in SelPlugins)
			{
				SelPlugin = tempLoopVar_SelPlugin;
				
				//Create and initialize plugin
				ObjPlugin = (Versidyne.Plugins.Plugin) (Versidyne.Plugins.Services.CreateInstance(Plugins_Renamed[SelPlugin.Index]));
				ObjPlugin.Initialize(ObjHost);
				
				//Begin threading here, since this is where blocking should start
				
				//Run calculation and return result
				try
				{
					
					ReturnCode = ObjPlugin.Main(Args);
					
					if (ReturnCode > 0)
					{
						
						MessageBox.Show("Plugin received return code: " + ReturnCode.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						
					}
					
				}
				catch
				{
					
					MessageBox.Show("Plugin failed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					
					return;
					
				}
				
				//End threading here
				
			}
			
		}
		
		private void Disable()
		{
			
			//End particular thread
			
		}
		
		public void EnableToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			Enable();
			
		}
		
		public void DisableToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			Disable();
			
		}
		
	}
}
