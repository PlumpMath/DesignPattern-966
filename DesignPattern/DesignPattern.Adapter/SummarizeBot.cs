using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class SummarizeBot
    {
        public string Summarize(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException(nameof(text));

            int trimLength = text.Length <= 10 ? text.Length : text.Length - 10;

            return text.Substring(0, trimLength);
        }
    }
}
