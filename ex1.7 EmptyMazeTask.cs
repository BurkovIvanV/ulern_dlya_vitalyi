namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void RobotSteps(Robot robot, int size, Direction direction)
        {
            if (size - 2 > 1)
                for (int i = 1; i != size - 2; i++)
                    robot.MoveTo(direction);
        }

        public static void MoveOut(Robot robot, int width, int height)
        {
            RobotSteps(robot, width, Direction.Right);
            RobotSteps(robot, height, Direction.Down);
        }
    }
}