namespace IntergalacticTravel.Tests.UnitTests
{
   using System;
   using NUnit.Framework;

   [TestFixture]
   public class PayTests
   {
      [Test]
      public void ShouldThrowNullReferenceException_IfTheObjectPassedIsNull()
      {
         //Arrange
         var newUnit = new Unit(1, "pesho");

         //Act & Assert
         Assert.Throws<NullReferenceException>(() => newUnit.Pay(null));
      }

      [Test]
      public void ShouldDecreaseTheOwnersAmountOfResourcesByTheAmountOfTheCost()
      {
         // could not find how to add resources to the unit as the field is private and the property has no setter
         // removing resources from 0 should overflow and unit resources should be unequal to 0


         //Arrange
         var newUnit = new Unit(1, "pesho");
         var payment = new Resources(1, 2, 3);
         bool flag = false;

         //Act
         newUnit.Pay(payment);
         if (newUnit.Resources.GoldCoins != 0 &&
            newUnit.Resources.SilverCoins != 0 &&
            newUnit.Resources.BronzeCoins != 0)
         {
            flag = true;
         }

         //Assert
         Assert.IsTrue(flag);
      }

      [Test]
      public void ShouldReturnResourceObjectWithTheAmountOfResourcesInTheCostObject()
      {
         //Arrange
         var newUnit = new Unit(1, "pesho");
         var payment = new Resources(1, 2, 3);
         bool flag = false;

         //Act
         var returnedResources = newUnit.Pay(payment);
         if (returnedResources.GoldCoins == payment.GoldCoins &&
            returnedResources.SilverCoins == payment.SilverCoins &&
            returnedResources.BronzeCoins == payment.BronzeCoins)
         {
            flag = true;
         }

         //Assert
         Assert.IsTrue(flag);
      }
   }
}
