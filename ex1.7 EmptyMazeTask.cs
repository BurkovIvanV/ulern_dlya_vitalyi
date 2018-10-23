namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int x = 1, y = 1;
            if (width - 2 > 1)
            {
                while (x != width - 2)
                {
                    robot.MoveTo(Direction.Right);
                    x++;
                }
            }

            if (height - 2 > 1)
            {
                while (y != height - 2)
                {
                    robot.MoveTo(Direction.Down);
                    y++;
                }
            }


        }
    }
}