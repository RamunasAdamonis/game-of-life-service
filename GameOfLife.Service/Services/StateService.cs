using GameOfLife.Service.Entities;
using GameOfLife.Service.Interfaces;

namespace GameOfLife.Service.Services
{
    public class StateService : IStateService
    {

        public void Start(int width, int height)
        {
            var grid = new State
            {
                Grid = new int[width, height]
            };
        }

        /*private void UpdateZone(int x, int y, bool liveCell)
        {
            sbyte state = (liveCell) ? (sbyte)1 : (sbyte)-1;

            // 1 2 3
            // 4   5
            // 6 7 8
            if (x > 0) //Once on first column, ignore 1 4 6
            {
                CellZone[x - 1, y] += state; // 4

                if (y > 0) // once on first row ignore 1
                {
                    CellZone[x - 1, y - 1] += state; // 1
                }
                if (y < YSize - 1) // once on last row ignore 6
                {
                    CellZone[x - 1, y + 1] += state; // 6
                }
            }
            if (x < XSize - 1) // once on last column ignore 3 5 8
            {
                CellZone[x + 1, y] += state; // 5

                if (y > 0) // once on first row ignore 3
                {
                    CellZone[x + 1, y - 1] += state; // 3
                }
                if (y < YSize - 1) // once on last row ignore 8
                {
                    CellZone[x + 1, y + 1] += state; // 8
                }
            }
            if (y > 0) //once on first row ignore 2
            {
                CellZone[x, y - 1] += state; // 2
            }
            if (y < YSize - 1) // once on last row ignore 7
            {
                CellZone[x, y + 1] += state; // 7
            }
        }*/

    }
}
