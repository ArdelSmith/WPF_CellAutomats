using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Program
{
    public static class P
    {
        static ClassicCell[][] Layer = new ClassicCell[10][];
        public static void CreateStartLayer()
        {
            for (int i = 0; i < 10; i++)
            {
                Layer[i] = new ClassicCell[10];
                for (int j = 0; j < 10; j++)
                {
                    Layer[i][j] = new ClassicCell();
                }
            }
            Layer[1][1].SetCellStatus(CellStatus.Alive);
            Layer[2][2].SetCellStatus(CellStatus.Alive);
            Layer[3][1].SetCellStatus(CellStatus.Alive);
        }
        public static void CountNeighbours()
        {
            // в двух циклах обходим все ячейки двумерного массива
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // счиатем соседей
                    for (int k = i - 1; k < i + 2; k++)
                    {
                        for (int l = j - 1; l < j + 2; l++)
                        {
                            // если проверяемая нами клетка не исходная
                            if (!(k == i && l == j))
                            {
                                try
                                {
                                    if (Layer[k][l].GetCellStatus() == CellStatus.Alive)
                                    {
                                        Layer[i][j].SetCellsNearby(Layer[i][j].GetCellsNearby() + 1);
                                    }
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                }
            }
        }
        public static void GenerateNewLayer()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Layer[i][j].GetCellStatus() == CellStatus.Alive)
                    {
                        if (Layer[i][j].GetCellsNearby() < 2) Layer[i][j].SetCellStatus(CellStatus.Dead);
                    }
                    else
                    {
                        if (Layer[i][j].GetCellsNearby() == 3) Layer[i][j].SetCellStatus(CellStatus.Alive);
                    }
                    Layer[i][j].SetCellsNearby(0);
                }
            }
        }
        public static void ShowLayer()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Layer[i][j].GetCellStatus() == CellStatus.Alive)
                    {
                        Console.Write("X");
                        if (j == 9) Console.Write("\n");
                    }
                    else
                    {
                        Console.Write("O");
                        if (j == 9) Console.Write("\n");
                    }
                }
            }
        }
    }
}
