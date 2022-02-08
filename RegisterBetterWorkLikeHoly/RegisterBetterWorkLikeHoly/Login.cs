using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
namespace RegisterBetterWorkLikeHoly
{
    public partial class Log : Form
    {

        static string name = "Xerox";
        static string ownerid = "2zD2jmxrGy";
        static string secret = "d5c764bcfa825e1fa57e587d28cf5edc35f367ad0b2a01b1332968fac13a35ef";
        static string version = "1.0";
        public static api KeyAuthApp = new api(name, ownerid, secret, version);
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public Log()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        private void Lgn_Click(object sender, EventArgs e)
        {

        }

        private void Rgstr_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Registered");
            }
        }
    }
}
