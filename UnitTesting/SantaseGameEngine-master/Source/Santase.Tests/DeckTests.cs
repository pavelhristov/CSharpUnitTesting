using System;
using NUnit.Framework;
using Santase.Logic.Cards;
using Santase.Logic;

namespace Santase.Tests
{
   [TestFixture]
   public class DeckTests
   {
      /*
       * sorry, nothing here, VS throwing errors for different versions of frameworks everytime I try to run smthing and out of time 
       */
      [Test]
      public void GetNextCard_ShouldThrowIfDeckIsEmpty()
      {
         var deck = new Deck();

         for (int i = 0; i < 24; i++)
         {
            deck.GetNextCard();
         }

         Assert.Throws<InternalGameException>(()=>deck.GetNextCard());

      }
   }
}
