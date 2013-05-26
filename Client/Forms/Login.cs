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
	public partial class Login
	{
		public Login()
		{
			InitializeComponent();
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			
			this.Cursor = Cursors.WaitCursor;
			
			if (Main.Default.WebLogin(EmailTextBox.Text, PasswordTextBox.Text) == false)
			{
				
				MessageBox.Show("The system was unable to log you in because the email address you entered is not registered to an account or the password is incorrect.");
				
				PasswordTextBox.Text = null;
				
			}
			else
			{
				
				this.Close();
				
			}
			
			this.Cursor = Cursors.Default;
			
		}
		
		public void Button2_Click(System.Object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
		public void UsernameTextBox_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Enter)
			{
				
				PasswordTextBox.Focus();
				
			}
			
		}
		
		public void PasswordTextBox_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Enter)
			{
				
				Button1.PerformClick();
				
			}
			
		}
		
		public void Login_Load(System.Object sender, System.EventArgs e)
		{
			
			EmailTextBox.Focus();
			
		}
		
	}
}
