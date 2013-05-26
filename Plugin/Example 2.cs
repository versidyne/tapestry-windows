// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using Versidyne.Plugins;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using Versidyne;
using System.Linq;
// End of VB project level imports


namespace Plugin
{
	public class Example_2 : Versidyne.Plugins.Plugin
	{
		
		
		private Versidyne.Plugins.Host ObjHost;
		
		public void Initialize(Versidyne.Plugins.Host Host)
		{
			
			ObjHost = Host;
			
		}
		
		public string Name
		{
			
			get
			{
				
				return "Example Plugin 2";
				
			}
			
		}
		
		public int Main(Array Args)
		{
			
			ObjHost.ShowFeedback("Main function test.");
			
			return 0;
			
		}
		
	}
	
}
