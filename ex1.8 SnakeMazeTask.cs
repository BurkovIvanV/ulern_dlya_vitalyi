namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            while (robot.Finished == false)
                SnakeGo(robot, width, height);
        }

        public static void SnakeGo(Robot robot, int width, int height)
        {
            int x = 1;
            while (x < width - 2)
            {
                robot.MoveTo(Direction.Right);
                x++;
            }

            robot.MoveTo(Direction.Down);
            robot.MoveTo(Direction.Down);
            while (x > 1)
            {
                robot.MoveTo(Direction.Left);
                x--;
            }

            if (robot.Finished == false)
            {
                robot.MoveTo(Direction.Down);
                robot.MoveTo(Direction.Down);
            }
        }
    }
}