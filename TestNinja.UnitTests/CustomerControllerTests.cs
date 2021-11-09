using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
   [TestFixture]
   public class CustomerControllerTests
   {
      private CustomerController controller;

      [SetUp]
      public void SetUp()
      {
         controller = new CustomerController();
      }

      [Test]
      public void GetCustomer_IdIsZero_ReturnNotFound()
      {
         var res = controller.GetCustomer(0);

         // NotFound
         Assert.That(res, Is.TypeOf<NotFound>());

         //NotFound or one of its derivatives
         //Assert.That(res, Is.InstanceOf<NotFound>());
      }

      [Test]
      public void GetCustomer_IdIsOne_ReturnOk()
      {
         var res = controller.GetCustomer(1);

         Assert.That(res, Is.TypeOf<Ok>());
      }
   }
}