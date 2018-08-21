namespace GameOfLife.Service.Entities
{
    public class State
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int[,] Grid { get; set; }

    }
}
