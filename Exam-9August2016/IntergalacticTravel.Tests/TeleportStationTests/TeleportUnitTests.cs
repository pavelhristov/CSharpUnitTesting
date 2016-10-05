namespace IntergalacticTravel.Tests.TeleportStationTests
{
   using System;
   using NUnit.Framework;
   using Moq;
   using Contracts;
   using System.Collections.Generic;
   using Mocks;
   using Exceptions;

   [TestFixture]
   public class TeleportUnitTests
   {
      [Test]
      public void ShouldThrowArgumentNullException_WithAMessageThatContainsTheStringUnitToTeleport_WhenIUnitUnitToTeleportIsNull()
      {
         //Arrange
         var mockedLocation = new Mock<ILocation>();
         var expectedMessage = "unitToTeleport";
         var teleportStation = new MockedTeleportStation();

         //Act & Arrange
         Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(null, mockedLocation.Object), expectedMessage);
      }

      [Test]
      public void ShouldThrowArgumentNullException_WithAMessageThatContainsTheStringDestination_WhenILocationDestinationIsNull()
      {
         //Arrange
         var mockedUnit = new Mock<IUnit>();
         var expectedMessage = "unitToTeleport";
         var teleportStation = new MockedTeleportStation();

         //Act & Arrange
         Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(mockedUnit.Object,null), expectedMessage);
      }

      [Test]
      public void ShouldThrowTeleportOutOfRangeException_WithAMessageThatContainsTheStringUnitToTeleportCurrentLocation_WhenAUnitIsTryingToUseTheTeleportStationFromADistantLocation()
         {
         //Arrange
         var mockedUnit = new Mock<IUnit>();
         var mockedLocation = new Mock<ILocation>();
         var mockedNextLocation = new Mock<ILocation>();
         var expectedMessage = "unitToTeleport.CurrentLocation";
         var teleportStation = new MockedTeleportStation();

         // Act & Arrange
         Assert.Throws<TeleportOutOfRangeException>(() => teleportStation.TeleportUnit(mockedUnit.Object, mockedLocation.Object), expectedMessage);
         }
   }
}
