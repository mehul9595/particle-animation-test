﻿using System;

namespace AnimateLib
{
    public class Partical
    {

        private Direction direction;
        private int startLocation;
        private int speed;

        public Partical(char direction, int startLocation, int speed)
        {
            if (!(direction == 'R' || direction == 'L'))
            {
                throw new Exception("Can not determine direction of partical L=Left, R=Right");
            }
            if (direction == 'R')
            {
                this.direction = Direction.Right;
            }
            else
            {
                this.direction = Direction.Left;
            }

            this.speed = speed;
            this.startLocation = startLocation;
        }

        public int LocationAfter(int time)
        {
            if (direction == Direction.Right)
            {
                return (time * speed) + startLocation;
            }
            return startLocation - (time * speed);
        }
    }
    
}
