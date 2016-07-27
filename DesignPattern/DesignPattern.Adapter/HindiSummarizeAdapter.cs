using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class HindiSummarizeAdapter : IHindiSummarizeAdapter
    {
        private SummarizeBot _bot = null;

        public HindiSummarizeAdapter() : this(new SummarizeBot()) { }

        public HindiSummarizeAdapter(SummarizeBot bot)
        {
            _bot = bot;
        }

        public string SummarizeHindiText(string text)
        {
            string englishText = TraslateHindiToEnglish(text);
            string englishSummary = _bot.Summarize(englishText);
            string hindiSummary = TranslateEnglishtoHindi(englishSummary);

            return hindiSummary;
        }

        private string TraslateHindiToEnglish(string text)
        {
            return text;
        }

        private string TranslateEnglishtoHindi(string text)
        {
            return text;
        }
    }
}
