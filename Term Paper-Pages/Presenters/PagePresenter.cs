using Term_Paper_Pages.Domain;
using Term_Paper_Pages.View;


namespace Term_Paper_Pages.Presenters
{
    public class PagePresenter
    {
        //Поля
        private readonly PageView _view;
        private readonly PageService _pageService;
        private readonly BindingSource _pagesBindingSource;

        //Конструктор
        public PagePresenter(PageView view, PageService pageService)
        {
            _pagesBindingSource = new BindingSource();
            _view = view;
            _pageService = pageService;
            //Подписываемся на обработчики для отображения событий
            _view.SearchLettersCountMoreThanEvent += SearchLettersCountMoreThanValue;
            _view.ResetSearchEvent += ResetSearch;
            _view.AddNewEvent += AddNewPage;
            _view.EditEvent += LoadSelectedPageToEdit;
            _view.DeleteEvent += DeleteSelectedPage;
            _view.SaveEvent += SavePage;
            _view.CancelEvent += CancelAction;
            
            _view.SetPageListBindingSource(_pagesBindingSource);
            _view.AverageLettersCount = _pageService.GetAverageNumberOfLetters();

            LoadAllPageList();
            //Показываем view (отображение)
            _view.Show();
        }

        //Методы
        private void LoadAllPageList()
        {
            ResetSearch(this, EventArgs.Empty); 
        }

        private void SearchLettersCountMoreThanValue(object sender, EventArgs e)
        {
            int value = _view.ValueLettersCountMoreThan;
            _pagesBindingSource.DataSource = _pageService.GetPagesWhereNumberOfPagesMoreThanValue(value);
        }

        private void ResetSearch(object? sender, EventArgs e)
        {
            _pagesBindingSource.DataSource = _pageService.GetAllPages(); //Устанавливаем DataSource
        }

        private void AddNewPage(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }
        private void LoadSelectedPageToEdit(object sender, EventArgs e)
        {     
            var page = (Page) _pagesBindingSource.Current;

            _view.PageId = page.Id;
            _view.PageNumberOfLetters = page.NumberOfLetters;
            _view.PageNumberOfVowels = page.NumberOfVowels;
            _view.PageNumberOfСonsonants = page.NumberOfConsonants;
            _view.PageFontSize = page.FontSize;
            _view.PageNumberOfParagraphs = page.NumberOfParagraphs;
            _view.PageNumber = page.PageNumber;
            _view.PageNumberOfLines = page.NumberOfLines;

            _view.IsEdit = true;
            
        }
        private void SavePage(object sender, EventArgs e)
        {
            var model = new Page();
            model.Id = _view.PageId;
            model.NumberOfLetters = _view.PageNumberOfLetters;
            model.NumberOfConsonants = _view.PageNumberOfСonsonants;
            model.FontSize = _view.PageFontSize;
            model.NumberOfParagraphs = _view.PageNumberOfParagraphs;
            model.PageNumber = _view.PageNumber;
            model.NumberOfLines = _view.PageNumberOfLines;
            try
            {
                if (_view.IsEdit)//Изменение
                {
                    _pageService.SavePage(model);
                    _view.Message = "Страница изменена";
                }
                else //Добавление
                {
                    _pageService.SavePage(model);
                    _view.Message = "Страница добавлена";
                }
                _view.IsSuccessful = true;
                LoadAllPageList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
            
        }

        private void CleanviewFields()
        {
            _view.PageId = 0;
            _view.PageNumberOfLetters = 0;
            _view.PageNumberOfVowels = 0;
            _view.PageNumberOfСonsonants = 0;
            _view.PageFontSize = 0;
            _view.PageNumber = 0;
            _view.PageNumberOfParagraphs = 0;
            _view.PageNumberOfLines = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedPage(object sender, EventArgs e)
        {
            try
            {
                var page = (Page) _pagesBindingSource.Current;
                _pageService.RemovePage(page.Id);
                _view.IsSuccessful = true;
                _view.Message = "Страница успешно удалена !";
                LoadAllPageList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "Ошибка, не удалось удалить Страницу";
            }
        }
    }
}
