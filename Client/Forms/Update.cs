// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
//using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace Vexis
{
	public partial class Update
	{
		public Update()
		{
			InitializeComponent();
		}
		
		public void Update_Load(object sender, EventArgs e)
		{
			
			System.Net.WebClient APIClient = new System.Net.WebClient();
			Uri URL = new Uri("http://api.versidyne.com/?session=12345&update=vexis-windows");
			string file = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\update.xml";
			
			APIClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(DownloadProgressCallback);
			APIClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadFileCallBack2);
			
			APIClient.DownloadFileAsync(URL, file);
			
		}
		
		private void DownloadProgressCallback(object sender, System.Net.DownloadProgressChangedEventArgs e)
		{
			
			ProgressBar1.Value = e.ProgressPercentage;
			ToolStripStatusLabel1Output.Text = e.ProgressPercentage.ToString() + " Percent Downloaded";
			
		}
		
		private void DownloadFileCallBack2(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			
			//CheckVersion()
			ProgressBar1.Maximum = 100;
			try
			{
				var doc = XDocument.Load((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\update.xml");
				var doc2 = XDocument.Load((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\update.xml");
				
				var updates = from updater in doc.Descendants() select new {corever = updater.Element("version").Element("corever").Value, soundver = updater.Element("version").Element("soundver").Value, gfxver = updater.Element("version").Element("gfxver").Value};
				
				var updates2 = from updater in doc2.Descendants() select new {oldcorever = updater.Element("version").Element("corever").Value, oldsoundver = updater.Element("version").Element("soundver").Value, oldgfxver = updater.Element("version").Element("gfxver").Value};
				
				var update = updates.ElementAt(0);
				var update2 = updates2.ElementAt(0);
				
				//corever.Text = "core version: " & update.corever;
				//soundver.Text = "sound version: " & update.soundver;
                //gfxver.Text = "graphics version: " & update.gfxver;
                //yourcorever.Text = "your core version: " & update2.oldcorever;
                //yoursoundver.Text = "your sound version: " & update2.oldsoundver;
                //yourgfxver.Text = "your graphics version: " & update2.oldgfxver;
				
				/*if (Update().corever == update2.oldcorever && Update().soundver == update2.oldsoundver && Update().gfxver == update2.oldgfxver)
				{
					//corecompare.Text = "You're up-to-date"
				}
				else if (Update().soundver == update2.oldsoundver && Update().gfxver == update2.oldgfxver)
				{
					//States that the core files need to be updated - EX. .exe, .dll files
					//corecompare.Text = "Core files need to be updated."
					//goes to sub coredownload to download core files
					CoreDownload();
				}
				else if (Update().corever == update2.oldcorever && Update().gfxver == update2.oldgfxver)
				{
					//States that the sound files need to be updated. - Ex. .mp3, .midi files
					//corecompare.Text = "Sound files need to be updated."
					//goes to sub sounddownload to download sound files
					SoundDownload();
				}
				else if (Update().soundver == update2.oldsoundver && Update().corever == update2.oldcorever)
				{
					//States that the graphic files need to be updated. - Ex. .jpg, .png, .gif files
					//corecompare.Text = "Graphic files need to be updated."
					//goes to sub gfxdownload to download graphic files
					GfxDownload();
				}
				else
				{
					//States that all types of files need to be updated.
					//corecompare.Text = "Update required"
					//goes to sub downloadall to download all updates
					DownloadAll();
				}*/
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		
		
		public void CoreDownload()
		{
			
			//downloads core files
			try
			{
				
				System.Net.WebClient APIClient = new System.Net.WebClient();
				APIClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(DownloadProgressCallback);
				
				APIClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadFileUnzip);
				Uri url = new Uri("http://thelegend.crzyproductions.com/core.zip");
				string file = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\core.zip";
				
				
				
				APIClient.DownloadFileAsync(url, file);
				
			}
			catch (Exception ex)
			{
				//Catches error and displays it.
				MessageBox.Show(ex.Message);
			}
			
			//Moves updater.xml out of patch so old one gets replaced.
			string FileToCopy = default(string);
			string NewCopy = default(string);
			FileToCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\updater.xml";
			NewCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\updater.xml";
			//Copies ver.txt to different folder.
			if (System.IO.File.Exists(FileToCopy) == true)
			{
				System.IO.File.Delete("update.xml");
				System.IO.File.Copy(FileToCopy, NewCopy);
			}
			
		}
		
		public void SoundDownload()
		{
			
			//Downloads sound files
			try
			{
				
				System.Net.WebClient APIClient = new System.Net.WebClient();
				Uri url = new Uri("http://thelegend.crzyproductions.com/sound.zip");
				string file = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\sound.zip";
				
				APIClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(DownloadProgressCallback);
				APIClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadFileUnzip);
				
				APIClient.DownloadFileAsync(url, file);
			}
			catch (Exception ex)
			{
				//Catches error and displays it.
				MessageBox.Show(ex.Message);
			}
			
			//Moves updater.xml out of patch so old one gets replaced.
			string FileToCopy = default(string);
			string NewCopy = default(string);
			FileToCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\updater.xml";
			NewCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\updater.xml";
			//Copies ver.txt to different folder.
			if (System.IO.File.Exists(FileToCopy) == true)
			{
				System.IO.File.Delete("updater.xml");
				System.IO.File.Copy(FileToCopy, NewCopy);
			}
			
		}
		
		public void GfxDownload()
		{
			
			//Downloads graphic files
			try
			{
				System.Net.WebClient APIClient = new System.Net.WebClient();
				Uri url = new Uri("http://thelegend.crzyproductions.com/gfx.zip");
				string file = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\gfx.zip";
				
				APIClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(DownloadProgressCallback);
				
				APIClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadFileUnzip);
				
				APIClient.DownloadFileAsync(url, file);
			}
			catch (Exception ex)
			{
				//Catches error and displays it.
				MessageBox.Show(ex.Message);
			}
			
			//Moves updater.xml out of patch so old one gets replaced.
			string FileToCopy = default(string);
			string NewCopy = default(string);
			FileToCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\updater.xml";
			NewCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\updater.xml";
			//Copies ver.txt to different folder.
			if (System.IO.File.Exists(FileToCopy) == true)
			{
				System.IO.File.Delete("updater.xml");
				System.IO.File.Copy(FileToCopy, NewCopy);
			}
			
		}
		
		public void DownloadAll()
		{
			
			//Downloads all Files if Needed
			try
			{
				
				System.Net.WebClient APIClient = new System.Net.WebClient();
				Uri url = new Uri("http://thelegend.crzyproductions.com/core.zip");
				string file = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\core.zip";
				Uri url2 = new Uri("http://thelegend.crzyproductions.com/sound.zip");
				string file2 = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\sound.zip";
				Uri url3 = new Uri("http://thelegend.crzyproductions.com/sound.zip");
				string file3 = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\sound.zip";
				
				APIClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(DownloadProgressCallback);
				
				APIClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadFileUnzip);
				
				APIClient.DownloadFileAsync(url, file);
				APIClient.DownloadFileAsync(url2, file2);
				APIClient.DownloadFileAsync(url3, file3);
				
			}
			catch (Exception ex)
			{
				//Catches error and displays it.
				MessageBox.Show(ex.Message);
			}
			
			//Moves updater.xml out of patch so old one gets replaced.
			string FileToCopy = default(string);
			string NewCopy = default(string);
			FileToCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Patch\\updater.xml";
			NewCopy = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\updater.xml";
			//Copies ver.txt to different folder.
			if (System.IO.File.Exists(FileToCopy) == true)
			{
				System.IO.File.Delete("updater.xml");
				System.IO.File.Copy(FileToCopy, NewCopy);
			}
			
		}
		
		private void DownloadFileUnzip(System.Object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			
			ProgressBar1.Maximum = 100;
			
			//Unzip and install core files.
			
			//Dim zipfile As New FastZip
			try
			{
				if (System.IO.File.Exists("Patch\\core.zip"))
				{
					//This unzips mygame.zip and updates all core files.
					//zipfile.ExtractZip("Patch\core.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " Installed!";
					//Deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\core.zip");
					
				}
				else if (System.IO.File.Exists("Patch\\sound.zip"))
				{
					//this unzips sound.zip and updates all sound files.
					//zipfile.ExtractZip("Patch\sound.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\sound.zip");
					
				}
				else if (System.IO.File.Exists("Patch\\gfx.zip"))
				{
					//this unzips gfx.zip and updates all graphic files.
					//zipfile.ExtractZip("Patch\core.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\core.zip");
					
				}
				else if (System.IO.File.Exists("Patch\\core.zip") && System.IO.File.Exists("Patch\\sound.zip"))
				{
					//this unzips gfx.zip and updates all graphic files.
					//zipfile.ExtractZip("Patch\core.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\core.zip");
					
					//this unzips sound.zip and updates all sound files.
					//zipfile.ExtractZip("Patch\sound.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\sound.zip");
					
				}
				else if (System.IO.File.Exists("Patch\\sound.zip") && System.IO.File.Exists("Patch\\gfx.zip"))
				{
					//this unzips sound.zip and updates all sound files.
					//zipfile.ExtractZip("Patch\sound.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\sound.zip");
					
					//this unzips gfx.zip and updates all graphic files.
					//zipfile.ExtractZip("Patch\gfx.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\gfx.zip");
					
				}
				else if (System.IO.File.Exists("Patch\\core.zip") && System.IO.File.Exists("Patch\\gfx.zip"))
				{
					//this unzips core.zip and updates all core files.
					//zipfile.ExtractZip("patch\core.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\core.zip");
					
					//this unzips gfx.zip and updates all graphic files.
					//zipfile.ExtractZip("patch\gfx.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\gfx.zip");
					
				}
				else if (System.IO.File.Exists("Patch\\core.zip") && System.IO.File.Exists("Patch\\sound.zip") && System.IO.File.Exists("Patch\\gfx.zip"))
				{
					//this unzips core.zip and updates all core files.
					//zipfile.ExtractZip("Patch\core.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\core.zip");
					
					//this unzips sound.zip and updates all sound files.
					//zipfile.ExtractZip("Patch\sound.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\sound.zip");
					
					//this unzips gfx.zip and updates all graphic files.
					//zipfile.ExtractZip("Patch\gfx.zip", ".", "")
					ToolStripStatusLabel1Output.Text = " installed!";
					//deletes the zip folder to free up space.
					System.IO.File.Delete("Patch\\gfx.zip");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		
	}
}
