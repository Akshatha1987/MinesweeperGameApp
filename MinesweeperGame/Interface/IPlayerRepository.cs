using MinesweeperGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperGame.Interface
{
	public interface IPlayerRepository
	{
		void Move(string direction, Board board, Player player);
	}
}
