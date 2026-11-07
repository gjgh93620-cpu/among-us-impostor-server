namespace Impostor.Api.Innersloth
{
    public static class TextBox
    {
        public static bool IsCharAllowed(char i)
        {
            // Allow CJK punctuation and Chinese characters (Extension A, Unified, Compatibility).
            return i == ' '
                   || (i >= 'A' && i <= 'Z')
                   || (i >= 'a' && i <= 'z')
                   || (i >= '0' && i <= '9')
                   || (i >= 'À' && i <= 'ÿ')
                   || (i >= 'Ѐ' && i <= 'џ')
                   || (i >= 'ㄱ' && i <= 'ㆎ')
                   || (i >= '가' && i <= '힣')
                   || (i >= '\u3000' && i <= '\u303F')
                   || (i >= '\u3400' && i <= '\u4DBF')
                   || (i >= '\u4E00' && i <= '\u9FFF')
                   || (i >= '\uF900' && i <= '\uFAFF');
        }
    }
}
