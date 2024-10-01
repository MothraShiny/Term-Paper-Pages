using Term_Paper_Pages.Domain;
using Term_Paper_Pages.View;

namespace Term_Paper_Pages.Presenters
{
    public class MainPresenter
    {
        private readonly MainView _mainView;
        private readonly PageService _pageService;

        public MainPresenter(MainView mainView, PageService pageService)
        {
            _mainView = mainView;
            _pageService = pageService;
            _mainView.ShowPageView += ShowPagesView;
            _mainView.ShowAboutBoxView += ShowAboutBoxView;


        }

        //Показать форму "О Программе"
        private void ShowAboutBoxView(object? sender, EventArgs e)
        {
            AboutBoxView view = AboutBoxView.GetInstace(_mainView);
            view.Show();
        }

        //Показать форму "Страницы"
        private void ShowPagesView(object sender, EventArgs e)
        {
            PageView view = PageView.GetInstace(_mainView);
            new PagePresenter(view, _pageService);
        }

    }
}
