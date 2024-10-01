namespace Term_Paper_Pages.Domain
{
    public class SQLPageRepository : IDisposable
    {
        private bool _disposed = false;

        private readonly PageContext _context;

        public SQLPageRepository(PageContext context)
        {
            _context = context;
        }

        //Получаем все страницы
        public IEnumerable<Page> GetPages() 
        {
            return _context.Pages; 
        }

        //Получаем страницу
        public Page? GetPage(int id) 
        {
            return _context.Pages.Find(id); 
        }

        //Добавляем страницу или изменяем существующую
        public void SavePage(Page page)
        {
            if (page.Id == 0) //Добавляем страницу
            {
                _context.Add(page);
            }
            else //Иначе, изменяем
            {
                Page pageToUpdate = _context.Pages.Where(p => p.Id == page.Id).FirstOrDefault();
                if (pageToUpdate != null)
                {
                    _context.Entry(pageToUpdate).CurrentValues.SetValues(page);
                }
            }
        }

        //Удаляем страницу
        public void DeletePage(int id) 
        {
            Page page = GetPage(id);
            if (page != null)
            {
                _context.Pages.Remove(page);
            }
        }

        //Получение списка страниц, содержащих количество букв больше заданного
        public IEnumerable<Page> GetPagesWhereNumberOfPagesMoreThanValue(int value)
        {
            return _context.Pages.Where(page => page.NumberOfLetters > value).ToList();
        }

        //Получение среднего количества букв на странице
        public double GetAverageNumberOfLetters()
        {
            var value = _context.Pages.Average(page => page.NumberOfLetters); //Проходимся по БД и получаем среднее
            return Math.Round(value, 2); //Округление до двух знаков после точки (0.00)
        }

        //Сохраняем изменения в БД
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        //Отключаемся от БД
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
