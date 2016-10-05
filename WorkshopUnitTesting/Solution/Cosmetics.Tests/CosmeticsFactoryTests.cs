namespace Cosmetics.Tests
{
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using Engine;
   using MSTestExtensions;

   [TestClass]
   public class CosmeticsFactoryTests:BaseTest
   {
      [TestMethod]
      public void CreateShampoo_ShouldThrowArgumentNullExceptionWhenThePassedNameParameterIsInvalid()
      {
         var factory = new CosmeticsFactory();
         var name = string.Empty;

         var ex = new ArgumentNullException();

         var result = Assert.Throws<ArgumentNullException>(() => factory.CreateShampoo(name, "brand", 17.50m, Common.GenderType.Unisex, 200, Common.UsageType.EveryDay));
         Assert.AreEqual(ex, result);

      }
   }
}
