namespace Matrix
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var matrix = new CreateMatrix();
            await matrix.GetUserInput();
        }
    }
}