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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class About : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.Button1 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(About_Load);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.DescriptionBox = new System.Windows.Forms.RichTextBox();
			this.LabelProductName = new System.Windows.Forms.Label();
			this.LabelVersion = new System.Windows.Forms.Label();
			this.LabelCopyright = new System.Windows.Forms.Label();
			this.LabelCompanyName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(194, 239);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//DescriptionBox
			//
			this.DescriptionBox.Location = new System.Drawing.Point(12, 112);
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.ReadOnly = true;
			this.DescriptionBox.Size = new System.Drawing.Size(257, 123);
			this.DescriptionBox.TabIndex = 1;
			this.DescriptionBox.Text = "";
			//
			//LabelProductName
			//
			this.LabelProductName.AutoSize = true;
			this.LabelProductName.Location = new System.Drawing.Point(12, 9);
			this.LabelProductName.Name = "LabelProductName";
			this.LabelProductName.Size = new System.Drawing.Size(39, 13);
			this.LabelProductName.TabIndex = 2;
			this.LabelProductName.Text = "Label1";
			//
			//LabelVersion
			//
			this.LabelVersion.AutoSize = true;
			this.LabelVersion.Location = new System.Drawing.Point(12, 34);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new System.Drawing.Size(39, 13);
			this.LabelVersion.TabIndex = 3;
			this.LabelVersion.Text = "Label2";
			//
			//LabelCopyright
			//
			this.LabelCopyright.AutoSize = true;
			this.LabelCopyright.Location = new System.Drawing.Point(12, 59);
			this.LabelCopyright.Name = "LabelCopyright";
			this.LabelCopyright.Size = new System.Drawing.Size(39, 13);
			this.LabelCopyright.TabIndex = 4;
			this.LabelCopyright.Text = "Label3";
			//
			//LabelCompanyName
			//
			this.LabelCompanyName.AutoSize = true;
			this.LabelCompanyName.Location = new System.Drawing.Point(12, 84);
			this.LabelCompanyName.Name = "LabelCompanyName";
			this.LabelCompanyName.Size = new System.Drawing.Size(39, 13);
			this.LabelCompanyName.TabIndex = 5;
			this.LabelCompanyName.Text = "Label4";
			//
			//About
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 266);
			this.Controls.Add(this.LabelCompanyName);
			this.Controls.Add(this.LabelCopyright);
			this.Controls.Add(this.LabelVersion);
			this.Controls.Add(this.LabelProductName);
			this.Controls.Add(this.DescriptionBox);
			this.Controls.Add(this.Button1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.RichTextBox DescriptionBox;
		internal System.Windows.Forms.Label LabelProductName;
		internal System.Windows.Forms.Label LabelVersion;
		internal System.Windows.Forms.Label LabelCopyright;
		internal System.Windows.Forms.Label LabelCompanyName;
	}
	
}
