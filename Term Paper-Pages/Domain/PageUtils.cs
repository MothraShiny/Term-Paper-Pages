namespace Term_Paper_Pages.Domain
{
    internal static class PageUtils
    {
        // Возвращает количество гласных
        public static int CountVowels(string str)
        {
            var vowels = new HashSet<char> { 'A', 'E', 'I', 'O', 'U',
                'А', 'У', 'О', 'И', 'Э', 'Ы', 'Я', 'Ю', 'Е', 'Ё' };

            int count = str.ToUpper().Count(vowels.Contains);
            return count;
        }

        // Возвращает количество согласных
        public static int CountСonsonants(string str)
        {
            var consonant = new HashSet<char> { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z',
            'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ'};

            int count = str.ToUpper().Count(consonant.Contains);
            return count;
        }
    }
}
