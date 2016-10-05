namespace Cosmetics.Tests
{
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using Common;
   using Engine;
   using System.Collections.Generic;
   using MSTestExtensions;

   [TestClass]
   public class CommandTests:BaseTest
   {

      [TestMethod]
      public void Parse_ShouldReturnNewCommandWhenTheInputStringIsInTheRequiredValidFormat()
      {
         string input = "CreateCategory ForMale";

         var newCommand = Command.Parse(input);

         Assert.IsInstanceOfType(newCommand,typeof(Command));
      }

      [TestMethod]
      public void Parse_ShouldSetCorrectValuesToTheNewlyReturnedCommandObjectsNameWhenTheInputStringIsInTheValidRequiredFormat()
      {
         var input = "CreateCategory ForMale";

         var newCommand = Command.Parse(input);

         Assert.AreEqual("CreateCategory", newCommand.Name, "Incorrect name");
      }

      [TestMethod]
      public void Parse_ShouldSetCorrectValuesToTheNewlyReturnedCommandObjectsParametersWhenTheInputStringIsInTheValidRequiredFormat()
      {
         var input = "CreateCategory ForMale";

         var newCommand = Command.Parse(input);

         Assert.AreEqual("ForMale", newCommand.Parameters[0], "Incorrect parameters");
      }

      [TestMethod]
      public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringNameWhenTheInputStringThatRepresentsTheCommandNameIsEmpty()
      {
         var input = " ForMale";
         var nameMSG = "Name";
         var expectedMessage = "Name cannot be null or empty.";
         var ex = new ArgumentNullException(expectedMessage);

         var result = Assert.Throws<ArgumentNullException>(() => Command.Parse(input),nameMSG, ExceptionMessageCompareOptions.Contains);
         Assert.AreEqual(ex.Message, result.Message);
      }

      //[TestMethod]
      //public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringNameWhenTheInputStringThatRepresentsTheCommandNameIsNull()
      //{
      //   string input = null;
      //   var expectedMessage = "Object reference not set to an instance of an object.";
      //   var ex = new NullReferenceException(expectedMessage);

      //   var result = Assert.Throws<NullReferenceException>(() => Command.Parse(input), expectedMessage);
      //   Assert.AreEqual(ex.Message, result.Message);
      //}

      [TestMethod]
      public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringListWhenTheInputStringThatRepresentsTheCommandParametersIsEmpty()
      {
         var input = "CreateCategory ";
         var nameMSG = "List";
         var expectedMessage = "List of strings cannot be null or empty.";
         var ex = new ArgumentNullException(expectedMessage);

         var result = Assert.Throws<ArgumentNullException>(() => Command.Parse(input), nameMSG, ExceptionMessageCompareOptions.Contains);
         Assert.AreEqual(ex.Message, result.Message);
      }
   }
}
