﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownGridBasedEngine
{
    class KamikazeRobot : Enemy     
    {
        public KamikazeRobot(int x, int y, Map m) : base(x, y, m, 0.60f) // Speedfactor changed there
        {
            _Hp = 10;
            // _Weapon = SelfService;
        }

    }
}