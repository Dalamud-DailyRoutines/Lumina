using System.Collections.Generic;

namespace Lumina.Data
{
    public enum Language : ushort
    {
        /// <summary>
        /// No language
        /// </summary>
        None,
        Japanese,
        English,
        German,
        French,
        ChineseSimplified,
        Korean,
        ChineseTraditional = 8
    }

    public class LanguageUtil
    {
        public static readonly Dictionary< Language, string > LanguageMap = new()
        {
            { Language.None, "" },
            { Language.Japanese, "ja" },
            { Language.English, "en" },
            { Language.German, "de" },
            { Language.French, "fr" },
            { Language.ChineseSimplified, "chs" },
            { Language.ChineseTraditional, "tc" },
            { Language.Korean, "ko" },
        };

        public static string GetLanguageStr( Language lang )
        {
            return lang == Language.None ? string.Empty : "tc";
        }
    }
}