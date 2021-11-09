using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
   [TestFixture]
   public class ErrorLoggerTests
   {
      private ErrorLogger logger;

      [SetUp]
      public void Init()
      {
         logger = new ErrorLogger();
      }

      [Test]
      public void Log_WhenCalled_SetTheLastErrorProperty()
      {
         logger.Log("Test");

         Assert.That(logger.LastError, Is.EqualTo("Test"));
      }

      [Test]
      [TestCase(null)]
      [TestCase("")]
      [TestCase(" ")]
      public void Log_InvalidError_ThrowArgumentNullException(string error)
      {
         Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
      }

      [Test]
      public void Log_ValidError_RaisErrorLoggerEvent()
      {
         var id = Guid.Empty;
         logger.ErrorLogged += (sender, args) => { id = args; };

         logger.Log("Event");

         Assert.That(id,Is.Not.EqualTo(Guid.Empty));
      }
   }
}