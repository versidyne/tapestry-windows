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
	public partial class Chat
	{
		public Chat()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Chat defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Chat Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Chat();
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
		
#region Events
		
		public void UserInput_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.Shift)
			{
				
				//Do Nothing
				
			}
			else if (e.KeyCode == Keys.Enter)
			{
				
				SendInput();
				
				e.SuppressKeyPress = true;
				
			}
			
		}
		
		public void Chat_Load(System.Object sender, System.EventArgs e)
		{
			
			ChatOutput.ReadOnly = true;
			//TabControl.TabPages.Remove(TabPage)
			UserInput.Focus();
			
			Main.Default.AllowDrop = true;
			ChannelTabs.AllowDrop = true;
			MainContainer.AllowDrop = true;
			MainContainer.Panel2.AllowDrop = true;
			UserInput.AllowDrop = true;
			InputContainer.AllowDrop = true;
			
			CreateChannelTab("Test1", "Test1");
			CreateChannelTab("Test2", "Test2");
			CreateChannelTab("Test3", "Test3");
			CreateChannelTab("Test4", "Test4");
			
		}
		
		private TabPage CreateChannelTab(string Caption, string TabName)
		{
			
			Chat NewForm = new Chat();
			TabPage NewTab = NewForm.ChannelTab;
			
			NewTab.Text = Caption;
			NewTab.Name = TabName;
			
			ChannelTabs.TabPages.Add(NewTab);
			
			NewForm.Dispose();
			
			return NewTab;
			
		}
		
		public void Chat_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			
			e.Cancel = true;
			
			this.Hide();
			
		}
		
		public void ChatOutput_LinkClicked(System.Object sender, System.Windows.Forms.LinkClickedEventArgs e)
		{
			
			System.Diagnostics.Process.Start(e.LinkText);
			
		}
		
		public void UserInput_DragEnter(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				
				e.Effect = DragDropEffects.Copy;
				MessageBox.Show("Text attempt");
				
			}
			else if (e.Data.GetDataPresent(DataFormats.WaveAudio))
			{
				
				MessageBox.Show("Music will soon be supported");
				
			}
			else
			{
				
				e.Effect = DragDropEffects.None;
				
			}
			
		}
		
		private void UserInput_DragDrop(System.Object sender, System.Windows.Forms.DragEventArgs e) //Handles UserInput.DragDrop
		{
			
		}
		
#endregion
		
#region Functions
		
		private void LoadImage()
		{
			
			var OrgData = Clipboard.GetDataObject();
			
			OpenFileDialog.Filter = "All files |*.*";
			OpenFileDialog.Multiselect = true;
			
			if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				
				foreach (string Filename in OpenFileDialog.FileNames)
				{
					
					AddImage(Filename);
					
				}
				
			}
			
			Clipboard.SetDataObject(OrgData);
			
		}
		
		private void AddImage(string ImageLocation)
		{
			
			Image LoadedImage = Image.FromFile(ImageLocation);
			
			Clipboard.SetImage(LoadedImage);
			UserInput.Paste();
			
		}
		
		private void SendInput()
		{
			
			if (Main.Default.NetSocket.Connected == true)
			{
				
				string UserInputString = UserInput.Text;
				
				UserInput.Text = null;
				
				Main.Default.SendText("All", UserInputString);
				
			}
			
		}
		
		public void DisplayText(string Sender, string Receiver, string Text, Font TextFont)
		{
			
			//Dim RtfFormat As TextDataFormat = TextDataFormat.Rtf
			
			//ChatOutput.SelectionFont = TextFont
			
			if (ChatOutput.Text == null)
			{
				
				//ChatOutput.Rtf = Text
				//ChatOutput.AppendText(vbCrLf)
				
			}
			else
			{
				
				//ChatOutput.AppendText(vbCrLf)
				//Dim Temp As String = ChatOutput.Rtf
				//Temp += Text
				//MsgBox(Temp)
				//ChatOutput.Rtf = Temp
				//Dim Data As New DataObject
				//Data.SetData(DataFormats.Rtf, Text)
				//Clipboard.SetDataObject(Data)
				//ChatOutput.Paste(Data.GetData(DataFormats.Rtf))
				ChatOutput.AppendText("\r\n");
				
			}
			
			ChatOutput.AppendText(Sender + ": ");
			ChatOutput.Text += Text;
			ChatOutput.SelectionStart = ChatOutput.Text.Length;
			
		}
		
#endregion
		
		public void Chat_Resize(System.Object sender, System.EventArgs e)
		{
			
			InputContainer.SplitterDistance = 27;
			
		}
		
		public void CutToolStripButton_Click(System.Object sender, System.EventArgs e)
		{
			
			Clipboard.Clear();
			
			//Clipboard.SetText(UserInput.SelectedRtf, TextDataFormat.Rtf)
			
			//UserInput.SelectedRtf = Nothing
			
			UserInput.Cut();
			
		}
		
		public void FontToolStripButton_Click(System.Object sender, System.EventArgs e)
		{
			
			Font SelectedFont = default(Font);
			
			FontDialog1.Font = UserInput.SelectionFont;
			FontDialog1.ShowDialog();
			SelectedFont = FontDialog1.Font;
			
			UserInput.SelectionFont = SelectedFont;
			
		}
		
		public void CopyToolStripButton_Click(System.Object sender, System.EventArgs e)
		{
			
			Clipboard.Clear();
			
			//Clipboard.SetText(UserInput.SelectedRtf, TextDataFormat.Rtf)
			
			UserInput.Copy();
			
		}
		
		public void PasteToolStripButton_Click(System.Object sender, System.EventArgs e)
		{
			
			//UserInput.SelectedRtf = Clipboard.GetText()
			
			UserInput.Paste();
			
		}
		
	}
}
