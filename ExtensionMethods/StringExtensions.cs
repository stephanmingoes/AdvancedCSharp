namespace ExtensionMethods
{
    public static class StringExtensions
    {

        public static string Shorten(this string s, int numberOfWords)
        {
            if(s == null)
            {
                throw new NullReferenceException();
            }

            if(numberOfWords <= 0)
            {
                return "";
            }

            var splitString = s.Split(' ');
            
            if(splitString.Count() < numberOfWords )
            {
                return s;
            }

            return string.Join(" ", splitString.Take(numberOfWords)) + "...";

        }

    }
}
