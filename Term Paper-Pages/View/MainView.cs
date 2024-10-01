namespace Term_Paper_Pages.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            btnPages.Click += delegate { ShowPageView?.Invoke(this, EventArgs.Empty); };
            btnAboutBox.Click += delegate { ShowAboutBoxView?.Invoke(this, EventArgs.Empty); };
            btnHandbook.Click += ShowHelp;
        }

        public event EventHandler ShowPageView;
        public event EventHandler ShowAboutBoxView;

        private void ShowHelp(Object? sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "HelperBook.chm");
        }
    }
}
