using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
   [TestFixture]
   public class MathTests
   {
      [Test]
      public void Add_WhenCalled_ReturnsSumOfArguments()
      {
         var math = new Math();
         var res = math.Add(1, 2);
         Assert.That(res,Is.EqualTo(3));
      }

      [Test]
      public void Max_FirstArgumentGreater_ReturnFirstArgument()
      {
         var math = new Math();
         var res = math.Max(2, 1);
         Assert.That(res, Is.EqualTo(2));
      }

      [Test]
      public void Max_SecondArgumentGreater_ReturnSecondArgument()
      {
         var math = new Math();
         var res = math.Max(1, 2);
         Assert.That(res, Is.EqualTo(2));
      }

      [Test]
      public void Max_EqualArguments_ReturnSameArgument()
      {
         var math = new Math();
         var res = math.Max(2, 2);
         Assert.That(res, Is.EqualTo(2));
      }
   }
}