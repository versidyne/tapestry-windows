using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Forms;

namespace Vexis
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
		
		//Children
		private Update UpdateChild = new Update();
		private About AboutChild = new About();
		private Channels ChannelsChild = new Channels();
		private Login LoginChild = new Login();
		private Plugins PluginsChild = new Plugins();
		
		//Controls
        private Versidyne.Protocols.VADP Protocol = new Versidyne.Protocols.VADP();
		internal Versidyne.Network.NetSock NetSocket = new Versidyne.Network.NetSock();
		internal Versidyne.Network.Http NetGet = new Versidyne.Network.Http();
		
		//Delegates
		private delegate void SetTextCallback(string Data);
		
		//Profile
		private string Username = "guest@versidyne.com";
		internal string Session = "0";
		private string NickName = "Guest";
		//Application
		private string[] Arguments;
		private bool IsLocal = false;
		private bool DisableTray = false;
		//Security
		private string EncPass = null;
		private string CustomEncPass = null;
		private bool Encryption = false;
		private bool CustomEncryption = false;
		//Other
		internal ArrayList Conversations = new ArrayList();
		
#endregion
		
		//Events
		
#region Form Events
		
		public void Main_Load(System.Object sender, System.EventArgs e)
		{
			
			//Check for Arguments
			Arguments = Environment.GetCommandLineArgs();
			
			//Handle Arguments
			if (Arguments.Contains("local"))
			{
				
				IsLocal = true;
				
			}
			
			//Check for Design Mode
			//If Me.DesignMode Then
			//End If
			
			//Login Design Disables
			ChatToolStripMenuItem.Enabled = false;
			ChannelsToolStripMenuItem.Enabled = false;
			ContactsToolStripMenuItem.Enabled = false;
			SecurityToolStripMenuItem.Enabled = false;
			LoginToolStripMenuItem.Enabled = true;
			LogoutToolStripMenuItem.Enabled = false;
			
			//Normal Usage Disables
			OffToolStripMenuItem.Enabled = false;
			
			//Disable Features
			EditToolStripMenuItem2.Visible = false;
			
			//Check for debugger
			if (Debugger.IsAttached)
			{
				
				//IsLocal = True
				//Connect()
				//ChatToolStripMenuItem.Enabled = True
				//LogoutToolStripMenuItem.Enabled = True
				
			}
			
		}
		
		public void Main_Resize(System.Object sender, System.EventArgs e)
		{
			
			if (this.WindowState == FormWindowState.Minimized)
			{
				
				this.Hide();
				
				TrayIcon.ShowBalloonTip(10, "", "Vexis will continue to run in the background.", ToolTipIcon.Info);
				
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
		
#region NetSock Events
		
		public void NetSocketData(byte[] Data)
		{
			
			string DataString = System.Text.Encoding.UTF8.GetString(Data);
			//Dim DecodedData As String()= ProtocolHandler(DataString)
			
			//If Chat.ChatOutput.InvokeRequired Then
			
			//Dim Del As New SetTextCallback(AddressOf Chat.DisplayText)
			//Me.Invoke(Del, New String() {DecodedData(0), DecodedData(1), DecodedData(2)})
			SetTextCallback Del = new SetTextCallback(ProtocolHandler);
			this.Invoke(Del, new string[] {DataString});
			
			
			//Else
			
			//Chat.DisplayText(DecodedData(0), DecodedData(1), DecodedData(2))
			//ProtocolHandler(DataString)
			
			//End If
			
		}
		
		public void NetSocketError(string Data)
		{
			
			MessageBox.Show("Error: " + Data);
			
		}
		
		public void NetSocketConnection(bool Data)
		{
			
			if (Data == true)
			{
				
				ToolStripStatusLabel2.Text = "Connected";
				
				ChatToolStripMenuItem.Enabled = true;
				ChannelsToolStripMenuItem.Enabled = true;
				ContactsToolStripMenuItem.Enabled = true;
				SecurityToolStripMenuItem.Enabled = true;
				LoginToolStripMenuItem.Enabled = false;
				LogoutToolStripMenuItem.Enabled = true;
				
			}
			else
			{
				
				ToolStripStatusLabel2.Text = "Disconnected";
				
				ChatToolStripMenuItem.Enabled = false;
				ChannelsToolStripMenuItem.Enabled = false;
				ContactsToolStripMenuItem.Enabled = false;
				SecurityToolStripMenuItem.Enabled = false;
				LoginToolStripMenuItem.Enabled = true;
				LogoutToolStripMenuItem.Enabled = false;
				
			}
			
		}
		
#endregion
		
		//Functions
		
#region NetSock Functions
		
		internal void SendText(string ToString, string Text)
		{
			
			if (CustomEncryption == true)
			{
				
				Versidyne.Security.Rijndael Encrypter = new Versidyne.Security.Rijndael();
				
				Text = Encrypter.StringEncrypt(Text, CustomEncPass);
				
				SendData(Protocol.Encode(ToString, NickName, "CEncText", Text));
				
			}
			else if (Encryption == true)
			{
				
				Versidyne.Security.Rijndael Encrypter = new Versidyne.Security.Rijndael();
				
				Text = Encrypter.StringEncrypt(Text, EncPass);
				
				SendData(Protocol.Encode(ToString, NickName, "EncText", Text));
				
			}
			else
			{
				
				SendData(Protocol.Encode(ToString, NickName, "Text", Text));
				
			}
			
		}
		
		private void SendData(string Data)
		{
			
			//Encrypt here
			
			byte[] DataBytes = System.Text.Encoding.UTF8.GetBytes(Data);
			
			NetSocket.SendData(DataBytes);
			
		}
		
#endregion
		
#region NetGet Functions
		
		internal bool WebLogin(string Email, string Password)
		{
			
			string Url = "http://api.versidyne.com/?login=" + Email + "&pass=" + Password;
			
			string WebData = NetGet.Retreive(Url);
			
			if (WebData == "0")
			{
				
				return false;
				
			}
			else
			{
				
				Session = WebData;
				Username = Email;
				NickName = Username;
				
				RefreshContacts();
				RetreiveNickname();
				Connect();
				
				return true;
				
			}
			
		}
		
		private void RetreiveNickname()
		{
			
			NickName = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=profile");
			
		}
		
		private void RetreiveEncryption()
		{
			
			EncPass = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=encpass");
			
		}
		
		private void RefreshContacts()
		{
			
			BuddyList.Items.Clear();
			
			string RawContacts = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=associates");
			Array Contacts = RawContacts.Split("<|(row)|>".ToCharArray()[0]);
			string Contact = null;
			string[] Info = null;
			
			foreach (string tempLoopVar_Contact in Contacts)
			{
				Contact = tempLoopVar_Contact;
				
				if (Contact.Contains("<|(cell)|>"))
				{
					
					Info = Contact.Split("<|(cell)|>".ToCharArray()[0]);
					
					if (Info[2] == "online")
					{
						
						BuddyList.Items.Add(Info[1], 1);
						
					}
					else
					{
						
						BuddyList.Items.Add(Info[1], 0);
						
					}
					
				}
				
			}
			
		}
		
		private void Connect()
		{
			
			//Connect to server
			
			if (IsLocal)
			{
				
				NetSocket.Connect("localhost", 7900);
				
			}
			else
			{
				
				string ServerInfo = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=serverlocation");
				string[] Parts = ServerInfo.Split(':');
				
				NetSocket.Connect(Parts[0], int.Parse(Parts[1]));
				
			}
			
		}
		
#endregion
		
#region Protocol Functions
		
		private void ProtocolHandler(string DataString)
		{
			
			Array DecodedData = Protocol.Decode(DataString);
			//Dim ReturnData As String() = Nothing
			Font TextFont = default(Font);
			
			if (DecodedData.Length == 1)
			{
				
				//There is nothing to do because the data was either empty or unformatted.
				//Return ReturnData
				
			}
			else
			{
				
				string Sender = null;
				string Data = null;
				
				bool EncCheck = default(bool);
				
				if (Encryption == true)
				{
					
					EncCheck = true;
					
				}
				else if (CustomEncryption == true)
				{
					
					EncCheck = true;
					
				}
				else
				{
					
					EncCheck = false;
					
				}
				
				if (EncCheck == true)
				{
					
					if ((string) DecodedData.GetValue(7) == "Text")
					{
						
						Sender = (string) (DecodedData.GetValue(5));
						Data = (string) (DecodedData.GetValue(8));
						
					}
					else if ((string) DecodedData.GetValue(7) == "EncText")
					{
						
						Versidyne.Security.Rijndael Encrypter = new Versidyne.Security.Rijndael();
						
						Sender = (string) (DecodedData.GetValue(5));
						Data = Encrypter.StringDecrypt(System.Convert.ToString(DecodedData.GetValue(8)), EncPass);
						
					}
					else if ((string) DecodedData.GetValue(7) == "CEncText")
					{
						
						Versidyne.Security.Rijndael Encrypter = new Versidyne.Security.Rijndael();
						
						Sender = (string) (DecodedData.GetValue(5));
						Data = Encrypter.StringDecrypt(System.Convert.ToString(DecodedData.GetValue(8)), CustomEncPass);
						
					}
					else
					{
						
						Sender = (string) (DecodedData.GetValue(5));
						Data = (string) (DecodedData.GetValue(8));
						
					}
					
				}
				else
				{
					
					Sender = (string) (DecodedData.GetValue(5));
					Data = (string) (DecodedData.GetValue(8));
					
				}
				
				if (Data.Replace(" ", null) == null)
				{
					
					//Return ReturnData
					
				}
				else
				{
					
					//ReturnData = New String() {Sender, DecodedData(2), Data}
					
					//Return ReturnData
					
					TextFont = new Font("Calibri", (float) (9.75F), FontStyle.Regular);
					TextFont = Chat.Default.UserInput.Font;
					
					Chat.Default.DisplayText(Sender, System.Convert.ToString(DecodedData.GetValue(2)), Data, TextFont);
					
				}
				
			}
			
		}
		
#endregion
		
		//Buttons
		
#region Menu Items
		
		public void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			if (NetSocket.Connected)
			{
				
				LogoutToolStripMenuItem.PerformClick();
				
			}
			
			DisableTray = true;
			
			this.Close();
			
		}
		
		public void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			UpdateChild = new Update();
			
			UpdateChild.Show();
			
		}
		
		public void AboutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			AboutChild = new About();
			
			AboutChild.Show();
			
		}
		
		public void AddToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			BuddyList.Items.Add("new@versidyne.com", 0);
			
		}
		
		public void ChannelsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			ChannelsChild = new Channels();
			
			ChannelsChild.Show();
			
		}
		
		public void ChatToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			Chat.Default.Show();
			
		}
		
		public void LoginToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			LoginChild = new Login();
			
			LoginChild.Show();
			
		}
		
		public void RefreshToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			RefreshContacts();
			
		}
		
		//Security
		
		public void OnToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			RetreiveEncryption();
			
			Encryption = true;
			
			OnToolStripMenuItem.Enabled = false;
			OffToolStripMenuItem.Enabled = true;
			
		}
		
		public void OffToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			Encryption = false;
			CustomEncryption = false;
			
			EncPass = null;
			CustomEncPass = null;
			
			CustomToolStripMenuItem.Enabled = true;
			OnToolStripMenuItem.Enabled = true;
			OffToolStripMenuItem.Enabled = false;
			
		}
		
		public void CustomToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			string InputPass = Interaction.InputBox("What would you like the password to be?", "Custom Encryption", null, -1, -1);
			
			if (InputPass == null)
			{
				
				MessageBox.Show("A password is required for custom encryption.");
				
			}
			else
			{
				
				CustomEncPass = InputPass;
				
				CustomEncryption = true;
				
				CustomToolStripMenuItem.Enabled = false;
				OffToolStripMenuItem.Enabled = true;
				
			}
			
		}
		
		public void LogoutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			if (NetSocket.Connected)
			{
				
				NetSocket.Disconnect();
				
			}
			
		}
		
		public void PluginsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			PluginsChild = new Plugins();
			
			PluginsChild.Show();
			
		}
		
		public void ExitToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			
			ExitToolStripMenuItem.PerformClick();
			
		}
		
		public void DeleteToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			
			if (BuddyList.SelectedItems.Count > 0)
			{
				
				ListViewItem Buddy = default(ListViewItem);
				
				foreach (ListViewItem tempLoopVar_Buddy in BuddyList.SelectedItems)
				{
					Buddy = tempLoopVar_Buddy;
					
					Buddy.Remove();
					
				}
				
			}
			
		}
		
		public void EditToolStripMenuItem2_Click(System.Object sender, System.EventArgs e)
		{
			
			if (BuddyList.SelectedItems.Count > 0)
			{
				
				ListViewItem Buddy = default(ListViewItem);
				
				foreach (ListViewItem tempLoopVar_Buddy in BuddyList.SelectedItems)
				{
					Buddy = tempLoopVar_Buddy;
					
					Buddy.Text = "edited@versidyne.com";
					
				}
				
			}
			
		}
		
#endregion
		
#region Notify Icon
		
		public void ShowToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			this.Show();
			
			this.WindowState = FormWindowState.Normal;
			
		}
		
#endregion
		
	}
}
