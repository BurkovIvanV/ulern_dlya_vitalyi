namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            while (!robot.Finished)
            {
                SnakeGo(robot, width, height, Direction.Right);
                SnakeGo(robot, width, height, Direction.Left);
            }
        }

        public static void SnakeGo(Robot robot, int width, int height, Direction direction)
        {

            for (int x = 1; x < width - 2; x++)
                robot.MoveTo(direction);

            if (!robot.Finished)
            {
                robot.MoveTo(Direction.Down);
                robot.MoveTo(Direction.Down);
            }
        }
    }
}