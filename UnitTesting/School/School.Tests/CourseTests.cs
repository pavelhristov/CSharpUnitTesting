namespace School.Tests
{
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;


   [TestClass]
   public class CourseTests
   {
      [TestMethod]
      public void AddStudent_AddingValidStudentShouldCorrectlyAdd()
      {
         var course = new Course();

         var student = new Student("pesho");
         course.AddStudent(student);

         Assert.AreEqual(1, course.StudentsCount, "AddStudent does not add student");
      }

      [TestMethod]
      public void AddStudent_ShouldThrowOverflowExceptionIfCourseIsFull()
      {
         var course = new Course();
         try
         {
            for (int i = 0; i < 31; i++)
            {
               var student = new Student($"pesho {i}");
               course.AddStudent(student);
            }
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is OverflowException, "OverflowException was not thrown");
         }
      }

      [TestMethod]
      public void RemoveStudent_ShouldRemoveStudentIfCourseHasThatStudent()
      {
         var course = new Course();

         var student = new Student("pesho");
         course.AddStudent(student);
         course.RemoveStudent(student);

         Assert.AreEqual(0, course.StudentsCount, "RemoveStudent does not remove student");
      }

      [TestMethod]
      public void RemoveStudent_ShouldThrowExceptionIfCourseHasNotThatStudent()
      {
         var course = new Course();
         try
         {
            var student = new Student("pesho");
            course.AddStudent(student);
            course.RemoveStudent(new Student("Gosho"));
         }
         catch (Exception ex)
         {
            Assert.IsTrue(ex is ArgumentException, "ArgumentException was not thrown");
         }
      }
   }
}
