using DevExpress.Office.Utils;
using Net.Coffee.Library.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Net.Coffee.Client
{
    public partial class ViewMain : DevExpress.XtraEditors.XtraForm
    {
        internal static void GetScreenResolution(ref double screenX, ref double screenY)
        {
            Screen myScreen = Screen.FromPoint(Cursor.Position);
            System.Drawing.Rectangle area = myScreen.WorkingArea;
            screenX = area.Width;
            screenY = area.Height;
        }
        private ClientsHub ClientsHub;
        public ViewMain()
        {
            InitializeComponent();
            this.ClientsHub = new ClientsHub();
            
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.BringToFront();

            double dx = 0;
            double dy = 0;

            GetScreenResolution(ref dx, ref dy);

            double x = dx - 480;
            this.Location = new Point((int)x, 0);
        }

        private void ViewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ViewMain_Resize(object sender, EventArgs e)
        {
            //if the form is minimized   
            //hide it from the task bar   
            //and show the system tray icon (represented by the NotifyIcon control)   
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            IViewLocker frm = ServiceLocator.GetService<IViewLocker>();
            frm.Lock();
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            await this.ClientsHub.StartAsync();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.ClientsHub.SendMessage("A", "B");
        }
    }
}
