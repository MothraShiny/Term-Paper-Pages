namespace Term_Paper_Pages.View
{
    public partial class AboutBoxView : Form
    {
        public AboutBoxView()
        {
            InitializeComponent();

            btnClose.Click += delegate { this.Close(); };
        }


        private static AboutBoxView _instance;
        public static AboutBoxView GetInstace(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new AboutBoxView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }
    }
}
