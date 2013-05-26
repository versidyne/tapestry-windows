using System;

namespace Plugin
{
	public class Fibonacci : Versidyne.Plugins.Plugin
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
				return "Calculate Fibonacci";
			}
			
		}
		public int Main(Array Args)
		{
            int i, n = 10, first = 0, second = 1, next;
            string feedback = String.Empty;
            for (i = 0; i < n; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                if (feedback == String.Empty)
                    feedback += next;
                else
                {
                    feedback += ", ";
                    feedback += next;
                }
            }
            ObjHost.ShowFeedback(feedback);
			return 0;
		}
		
	}
	
}
