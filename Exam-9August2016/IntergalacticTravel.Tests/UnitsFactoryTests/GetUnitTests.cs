namespace IntergalacticTravel.Tests.UnitsFactoryTests
{
   using System;
   using NUnit.Framework;
   using Exceptions;

   [TestFixture]
   public class GetUnitTests
   {
      [Test]
      [TestCase("create unit Procyon Gosho 1", typeof(Procyon))]
      [TestCase("create unit Luyten Pesho 2", typeof(Luyten))]
      [TestCase("create unit Lacaille Tosho 3", typeof(Lacaille))]
      public void ShouldReturnNewCorrespondingUnit_WhenAValidCorrespondingCommandIsPassed(string command, Type expectedUnit)
      {
         //Arrange
         var unitsFactory = new UnitsFactory();

         //Act
         var unit = unitsFactory.GetUnit(command);

         //Assert
         Assert.IsInstanceOf(expectedUnit.GetType(), unit.GetType());
      }

      [Test]
      [TestCase("create unit DemonHunter Illidan 1")]
      [TestCase("create unit Witcher Gerald 1")]
      [TestCase("create human timetraveler Marti 1")]
      public void ShouldThrowInvalidUnitCreationCommandException_WhenTheCommandPassedIsNotInTheValidFormat(string command)
      {
         //Arrange
         var unitsFactory = new UnitsFactory();

         //Act & Assert
         Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(command));
      }
   }
}
