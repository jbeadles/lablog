using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LABlog.Web.Helpers
{
    public class StringHelpers
    {

        public static string ToSlug(string title)
        {
            string str = title.ToLower();

            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = Regex.Replace(str, @"\s+", " ").Trim();
            str = str.Trim();
            str = Regex.Replace(str, @"\s", "-");

            return str;
        }

    }
}