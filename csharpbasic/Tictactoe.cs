using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    public class Tictactoe
    {
        private Board board;
        public Tictactoe() {
            this.board = new Board();
            board.Display();
            Console.WriteLine("Let's play");
            bool xWin = false;
            bool oWin = false;
            bool draw = false; 
            while(true)
            {
                Console.WriteLine("X turn");
                char pos = Convert.ToChar(Console.ReadLine());
                moveX(pos);
                board.Display();
                if (check())
                {
                    break;
                }

                Console.WriteLine("O turn");
                pos = Convert.ToChar(Console.ReadLine());
                moveO(pos);
                board.Display();
                if (check())
                {
                    break;
                }
            }
        }


        public void moveX(char position)
        {
            board.move(position, 'X');
        }

        public void moveO(char position)
        {
            board.move(position, 'O');
        }
        
        public bool check()
        {
            if (board.checkX())
            {
                Console.WriteLine("X win");
                return true;
            }
            else if (board.checkO())
            {
                Console.WriteLine("O win");
                return true;
            }
            else if (board.checkDraw())
            {
                Console.WriteLine("Draw");
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Board 
    {
        private char[,] matrix; 
        public Board()
        {
            this.matrix = new char[3, 3] { { '1','2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        }

        public void Display()
        {
            for(int i = 0; i < matrix.GetLength(0); i++) { 
                for(int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }

        public void move(char position, char player)
        {
            bool movable = false;
            if(Char.GetNumericValue(position) > 9)
            {
                Console.WriteLine("Out of bound for board");
                return;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if((matrix[i, j] != 'X' || matrix[i, j] != 'O') && matrix[i,j] == position)
                    {
                        matrix[i, j] = player;
                        movable = true;
                    }
                }
            }
            if (!movable)
            {
                Console.WriteLine("Already marked");
            }
        }

        public bool checkX()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i+2 <= 2 && j+2 <= 2 && (matrix[i, j] == 'X' && matrix[i+1, j+1] == 'X' && matrix[i+2, j+2] == 'X')) return true;
                    else if(j + 2 <= 2 && (matrix[i, j] == 'X' && matrix[i, j + 1] == 'X' && matrix[i, j + 2] == 'X')) return true;
                    else if (i + 2 <= 2 && (matrix[i, j] == 'X' && matrix[i+1, j] == 'X' && matrix[i+2, j] == 'X')) return true;
                }
            }
            return false;
        }

        public bool checkO()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + 2 <= 2 && j + 2 <= 2 && (matrix[i, j] == 'O' && matrix[i + 1, j + 1] == 'O' && matrix[i + 2, j + 2] == 'O')) return true;
                    else if (j + 2 <= 2 && (matrix[i, j] == 'O' && matrix[i, j + 1] == 'O' && matrix[i, j + 2] == 'O')) return true;
                    else if (i + 2 <= 2 && (matrix[i, j] == 'O' && matrix[i + 1, j] == 'O' && matrix[i + 2, j] == 'O')) return true;
                }
            }
            return false;

        }

        public bool checkDraw()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] != 'X' || matrix[i, j] != 'O')
                    {
                        return false;
                    }
                }
            }
            if(!checkX() && !checkO())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
