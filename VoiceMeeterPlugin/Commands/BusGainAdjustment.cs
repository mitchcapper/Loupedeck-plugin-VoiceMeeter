﻿namespace Loupedeck.VoiceMeeterPlugin.Commands
{
    using Bases;

    using Helper;

    public class BusGainAdjustment : SingleBaseAdjustment
    {
        public BusGainAdjustment() : base(true, true, false, -60, 12) =>
            this.CreateCommands(
                VoiceMeeterHelper.GetHardwareInputCount() + VoiceMeeterHelper.GetVirtualInputCount(),
                "Gain",
                0
            ).ConfigureAwait(false);
    }
}