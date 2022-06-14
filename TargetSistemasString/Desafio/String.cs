
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua frase: ");
            string StringOriginal = Console.ReadLine();
            string StringNova = string.Empty;
            for(int i = (StringOriginal.Length -1 );i >= 0; i--)
            {
                StringNova += Convert.ToString(StringOriginal[i]);
            }
            Console.WriteLine("String Invertida: " + StringNova);
            Console.ReadLine();
        }
    }