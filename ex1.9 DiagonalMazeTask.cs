namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int aspectRatio = GetAspectRadio(robot, width, height);
            if (width > height)
                DiagonalGo(robot, aspectRatio, Direction.Right, Direction.Down);
            else
                DiagonalGo(robot, aspectRatio, Direction.Down, Direction.Right);
        }

        public static void DiagonalGo(Robot robot, int aspectRatio, Direction directionOne, Direction directionTwo)
        {
            while (!robot.Finished)
            {
                for (var i = 0; i < aspectRatio; i++)
                    robot.MoveTo(directionOne);
                if (robot.Finished == false) robot.MoveTo(directionTwo);
            }
        }
        public static int GetAspectRadio(Robot robot, int width, int height) => 
            width > height ? (width - 2) / (height - 2) : (height - 2) / (width - 2);
        
    }
}