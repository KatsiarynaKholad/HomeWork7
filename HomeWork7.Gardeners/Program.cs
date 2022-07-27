namespace HomeWork7.Gardeners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new Field();

            var field = f.GetData();

            var gardener = new Gardener(field);

            gardener.CreateThreads();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}