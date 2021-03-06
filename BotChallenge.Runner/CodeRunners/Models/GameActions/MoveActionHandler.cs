﻿using System;

namespace BotChallenge.Runner.CodeRunners.Models.GameActions
{
    /// <summary>
    /// Applys to the field move action generated by bote code. Params shuld be - oldX, oldY, newX, newY.
    /// X across width, and y-> height
    /// </summary>
    class MoveActionHandler : IActionHandler
    {
        public Field ApplyStep(string[] stepParams, Field field)
        {
            if (stepParams.Length != 4)
            {
                throw new ArgumentException($"For move action should be provided 4 parameters ( oldX, oldY, newX, newY). But got '{ stepParams.ToString() }'. ");
            }

            int oldX = int.Parse(stepParams[0]);
            int oldY = int.Parse(stepParams[1]);
            int newX = int.Parse(stepParams[2]);
            int newY = int.Parse(stepParams[3]);

            if (field.Points[oldY][oldX] != Point.BlueBot && field.Points[oldY][oldX] != Point.RedBot)
            {
                throw new ArgumentException($"No bot detected on old position  X - { oldX }, Y - { oldY }");
            }

            if (field.Points[newY][newX] != Point.Empty)
            {
                throw new ArgumentException($"Cannot move bot to point ( X - { newX }, Y - { newY } ) because it's not empty. There stands - { field.Points[newY][newX].ToString() }");
            }

            field.Points[newY][newX] = field.Points[oldY][oldX];
            field.Points[oldY][oldX] = Point.Empty;

            return field;
        }
    }
}
