using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker
{
    public partial class App : Form
    {
        bool clicking = false;
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int INPUT_MOUSE = 0;
        int sleep = 60000;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };


        public void ClickCurrentLocation()
        {
            Task.Run(() =>
            {
                while (clicking)
                {
                    INPUT i = new INPUT();
                    i.type = INPUT_MOUSE;
                    i.mi.dx = 0;
                    i.mi.dy = 0;
                    i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
                    i.mi.dwExtraInfo = IntPtr.Zero;
                    i.mi.mouseData = 0;
                    i.mi.time = 0;
                    SendInput(1, ref i, Marshal.SizeOf(i));
                    i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
                    SendInput(1, ref i, Marshal.SizeOf(i));
                    System.Threading.Thread.Sleep(sleep);
                }
            });

        }

        public App()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            clicking = true;
            sleep = int.Parse(PollingTextBox.Text);
            ClickCurrentLocation();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            clicking = false;
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
