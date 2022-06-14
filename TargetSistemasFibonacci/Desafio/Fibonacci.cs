    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int  i = 0, num1 = 1, num2 = 1;
             
            while (i < num)
            {
                i = num1 + num2;
                num2 = num1;
                num1 = i;

                if(i == num)
                {
                    Console.WriteLine("Seu número pertence a sequência Fibonacci!");
                    break;
                }
                else if(i > num)
                {
                    Console.WriteLine("Seu Número não pertence a Sequência Fibonacci!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
