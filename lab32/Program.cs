using System;

using System.IO;
namespace ConsoleApplication1
{
    class Class1
    {

        static void Main()
        {
            string a = System.IO.File.ReadAllText(@"c:\input.txt");
            char[] b = a.ToCharArray();
           
            
            for (int i = 0; i < b.Length; i++)
            {
                if (i == 0 && b[i] == 's')
                {
                    for (int j = i; j < b.Length; j++)
                    {
                        if (b[j] == ' ')
                        {
                            Console.WriteLine();
                            break;
                        }
                        Console.Write(b[j]);
                    }

                }
                else {
                    if (b[i] == 's' && b[i - 1] == ' ')
                    {
                        for (int j = i; j < b.Length; j++)
                        {
                            if (b[j] == ' ')
                            {
                                Console.WriteLine();
                                break;
                            }
                            Console.Write(b[j]);
                        }
                    }
                } 

                }


            
           
            

        }
    }
}