using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Id3Cleaner
{
    [TestClass]
    public class GreatestCommonLeftSubstringFinderTest
    {
        [TestMethod]
        public void TestNoSubstring()
        {
            Assert.AreEqual("", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(null));
            Assert.AreEqual("", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(new string[] { }));
            Assert.AreEqual("", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(new string[] { "" }));
            Assert.AreEqual("", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(new string[] { "Foo", "Bar", "Zoo", "Vuvuzeela" }));
        }

        [TestMethod]
        public void TestYesSubstring()
        {
            Assert.AreEqual("Minimum", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(
                new String[] { "Minimum1", "Minimum12", "Minimum2" }));
            Assert.AreEqual("Minimum 1", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(
               new String[] { "Minimum 1", "Minimum 12", "Minimum 1 2" }));
            Assert.AreEqual("Minimum ", GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(
               new String[] { "Minimum 1 2 3", "Minimum 1 with a cherry on top", "Minimum   " }));
        }
    }
}
