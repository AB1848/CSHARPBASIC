using System;
class ItrationStatement 
{
    
        static void Main()
        {
            ItrationStatement i = new ItrationStatement();
            i.LearnForloop();
        }
    
    void LearnForloop()//learning for loop 

  {
    {
      Console.WriteLine("world is beautiful");

    } //learning foreach loop 
    int[] numbersa = {34,21,45,34,56,76}; 
     
    foreach (int x in numbersa)

    {
       if (x % 2 == 0)
       {
          Console.WriteLine ($"{x} is even");

       } 
       else
       {
           Console.WriteLine($"{x} is odd");
        }
    }//learning while loop and do while loop
//       void LearnWhileLoop()
//       {
//         char confirm='y';

//         while(confirm=='y')

//         {
//             Console.WriteLine("i am beautiful");
//             Console.WriteLine("want to contd.");
//             confirm=Console.ReadKey().KeyChar;

//         }
//         do
//         {
//             Console.WriteLine("i am beautiful");
//             Console.WriteLine("want to contd.");
//             confirm=Console.ReadKey().KeyChar;
//         }
//         while(confirm=='y');
//       } 

//   }
    
// }