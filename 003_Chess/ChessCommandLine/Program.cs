


namespace ChessCommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower(Figur.Color.BLACK, 8, 'A');
            tower.MakeRandomMove();
        }
    }
}
