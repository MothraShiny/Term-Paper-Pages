using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Term_Paper_Pages.Domain
{
    //Запись как класс сущность (запись в БД)
    public class Page
    {
        [Key]
        [Column]
        public int Id { get; set; } //Id в БД
        [Column]
        public int NumberOfLetters { get; set; } //Количество букв
        [Column]
        public int NumberOfVowels { get; set; } //Количество гласных
        [Column]
        public int NumberOfConsonants { get; set; } //Количество согласных
        [Column]
        public int FontSize { get; set; } //Размер шрифта
        [Column]
        public int NumberOfParagraphs { get; set; } //Число абзацев
        [Column]
        public int PageNumber { get; set; } //Номер страницы
        [Column]
        public int NumberOfLines { get; set; } //Количество строк

        public Page() { }

        public Page(int numberOfLetters, int numberOfVowels, int fontSize, int numberOfParagraphs, int pageNumber, int numberOfLines, int id = 0)
        {
            Id = id;
            NumberOfLetters = numberOfLetters;
            NumberOfVowels = numberOfVowels;
            FontSize = fontSize;
            NumberOfParagraphs = numberOfParagraphs;
            PageNumber = pageNumber;
            NumberOfLines = numberOfLines;
        }

        public void Show()
        {
            Console.WriteLine($"Количество букв:  {NumberOfLetters}, Количество гласных:  {NumberOfVowels}, Количество согласных: {NumberOfConsonants}, Размер шрифта: {FontSize}, Число абзацев {NumberOfParagraphs}, Номер страницы {PageNumber}, Количество строк {NumberOfLetters}");
        }

    }
}
