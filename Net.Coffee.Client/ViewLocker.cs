using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace Net.Coffee.Client
{
    public partial class ViewLocker : DevExpress.XtraEditors.XtraForm, IViewLocker
    {
        [DllImport("user32", EntryPoint = "SetWindowsHookExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, int hMod, int dwThreadId);
        [DllImport("user32", EntryPoint = "UnhookWindowsHookEx", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int UnhookWindowsHookEx(int hHook);
        [DllImport("user32", EntryPoint = "CallNextHookEx", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int CallNextHookEx(int hHook, int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);
        private struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        private int intLLKey;
        private const int WH_KEYBOARD_LL = 13;
        private delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);
        private bool closeRequested = false;
        private LowLevelKeyboardProcDelegate lowLevel;
        private int LowLevelKeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
        {
            bool blnEat = false;

            switch (wParam)
            {
                case 256:
                case 257:
                case 260:
                case 261:
                    //Alt+Tab, Alt+Esc, Ctrl+Esc, Windows Key,
                    blnEat = ((lParam.vkCode == 9) && (lParam.flags == 32))
                        | ((lParam.vkCode == 27) && (lParam.flags == 32))
                        | ((lParam.vkCode == 27) && (lParam.flags == 0))
                        | ((lParam.vkCode == 91) && (lParam.flags == 1))
                        | ((lParam.vkCode == 92) && (lParam.flags == 1))
                        | ((lParam.vkCode == 73) && (lParam.flags == 0));
                    break;
            }

            if (blnEat == true)
            {
                return 1;
            }
            else
            {
                return CallNextHookEx(0, nCode, wParam, ref lParam);
            }
        }
        private void KillStartMenu()
        {
            int hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow(hwnd, SW_HIDE);
        }
        private void ViewLocker_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    //ViewLogin frm = new ViewLogin();
            //    //DialogResult dialogResult = frm.ShowDialog();
            //    //if (dialogResult == DialogResult.OK)
            //    //{
            //    closeRequested = true;
            //    this.Close();
            //    //}
            //}
            if (e.KeyCode == Keys.F)
            {
                closeRequested = true;
                this.Close();
            }
            //else if (e.KeyCode == Keys.LWin)
            //{
            //    e.SuppressKeyPress = false;
            //}
            //else if (e.KeyCode == Keys.Alt)
            //{
            //    e.SuppressKeyPress = false;
            //}


        }
        private void ViewLocker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeRequested)
            {
                if (UnhookWindowsHookEx(intLLKey) == 0)
                {

                }

                e.Cancel = false;

            }
            else
                e.Cancel = true;
        }
        public ViewLocker()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();

            this.lowLevel = new LowLevelKeyboardProcDelegate(LowLevelKeyboardProc);
            intLLKey = SetWindowsHookEx(
                WH_KEYBOARD_LL,
                lowLevel,
                Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(),
                0);
        }

        public void Lock()
        {
            this.Show();
        }

        public void UnLock()
        {
            this.closeRequested = true;
            this.Close();
        }
    }
}