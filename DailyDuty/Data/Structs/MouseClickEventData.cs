﻿using System.Runtime.InteropServices;
using DailyDuty.Utilities;

namespace DailyDuty.Data.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct MouseClickEventData
    {
        [FieldOffset(0x00)] private fixed byte Data[24];

        [FieldOffset(0x06)] public readonly bool RightClick;

        public bool LeftClick => !RightClick;

        public void Print()
        {
            var resultString = "";

            for (int i = 23; i >= 0; i--)
            {
                resultString += $"{Data[i]:x2}";
            }

            Chat.Debug(resultString);
        }
    }
}
