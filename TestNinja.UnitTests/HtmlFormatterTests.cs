using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
   [TestFixture]
   public class HtmlFormatterTests
   {

      [Test]
      public void FormatAsBold_WhenCalled_ShouldEncloseWithStringElement()
      {
         var formatter = new HtmlFormatter();

         var res = formatter.FormatAsBold("abc");

         //Specific
         Assert.That(res, Is.EqualTo("<strong>abc</strong>"));

         //More general
         //Assert.That(res, Does.StartWith("<strong>"));
         //Assert.That(res, Does.EndWith("</strong>"));
         //Assert.That(res, Does.Contain("abc"));
      }
   }
}