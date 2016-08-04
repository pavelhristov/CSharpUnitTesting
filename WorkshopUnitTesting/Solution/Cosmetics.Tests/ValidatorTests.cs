namespace Cosmetics.Tests
{
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using Common;

   [TestClass]
   public class ValidatorTests
   {
      [TestMethod]
      public void CheckIfNull_ShouldThrowNullReferenceExceptionWhenTheParameterObjIsNull()
      {
         object obj = null;

         try
         {
            Validator.CheckIfNull(obj);
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is NullReferenceException, "NullReferenceException was not thrown");
         }
      }

      [TestMethod]
      public void CheckIfNull_ShouldNotThrowAnyExceptionsWhenTheParameterObjIsNotNull()
      {
         object obj = string.Empty;

         try
         {
            Validator.CheckIfNull(obj);
         }
         catch (Exception ex)
         {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
         }
      }

      [TestMethod]
      public void CheckIfStringIsNullOrEmpty_ShouldThrowNullReferenceExceptionWhenTheParameterTextIsNull()
      {
         string obj = null;

         try
         {
            Validator.CheckIfStringIsNullOrEmpty(obj);
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is NullReferenceException, "NullReferenceException was not thrown");
         }
      }
      [TestMethod]
      public void CheckIfStringIsNullOrEmpty_ShouldThrowNullReferenceExceptionWhenTheParameterTextIsEmpty()
      {
         string obj = string.Empty;

         try
         {
            Validator.CheckIfStringIsNullOrEmpty(obj);
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is NullReferenceException, "NullReferenceException was not thrown");
         }
      }

      [TestMethod]
      public void CheckIfStringIsNullOrEmpty_ShouldNotThrowAnyExceptionsWhenTheParameterObjIsNotNullOrEmpty()
      {
         string obj = "pesho";

         try
         {
            Validator.CheckIfStringIsNullOrEmpty(obj);
         }
         catch (Exception ex)
         {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
         }
      }

      [TestMethod]
      public void CheckIfStringLengthIsValid_ShouldThrowIndexOutOfRangeExceptionWhenTheLengthOfTheParameterTextIsLowerThanTheMinimumAllowedValue()
      {
         string text = "O_o";

         try
         {
            Validator.CheckIfStringLengthIsValid(text, 50, 5);
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is IndexOutOfRangeException, "IndexOutOfRangeException was thrown!");
         }
      }

      [TestMethod]
      public void CheckIfStringLengthIsValid_ShouldThrowIndexOutOfRangeExceptionWhenTheLengthOfTheParameterTextIsGreaterThanTheMaximumAllowedValue()
      {
         string text = "O_o";

         try
         {
            Validator.CheckIfStringLengthIsValid(text, 2);
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is IndexOutOfRangeException, "IndexOutOfRangeException was thrown!");
         }
      }

      [TestMethod]
      public void CheckIfStringLengthIsValid_ShouldNotThrowAnyExceptionWhenTheLengthOfTheParameterTextIsInTheAllowedBoundaries()
      {
         string text = "O_o";

         try
         {
            Validator.CheckIfStringLengthIsValid(text, 50, 1);
         }
         catch (Exception ex)
         {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
         }
      }
   }
}
