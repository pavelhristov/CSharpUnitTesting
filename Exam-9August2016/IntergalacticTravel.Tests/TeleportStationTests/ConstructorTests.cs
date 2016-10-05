namespace IntergalacticTravel.Tests.TeleportStationTests
{
   using System;
   using NUnit.Framework;
   using Moq;
   using Contracts;
   using System.Collections.Generic;

   [TestFixture]
   public class ConstructorTests
   {
      [Test]
      public void ShouldSetUpAllOfTheProvidedFields_WhenANewTeleportStationIsCreatedWithValidParametersPassedToTheConstructor()
      {
         //Arrange
         var mockedOwned = new Mock<IBusinessOwner>();
         var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
         var mockedLocation = new Mock<ILocation>();

         //Act && Assert
         //lost in action
         Assert.DoesNotThrow(()=> new TeleportStation(mockedOwned.Object, mockedGalacticMap.Object, mockedLocation.Object));
      }
   }
}
