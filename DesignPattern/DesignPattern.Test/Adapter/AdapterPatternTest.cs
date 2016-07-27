using System;
using DesignPattern.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Test.Adapter
{
    [TestClass]
    public class AdapterPatternTest
    {
        [TestMethod]
        public void HindiAdapter_Test()
        {
            var adapter = new HindiSummarizeAdapter(new SummarizeBot());
            string hindiSummary = adapter.SummarizeHindiText("text in Hindi");
        }
    }
}
