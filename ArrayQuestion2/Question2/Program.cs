using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[,] board = new int[3, 3];
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if (board[i, j] != 1 | board[i, j] != 0)
						board[i, j] = rnd.Next(2);
					 Console.WriteLine(board[i, j]);
					
				}
				
			}
			int result= WinX0(board);
			switch (result)
			{
				case -2:
					Console.WriteLine("invalid input");
					break;
				case -1:
					Console.WriteLine("invalid input");
					break;
				case 0:
					Console.WriteLine("A tie!");
					break;
				case 1:
					Console.WriteLine("X Won!");
					break;
				case 2:
					Console.WriteLine("O Won!");
					break;

			}

		}
		private static int WinX0(int[,] board)
		{
			bool checkX =false, checkO = false;
			if (board.GetLength(0)!= 3 & board.GetLength(1) != 3)
				return -1;
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					switch(board[i, j])
					{
						case 1:
							break;
						case 0:
							break;
						default:
							return -2;
					}
						
				}
				
				
			}
			int sum1 = 0,sum2=0,sum3=0,sum4=0;
			
			for (int i = 0; i<board.GetLength(0); i++)
			{
				sum1 += board[0, i];
				sum2 += board[1, 0];
				sum3 += board[2, 0];
				sum4 += board[i, i];
			}
			if (sum1 == 3 | sum2 == 3 | sum3 == 3 | sum4 == 3)
			{
				 checkX = true;
			}
			if (sum1 == 0 | sum2 == 0 | sum3 == 0 | sum4 == 0)
			{
				 checkO = true;
			}
			if (checkX==checkO )
			{
				return 0;
			}
			if (checkX == true)
				return 1;
			else
				return 2;
		}
		
	}
}
