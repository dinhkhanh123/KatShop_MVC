using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KatShop.Extension
{
    public static class Extension
    {
        public static string ToVnd(this double donGia)
        {
            return donGia.ToString("#,##0") + "VND";
        }

        public static string ToTitleCase(string str)
        {
            string result = str;
            if (!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' ');
                for(int i = 0; i < words.Length; i++)
                {
                    var s = words[i];
                    if(s.Length > 0)
                    {
                        words[i] = s[0].ToString().ToUpper() + s.Substring(1);
                    }
                }
                result = string.Join(" ", words);
            }
            return result;
        }

        public static string ToUrlFriendly(this string url)
        {
            var result = url.ToLower().Trim();      
            result = Regex.Replace(result, "[^a-z0-9]", "");
            result = Regex.Replace(result, "(-)+", "-");
            result = Regex.Replace(result, @"[áàạảãâấầậẩẫăắằặẳẵ]", "a");
            result = Regex.Replace(result, @"[éèẹẻẽêếềệểễ]", "e");
            result = Regex.Replace(result, @"[óòọỏõôốồộổỗơớờợởỡ]", "o");
            result = Regex.Replace(result, @"[íìịỉĩ]", "i");
            result = Regex.Replace(result, @"[ýỳỵỉỹ]", "y");
            result = Regex.Replace(result, @"[úùụủũưứừựửữ]", "u");
            result = Regex.Replace(result, @"[đ]", "d");

            return result;

        }

    }
}
