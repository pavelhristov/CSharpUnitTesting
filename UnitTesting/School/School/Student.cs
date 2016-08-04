namespace School
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class Student
   {
      private int id;
      private string name;

      public Student(string name)
      {
         this.ID = Generator.GenerateUniqueId();
         this.Name = name;
      }

      public int ID
      {
         get
         {
            return this.id;
         }
         private set
         {
            if (value< 10000 || value > 99999)
            {
               throw new ArgumentOutOfRangeException("Invalid student number");
            }
            this.id = value;
         }
      }
      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            if (value.Length <=0)
            {
               throw new ArgumentOutOfRangeException("Invalid name");
            }
            if (value == null)
            {
               throw new ArgumentNullException("Name can not be null");
            }
            this.name = value;
         }
      }

      public override string ToString()
      {
         string result = string.Empty;

         result = $"{this.Name}: {this.ID}";

         return base.ToString();
      }
   }
}
