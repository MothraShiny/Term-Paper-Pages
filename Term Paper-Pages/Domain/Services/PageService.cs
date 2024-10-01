namespace Term_Paper_Pages.Domain
{
    public class PageService
    {
        private readonly SQLPageRepository _repository;

        public PageService(SQLPageRepository repository) 
        { 
            _repository = repository;
        }

        public List<Page> GetAllPages()
        {
            return _repository.GetPages().ToList(); //Получаем все страницы
        }

        public Page? GetPageDetails(int id) 
        {
            return _repository.GetPage(id); //Получаем Страницу по Id
        }

        public void SavePage(Page page)
        {
            _repository.SavePage(page); //Сохраняем страницу
            _repository.SaveChanges(); //Сохраняем изменения в БД
        }

        public void RemovePage(int id)
        {
            _repository.DeletePage(id); //Удаляем страницу по Id
            _repository.SaveChanges(); //Сохраняем изменения в БД
        }

        public List<Page> GetPagesWhereNumberOfPagesMoreThanValue(int value) //Запрос на показ страниц, где Число Страниц больше заданного
        {
            return _repository.GetPagesWhereNumberOfPagesMoreThanValue(value).ToList();
        }

        public double GetAverageNumberOfLetters() //Получаем среднее число букв
        {
            return _repository.GetAverageNumberOfLetters();
        }
    }
}
