using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int x = int.Parse(Console.ReadLine()); 
                if(x==0)
                {
                    break;
                }
                if(x % 2 != 0)
                {
                    x += 1;
                }
                int soma = 0;
                for (int i = 0; i < 5; i++)
                {
                    soma += x;
                    x += 2;
                }
                Console.WriteLine(soma);
            }
        }
        
            
    

    


    }
}