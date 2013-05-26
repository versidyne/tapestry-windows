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
	public partial class Channels
	{
		public Channels()
		{
			InitializeComponent();
		}
		
		public void DisplayChannels()
		{
			
			ChannelList.Items.Clear();
			
			string RawChannels = Main.Default.NetGet.Retreive("http://api.versidyne.com/?session=" + Main.Default.Session + "&info=channels");
			Array Channels = RawChannels.Split("<|(row)|>".ToCharArray()[0]);
			string Channel = null;
			string[] Info = null;
			
			foreach (string tempLoopVar_Channel in Channels)
			{
				Channel = tempLoopVar_Channel;
				
				if (Channel.Contains("<|(cell)|>"))
				{
					
					Info = Channel.Split("<|(cell)|>".ToCharArray()[0]);
					
					if (Info[2] == "private")
					{
						
						ChannelList.Items.Add(Info[1], 1);
						
					}
					else
					{
						
						ChannelList.Items.Add(Info[1], 0);
						
					}
					
				}
				
			}
			
		}
		
		public void Channels_Load(System.Object sender, System.EventArgs e)
		{
			
			DisplayChannels();
			
		}
		
	}
}
