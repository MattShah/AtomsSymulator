﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomsSymulator
{
    class Point
    {
        private Vector2D position;
        private Vector2D speed;
        private double r;

        public Point()
        {

        }

        public State SaveState()
        {
            throw new NotImplementedException();
        }

        public void RecoverState(State state)
        {
            throw new NotImplementedException();
        }
    }
}
