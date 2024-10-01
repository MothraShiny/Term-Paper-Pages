using Microsoft.Data.SqlClient;
using System.Configuration;
using Term_Paper_Pages.Domain;
using Term_Paper_Pages.Presenters;
using Term_Paper_Pages.View;

namespace Term_Paper_Pages
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            PageContext context = new PageContext(sqlConnectionString);
            SQLPageRepository repository = new SQLPageRepository(context);
            PageService pageService = new PageService(repository);

            MainView mainView = new MainView();
            new MainPresenter(mainView, pageService);
            Application.Run(mainView);
        }
    }
}