using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class WordTests
  {
    // Test methods go here
    [TestMethod]
    public void IsPalindrome_WordIsPalindrome_False()
    {
      Word testWord = new Word();
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(false,testWord.IsPalindrome());
    }
  }
}