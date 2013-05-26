// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace Vexis_Server
{
	public partial class Main
	{
		public Main()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Main defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Main Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Main();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
#region Callouts
		
		private Versidyne.Network.NetSock NetSocket = new Versidyne.Network.NetSock();
		
		private delegate void SetTextCallback(string Data);
		
		private bool DisableTray = false;
		
#endregion
		
#region Form Events
		
		public void Main_Load(System.Object sender, System.EventArgs e)
		{
			
			//Do nothing
			
		}
		
		public void Main_Resize(System.Object sender, System.EventArgs e)
		{
			
			if (this.WindowState == FormWindowState.Minimized)
			{
				
				this.Hide();
				
			}
			
		}
		
		public void Main_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			
			this.WindowState = FormWindowState.Minimized;
			
			if (DisableTray == false)
			{
				
				e.Cancel = true;
				
			}
			
		}
		
#endregion
		
#region Form Functions
		
		private void DisplayData(string InputText)
		{
			
			if (this.Disposing == false)
			{
				
				if (Info.Default.ReceivedBox.Text == null)
				{
					
					Info.Default.ReceivedBox.Text = InputText;
					
				}
				else
				{
					
					Info.Default.ReceivedBox.Text += "\r\n" + InputText;
					
				}
				
				//Info.ReceivedBox.SelectionStart = Info.ReceivedBox.Text.Length
				
			}
			
		}
		
		private void DisplayConnection(string InputText)
		{
			
			if (this.Disposing == false)
			{
				
				Info.Default.ConnectionBox.Items.Add(InputText);
				
			}
			
		}
		
		private void DisplayError(string InputText)
		{
			
			if (this.Disposing == false)
			{
				
				if (Info.Default.ErrorBox.Text == null)
				{
					
					Info.Default.ErrorBox.Text = InputText;
					
				}
				else
				{
					
					Info.Default.ErrorBox.Text += "\r\n" + InputText;
					
				}
				
				//Info.ErrorBox.SelectionStart = Info.ErrorBox.Text.Length
				
			}
			
		}
		
#endregion
		
#region NetSock Events
		
		public void NetSocketData(byte[] Data)
		{
			
			string DecodedData = System.Text.Encoding.UTF8.GetString(Data);
			
			if (ConsoleBox.InvokeRequired)
			{
				
				SetTextCallback Del = new SetTextCallback(DisplayData);
				this.Invoke(Del, new string[] {DecodedData});
				
			}
			else
			{
				
				DisplayData(DecodedData);
				
			}
			
		}
		
		public void NetSocketError(string Data)
		{
			
			if (ConsoleBox.InvokeRequired)
			{
				
				SetTextCallback Del = new SetTextCallback(DisplayError);
				this.Invoke(Del, new string[] {Data});
				
			}
			else
			{
				
				DisplayError(Data);
				
			}
			
		}
		
		public void NetSocketConnection(int ID, bool Connected)
		{
			
			string Message = null;
			
			if (Connected == true)
			{
				
				Message = "Client " + ID.ToString() + " connected.";
				
			}
			else
			{
				
				Message = "Client " + ID.ToString() + " disconnected.";
				
			}
			
			if (ConsoleBox.InvokeRequired)
			{
				
				SetTextCallback Del = new SetTextCallback(DisplayConnection);
				this.Invoke(Del, new string[] {Message});
				
			}
			else
			{
				
				DisplayConnection(Message);
				
			}
			
		}
		
#endregion
		
#region Menu Items
		
		public void StartToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			ToolStripStatusLabel2.Text = "Listening";
			
			NetSocket.Listen(7900);
			
		}
		
		public void StopToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			ToolStripStatusLabel2.Text = "Not Listening";
			
			NetSocket.StopListening();
			
		}
		
		public void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			DisableTray = true;
			
			this.Close();
			
		}
		
		public void DisconnectAllToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void InformationToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			Info.Default.Show();
			
		}
		
#endregion
		
#region Tray Items
		
		public void ShowToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			this.Show();
			
			this.WindowState = FormWindowState.Normal;
			
		}
		
#endregion
		
	}
	
}
