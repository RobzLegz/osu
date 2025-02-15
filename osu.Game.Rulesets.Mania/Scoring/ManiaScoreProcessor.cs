﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Mania.Scoring
{
    internal class ManiaScoreProcessor : ScoreProcessor
    {
        protected override double DefaultAccuracyPortion => 0.99;

        protected override double DefaultComboPortion => 0.01;

        protected override double ClassicScoreMultiplier => 16;
    }
}
