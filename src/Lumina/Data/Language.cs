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
        ChineseTraditional,
        Korean,
        ChineseTraditional2,
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
            { Language.ChineseTraditional, "cht" },
            { Language.Korean, "ko" },
            { Language.ChineseTraditional2, "tc" },
        };

        public static string GetLanguageStr( Language lang )
        {
            return LanguageMap[ lang ];
        }
    }
}