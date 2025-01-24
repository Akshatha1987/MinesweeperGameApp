using MinesweeperGame.Models;
using MinesweeperGame.Repositories;
using MinesweeperGame.Services;
namespace MiniMineSweeper
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Mine Sweeper Game");
			GameService gameService = new GameService();
			gameService.GameStart();
		}
	}
}
