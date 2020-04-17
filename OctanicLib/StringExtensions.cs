using System;
using System.Globalization;
using System.Text;

namespace OctanicLib
{
    public static class StringExtensions
    {
        /// <summary>
        /// Remove accents from a string
        /// </summary>
        /// <param name="text">String to apply</param>
        /// <returns>Another <see cref="string">string</see> without accents</returns>
        public static string RemoveAccents(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
