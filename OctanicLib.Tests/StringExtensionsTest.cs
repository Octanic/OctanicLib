using Microsoft.VisualStudio.TestTools.UnitTesting;
using OctanicLib;
using System;

namespace OctanicLib.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void RemoveAccentsValidWord()
        {
            var test = "João almoço ROLÊ ROLÉ ROLÈ";
            Assert.AreEqual(test.RemoveAccents(), "Joao almoco ROLE ROLE ROLE");
        }
        
        [TestMethod]
        public void RemoveAccentsWithoutReallyNeedIt()
        {
            var test = "the quick brown fox";
            Assert.AreEqual(test.RemoveAccents(), test);
        }

        [TestMethod]
        public void RemoveAccentsFromNothing()
        {
            string test = null;
            Assert.ThrowsException<NullReferenceException>(()=>{ test.RemoveAccents(); });
        }

        [TestMethod]
        public void RemoveAccentsFromEmpty()
        {
            string test = string.Empty ;
            Assert.IsTrue(string.IsNullOrEmpty(test.RemoveAccents()));

        }
        [TestMethod]
        public void TrySomeWeirdCharacters()
        {
            string test = "今一和、友達ーくん。";
            Assert.AreEqual(test, test.RemoveAccents());

        }
    }
}
