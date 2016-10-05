namespace IntergalacticTravel.Tests.ResourceFactoryTests
{
   using System;
   using NUnit.Framework;


   [TestFixture]
   public class GetResourcesTests
   {
      [Test]
      [TestCase("create resources gold(20) silver(30) bronze(40)")]
      [TestCase("create resources gold(20) bronze(40) silver(30)")]
      [TestCase("create resources silver(30) bronze(40) gold(20)")]
      [TestCase("create resources silver(30) gold(20) bronze(40)")]
      [TestCase("create resources bronze(40) gold(20) silver(30)")]
      [TestCase("create resources bronze(40) silver(30) gold(20)")]
      public void ShouldReturnANewlyCreatedResourcesObjectWithCorrectlySetUpProperties_NoMatterWhatTheOrder_WhenTheInputStringIsInTheCorrectFormat(string command)
      {
         //Arrange
         var resourceFactory = new ResourcesFactory();
         var expectedResource = new Resources(40, 30, 20);

         //Act
         var resource = resourceFactory.GetResources(command);
         bool flag = false;

         if (expectedResource.BronzeCoins == resource.BronzeCoins &&
            expectedResource.SilverCoins == resource.SilverCoins &&
            expectedResource.GoldCoins == resource.GoldCoins)
         {
            flag = true;
         }

         //Assert
         Assert.IsTrue(flag);
      }

      [Test]
      [TestCase("create resources gold(20) silver(30) bronze(Pesho)")]
      [TestCase("create resources apexisCrystals(150000)")]
      [TestCase("just pesho")]
      public void ShouldThrowInvalidOperationException_WhichContainsTheStringCommand_WhenTheInputStringRepresentsAnInvalidCommand(string command)
      {
         //Arrange
         var resourceFactory = new ResourcesFactory();
         string expectedMessage = "command";

         //Act & Assert
         Assert.Throws<InvalidOperationException>(() => resourceFactory.GetResources(command), expectedMessage);
      }

      [Test]
      [TestCase("create resources gold(20) silver(30) bronze(99999999999999999999999999999999999999999999)")]
      [TestCase("create resources gold(20) silver(99999999999999999999999999999999999999999999) bronze(40)")]
      [TestCase("create resources gold(99999999999999999999999999999999999999999999) silver(30) bronze(40)")]
      public void ShouldThrowOverflowException_WhenTheInputStringCommandIsInTheCorrectFormat_ButAnyOfTheValuesThatRepresentTheResourceAmountIsLargerThanUintMaxValue(string command)
      {
         //Arrange
         var resourceFactory = new ResourcesFactory();

         //Act & Assert
         Assert.Throws<OverflowException>(() => resourceFactory.GetResources(command));
      }
   }
}
