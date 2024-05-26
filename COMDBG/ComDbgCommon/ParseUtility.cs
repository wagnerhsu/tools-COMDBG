using System;
using System.Collections.Generic;
using System.Linq;

namespace ComDbgCommon
{
    public class ParseUtility
    {
        public static IList<string> ParseLines(string data)
        {
            return data.Split(new[] { '\r','\n' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !x.StartsWith("#")).ToList();
        }
    }
}