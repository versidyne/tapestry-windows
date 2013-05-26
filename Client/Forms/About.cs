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
	public partial class About
	{
		public About()
		{
			InitializeComponent();
		}
		
		public void About_Load(System.Object sender, System.EventArgs e)
		{
			
			// Set the title of the form.
			string ApplicationTitle = default(string);
			
			if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title != "")
			{
				ApplicationTitle = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title;
			}
			else
			{
				ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.AssemblyName);
			}
			
			this.Text = string.Format("About {0}", ApplicationTitle);
			
			LabelProductName.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.ProductName;
			LabelVersion.Text = string.Format("Version {0}", (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.ToString());
			LabelCopyright.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Copyright;
			LabelCompanyName.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.CompanyName;
			DescriptionBox.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Description;
			
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
	}
}
