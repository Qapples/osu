﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using System.Collections.Generic;

namespace osu.Game.Screens.Multiplayer
{
    public class MatchCreate : ScreenWhiteBox
    {
        protected override IEnumerable<Type> PossibleChildren => new[] {
                typeof(Match)
        };

        public MatchCreate()
        {
            ValidForResume = false;
        }
    }
}
