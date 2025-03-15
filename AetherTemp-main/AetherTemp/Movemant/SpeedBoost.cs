using System;
using System.Collections.Generic;
using System.Text;

namespace Troka_Menu.Movment
{
    class SpeedBoost
    {
        public static void SpeedboostMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }

        internal static void SpeedBoostMod()
        {
            throw new NotImplementedException();
        }
    }
}