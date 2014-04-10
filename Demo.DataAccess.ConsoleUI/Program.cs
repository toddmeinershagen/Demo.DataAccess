using Demo.DataAccess.Dapper;

namespace Demo.DataAccess.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Execute();
        }
    }
}
