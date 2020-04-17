using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OctanicLib;

namespace OctanicLib.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ListExtensionTest
    {
        [TestMethod]
        public void Shuffle5Numbers()
        {
            IList<int> liStart = new List<int>() { 1, 2, 3, 4, 5 };
            IList<int> li = new List<int>() { 1, 2, 3, 4, 5 };
            bool tryAgain = false;
            int it=0;

            do
            {
                if (it++ >= 100) Assert.Fail("No Random at all!");

                li.Shuffle();

                for (int i = 0; i < li.Count; i++)
                {
                    if (liStart[i] != li[i])
                    {
                        tryAgain = false;
                        break;
                    }
                    tryAgain = true;
                }

            } while (tryAgain);

            Assert.IsTrue(true);

        }
    }
}
