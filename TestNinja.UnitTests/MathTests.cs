﻿using NUnit.Framework;
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
      public void Add_WhenCalled_ReturnsSumOfArguments()
      {
         var res = math.Add(1, 2);
         Assert.That(res, Is.EqualTo(3));
      }

      [Test]
      [TestCase(2,1,2)]
      [TestCase(1,2,2)]
      [TestCase(2,2,2)]
      public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expected)
      {
         var res = math.Max(a, b);
         Assert.That(res, Is.EqualTo(expected));
      }
   }
}