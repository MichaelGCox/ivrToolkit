﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ivrToolkit.Core;

namespace SimulatorTest.ScriptBlocks
{
    public class WelcomeScript : AbstractScript
    {
        public override string Description
        {
            get { return "Welcome"; }
        }

        public override IScript Execute()
        {
            // say My welcome message
            Line.PlayFile(@"Voice Files\ThankYou.wav");
            return new MainScript();
        }
    } // class
}