namespace WiproExtensions
{
    public static class StringHelper
    {
        /// <summary>
        /// Gets the count of words in a sentence
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static int GetWordCount(this string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return 0;

            //TODO: Improve this logic to handle the case where there might be more than one continuous space character
            return sentence.Trim().Split(' ').Length; 
        }
    }
}
