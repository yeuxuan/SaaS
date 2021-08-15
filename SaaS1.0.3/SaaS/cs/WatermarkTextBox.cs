using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 汤臣一品小区物业管理系统
{
    public partial class WatermarkTextBox : TextBox
    {
        public WatermarkTextBox()
        {
            InitializeComponent();
        }
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string watermarkText;
        public string WatermarkText
        {
            get { return watermarkText; }
            set
            {
                watermarkText = value;
                SetWatermark(watermarkText);
            }
        }

        private void SetWatermark(string watermarkText)
        {
            SendMessage(this.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

    }

}

