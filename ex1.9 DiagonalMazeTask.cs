namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int aspectRatio;

            if (width > height)
            {
                aspectRatio = (width - 2) / (height - 2);
                DiagonalGo(robot, aspectRatio, Direction.Right, Direction.Down);
            }
            else
            {
                aspectRatio = (height - 2) / (width - 2);
                DiagonalGo(robot, aspectRatio, Direction.Down, Direction.Right);
            }
        }

        public static void DiagonalGo(Robot robot, int aspectRatio, Direction directionOne, Direction directionTwo)
        {
            while (robot.Finished == false)
            {
                for (var i = 0; i < aspectRatio; i++)
                    robot.MoveTo(directionOne);
                if (robot.Finished == false) robot.MoveTo(directionTwo);
            }
        }
    }
}