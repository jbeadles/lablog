using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LABlog.Web.Helpers;

namespace LABlog.Tests
{
    [TestClass]
    public class HelpersTest
    {
        [TestMethod]
        public void ToSlugShouldSlugifyStrings()
        {
            string title = "Test Title";
            string title2 = "Test: Title 2";

            string titleSlug = StringHelpers.ToSlug(title);
            string titleSlug2 = StringHelpers.ToSlug(title2);

            Assert.AreEqual(titleSlug, "test-title");
            Assert.AreEqual(titleSlug2, "test-title-2");
        }
    }
}
