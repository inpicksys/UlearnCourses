﻿namespace Mazes
{
	public static class PyramidMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			Direction currentDirection = Direction.Right;
			for (int i = 0; i < (height - 2) / 2; i += 1)
			{
				Move(robot, width - 3, currentDirection);
				Move(robot, 2, Direction.Down);
			}
			Move(robot, width - 3, currentDirection);
		}
		private static void Move(Robot robot, int steps, Direction direction)
		{
			for (int i = 0; i < steps; i++)
				robot.MoveTo(direction);
		}
	}
}