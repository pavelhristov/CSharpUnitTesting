using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Moq;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Tests
{
   [TestFixture]
   public class BattleManagerTests
   {
      //[Test]
      //public void Constructor_ShouldInstantiateObject()
      //{
      //   var mockedCreature = new Mock(ICreature)
      //}

      [Test]
      public void Attack_ShouldMakeAttackingAndDefendingCreaturesCallStartNewTurnOnceForEachCreature()
      {

      }
   }

   public class MockedBattleManager:BattleManager
   {
      public MockedBattleManager(ICreaturesFactory creaturesFactory,
         ILogger logger)
         : base(creaturesFactory, logger)
      {

      }
      protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
      {
         return base.GetByIdentifier(identifier);
      }
   }

}
