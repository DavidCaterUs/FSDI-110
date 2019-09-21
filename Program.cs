using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
          int i     = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 30; i++)
            {
                if( i%2 == 0 )
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
          // new Program ();
        }
        // public Program()
        // {
        //   Console.WriteLine("I am the constructor");
        //
        //   int result = SayHello();
        //
        //   Console.WriteLine(result);
        //
        //   AnotherOne(42);
        //   AnotherOne(12);
        //
        //   Loops();
        //
        //   task1(); // 0 3 6 9 12 15
        //
        //   var res = Sum (21, 21);
        //   System.Console.WriteLine(res); //42
        //
        //   int [] numbers = new int [200];
        //   for ( int i=0; i < 200; i++){
        //     numbers[i] = i + 1;
        //   }
        //
        //   int howMany = CountandPrintOdds(numbers);
        //   Console.WriteLine(howMany);// do boolean

        }



      //   public void Arrays(){
      //     string[] name = new string[10];
      //
      //     int [] number = new int[10];
      //
      //
      //
      //
      //     name[0] = "Kleibert";
      //     name[1] = "Paul";
      //     name[2] = "Tod";
      //     name[3] = "Smith";
      //     name[4] = "James";
      //
      //     numbers [0] = 0;
      //     numbers [1] = 1;
      //     numbers [2] = 2;
      //     numbers [3] = 3;
      //
      //     //read values
      //     System.Console.WriteLine(name[0]);
      //     Console.WriteLine();
      //
      //
      //     //travel the Arrays
      //     for ( int i = 0; i < name.Length; i++)
      //     {
      //       Console.WriteLine(name[i]);
      //     }
      //     for ( int i = 0; i < numbers.Length; j++)
      //     {
      //       Console.WriteLine(name[j]);
      //     }
      //   }
      //
      //   public int Sum ( int a, int b)
      //   {
      //     return a + b;
      //   }
      //
      //
      //   public void task1()
      //   {
      //     for (int i = 0; i < 6; i *= 3)
      //
      //
      //   }
      //
      // public void Loops()
      //   {
      //     for(int i=0; i < 10; i++){
      //       Console.WriteLine("Inside a for loop");
      //     }
      //
      //     int j = 0;
      //     do{
      //       Console.WriteLine("Inside a for loop");
      //       j +=1;
      //     }
      //
      //   }
      //   while(j < 10);
      //
      //   // while
      //   int k = 0;
      //   while (k < 10)
      //   {
      //     Console.WriteLine("Inside a while loop");
      //     k = k + 1;
      //
      //   }
      //
      //
      //   public int SayHello()
      //   {
      //     Console.WriteLine("Hello from a function");
      //
      //     return 42;
      //   }
      //
      //   public void AnotherOne(int val)
      //   {
      //     if (val < 40)
      //     {
      //       Console.WriteLine("Lower than 40");
      //
      //     }
      //     else
      //     {
      //       Console.WriteLine("Greater than 40");
      //     }
      //   }
    }
