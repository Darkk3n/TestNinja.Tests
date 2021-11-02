using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
   [TestFixture]
   public class ReservationTests
   {
      [Test]
      //Action_Scenario_ExpectedBehavior
      public void CanBeCancelled_UserIsAdmin_True()
      {
         //Arrange
         var reserv = new Reservation();
         //Act
         var res = reserv.CanBeCancelledBy(new User { IsAdmin = true });
         //Assert
         Assert.That(res, Is.True);
      }

      [Test]
      public void CanBeCancelled_MadeByUser_True()
      {
         var user = new User
         {
            IsAdmin = false,
         };
         var reserv = new Reservation
         {
            MadeBy = user
         };
         var res = reserv.CanBeCancelledBy(user);
         Assert.That(res, Is.True);
      }

      [Test]
      public void CanBeCancelled_MadeByAnotherUser_False()
      {
         var reserv = new Reservation
         {
            MadeBy = new User()
         };
         var res = reserv.CanBeCancelledBy(new User());
         Assert.That(res, Is.False);
      }
   }
}