namespace School
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class Course
   {
      private ICollection<Student> students;

      public Course()
      {
         this.students = new List<Student>();
      }

      public int StudentsCount
      {
         get
         {
            return this.students.Count;
         }
      }

      public void AddStudent(Student student)
      {
         if (this.students.Count >=30)
         {
            throw new OverflowException("Course is full! New student can not be added");
         }
         this.students.Add(student);
      }

      public void RemoveStudent(Student student)
      {
         if (!this.students.Contains(student))
         {
            throw new ArgumentException($"{student.ToString()} does not attend this course!");
         }
         this.students.Remove(student);
      }
   }
}
