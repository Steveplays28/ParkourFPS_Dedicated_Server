using System;
using System.Collections.Generic;
using System.Text;

namespace ParkourFPS_Dedicated_Server
{
    class GameLogic
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
