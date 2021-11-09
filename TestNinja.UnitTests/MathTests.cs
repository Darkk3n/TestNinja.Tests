using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
   [TestFixture]
   public class MathTests
   {
      private Math math;

      [SetUp]
      public void SetUp()
      {
         math = new Math();
      }

      [Test]
      [Ignore("Until I find a better idea")]
      public void Add_WhenCalled_ReturnsSumOfArguments()
      {
         var res = math.Add(1, 2);
         Assert.That(res, Is.EqualTo(3));
      }

      [Test]
      [TestCase(2, 1, 2)]
      [TestCase(1, 2, 2)]
      [TestCase(2, 2, 2)]
      public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expected)
      {
         var res = math.Max(a, b);
         Assert.That(res, Is.EqualTo(expected));
      }

      [Test]
      public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
      {
         var res = math.GetOddNumbers(5);
         Assert.That(res, Is.Not.Empty);

         Assert.That(res.Count(), Is.EqualTo(3));

         Assert.That(res, Is.EquivalentTo(new[] { 1, 3, 5 }));

         //Assert.That(res, Is.Ordered);

         //Assert.That(res, Is.Unique);
      }
   }
}