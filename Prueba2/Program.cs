using System;
using RogueSharp;
using RogueSharp.Random;

class Program
{
    static void Main()
    {
        int width = 20, height = 10;
        var random = new DotNetRandom();
        var map = new Map(width, height);

        // Configurar las celdas del mapa
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                bool isWall = (x == 0 || y == 0 || x == width - 1 || y == height - 1);
                map.SetCellProperties(x, y, !isWall, !isWall, !isWall);
            }
        }

        // Dibujar el mapa en la consola
        DrawMap(map);
    }

    static void DrawMap(IMap map)
    {
        for (int y = 0; y < map.Height; y++)
        {
            for (int x = 0; x < map.Width; x++)
            {
                var cell = map.GetCell(x, y);
                Console.Write(cell.IsWalkable ? '#' : '.');
            }
            Console.WriteLine();
        }
    }
}
