using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public static class Turkish1
    {
        public static string TurkishCharacter(string text)
        {

            text = text.Replace("İ", "\u0130");

            text = text.Replace("ı", "\u0131");

            text = text.Replace("Ş", "\u015e");

            text = text.Replace("ş", "\u015f");

            text = text.Replace("Ğ", "\u011e");

            text = text.Replace("ğ", "\u011f");

            text = text.Replace("Ö", "\u00d6");

            text = text.Replace("ö", "\u00f6");

            text = text.Replace("ç", "\u00e7");

            text = text.Replace("Ç", "\u00c7");

            text = text.Replace("ü", "\u00fc");

            text = text.Replace("Ü", "\u00dc");

            return text;
        }
    }
}
