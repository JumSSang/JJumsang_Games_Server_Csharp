using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrolSky
{
    class UIManager
    {
        public string server_state = null;
        static public UIManager Instacne = new UIManager();
        public Form1 form;
        private UIManager()
        {

        }
        public String GetServerState()
        {
            return server_state;
        }
        public void SetServerState(String text)
        {
            this.server_state = text;
        }
    }
}
