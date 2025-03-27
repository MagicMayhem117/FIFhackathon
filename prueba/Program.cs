using System;
using RogueSharp;

class Program
{
    static void Main()
    {
        int width = 20, height = 10;
        var map = new Map(width, height);

        // Genera un mapa básico con bordes como paredes
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                {
                    map.SetCellProperties(x, y, false, false, false); // Pared
                }
                else
                {
                    map.SetCellProperties(x, y, true, true, true); // Suelo
                }
            }
        }

        // Imprimir el mapa en la consola
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                var cell = map.GetCell(x, y);
                Console.Write(cell.IsWall ? '#' : '.');
            }
            Console.WriteLine();
        }
    }
}
