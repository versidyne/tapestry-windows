using System;

namespace Plugin
{
    public class Pi : Versidyne.Plugins.Plugin
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
                return "Calculate Pi";
            }

        }
        private double calc(int i, int l)
        {
            if (i == l)
                return 0;
            else
                return 1 + i / (2.0 * i + 1) * calc(i + 1, l);
        }
        public int Main(Array Args)
        {
            double pi;
            string feedback = String.Empty;
            pi = 2 * calc(1, 10);
            if (feedback == String.Empty)
                feedback += pi;
            else
            {
                feedback += ", ";
                feedback += pi;
            }
            ObjHost.ShowFeedback(feedback);
            return 0;
        }

    }

}
