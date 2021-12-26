// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace StructureStack
{
   class Program
   {
        static void Main ()
        {
           var s = new Pilha();
          
           s.Stack(1);
           s.Stack(10);
           s.Stack(100);
           s.Stack(1000);
           Console.WriteLine(s.Unstacks());
           Console.WriteLine(s.Unstacks());
           Console.WriteLine(s.Unstacks());
           Console.WriteLine(s.Unstacks());

           s.Stack(1000);
           s.Stack(100);
           s.Stack(10);
           s.Stack(1);
           Console.WriteLine(s.Unstacks());
           Console.WriteLine(s.Unstacks());
           Console.WriteLine(s.Unstacks());
           Console.WriteLine(s.Unstacks());
        } 

   }
 
}