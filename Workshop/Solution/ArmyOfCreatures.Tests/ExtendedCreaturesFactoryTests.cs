namespace ArmyOfCreatures.Tests
{
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using ArmyOfCreatures.Extended;
   using ArmyOfCreatures.Extended.Creatures;
   using NUnit.Framework;

   [TestFixture]
   public class ExtendedCreaturesFactoryTests
   {
      [TestCase("AncientBehemoth",typeof(AncientBehemoth))]
      [TestCase("CyclopsKing", typeof(CyclopsKing))]
      [TestCase("Goblin", typeof(Goblin))]
      [TestCase("Griffin", typeof(Griffin))]
      [TestCase("WolfRider", typeof(WolfRaider))]

      [Test]
      public void CreateCreature_ShouldReturnCoeespondingCreatureInstance_When()
      {
         var extendedCreaturesFactory = new ExtendedCreaturesFactory();

         //Act
         var actualCreature = extendedCreaturesFactory.CreateCreature(creatureName);

         //Assert
         Assert.IsInstanceOf(expectedCreatureType, actualCreature);
      }

      [Test]
      public void CreateCreature_()
      {
         var extendedCreatureFactory = new ExtendedCreaturesFactory();
         var invalidCreatureName = "woejihfdoaeir523454358dsaf";

         var exc = Assert
      }
   }
}
