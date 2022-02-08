﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mine.Helpers
{
    public static class DiceHelper
    {
        private static Random md = new Random();
        public static bool ForceRollsToNotRandom = false;
        public static int ForceRandomValue = 1;
        public static int RollDice (int rolls, int dice)
        {
            if (ForceRollsToNotRandom)
            {
                return rolls * ForceRandomValue;
            }
            if (rolls < 1)
            {
                return 0;
            }
            if(dice < 1)
            {
                return 0;
            }
            var myReturn = 0;
            for (var i = 0; i< rolls; i++)
            {
                myReturn += md.Next(1, dice + 1);
            }
            return myReturn;
        }
    }
}
