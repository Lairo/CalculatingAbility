﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAbility
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75f;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Divide the roll result by the DividedBy field
            double divided = RollResult / DivideBy;

            // Add AddAmount to the result of that division
            int added = AddAmount + (int)divided;

            // If the result is too small, use Minimum
            if (added < Minimum)            
                Score = Minimum;
            else
                Score = added;
        }
    }
}
