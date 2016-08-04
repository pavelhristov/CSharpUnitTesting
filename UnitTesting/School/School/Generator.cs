namespace School
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading;
   using System.Threading.Tasks;


   static class Generator
   {
      private static int idCounter;

      static Generator()
      {
         idCounter = 9999;
      }
      public static int GenerateUniqueId()
      {
         return Interlocked.Increment(ref idCounter);
      }
   }
}
