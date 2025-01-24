using MinesweeperGame.Interface;
using MinesweeperGame.Models;
using MinesweeperGame.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperGame.Tests
{
	public class PlayerRepositoryTests
	{
		private readonly IPlayerRepository _playerRepository;
		private readonly Player _player;
		private readonly Board _board;

		public PlayerRepositoryTests()
		{
			_board = new Board(8, 8);
			_playerRepository = new PlayerRepository();
			_player = new Player();
		}

		[TestCase("up", 0, 0)]
		[TestCase("down", 1, 1)]
		[TestCase("left", 1, 1)]
		[TestCase("right", 1, 1)]
		public void MovePlayer_ShouldUpdatePlayerPosition(string direction, int expectedRow, int expectedCol)
		{
			// Act
			_playerRepository.Move(direction, _board, _player);

			// Assert
			Assert.That(_player.Row, Is.EqualTo(expectedRow));
			Assert.That(_player.Row, Is.EqualTo(expectedCol));
		}
	}
}
