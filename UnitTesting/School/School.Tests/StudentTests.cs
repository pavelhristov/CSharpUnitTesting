namespace School.Tests
{
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class StudentTests
   {
      [TestMethod]
      public void CreateStudent_SettingEmptyNameShouldThrowException()
      {
         try
         {
            string name = "";
            var student = new Student(name);
            Assert.Fail("no exception thrown");
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is ArgumentOutOfRangeException, "ArgumentOutOfRangeException was not thrown");
         }
      }

      [TestMethod]
      public void CreateStudent_SettingNullAsNameShouldThrowException()
      {
         try
         {
            string name = null;
            var student = new Student(name);
            Assert.Fail("no exception thrown");
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is NullReferenceException, "NullReferenceException was not thrown");
         }
      }
      [TestMethod]
      public void CreateStudent_ShouldReturnTrueIfIDIsInTheCorrectRange()
      {
         Student student = new Student("pesho");

         Assert.IsTrue(student.ID > 10000 && student.ID < 99999, "ID is not in the correctrange");
      }

   }
}
