﻿using System;
using DailyDuty.Enums;
using DailyDuty.Utilities;
using ImGuiNET;

namespace DailyDuty.Data.Components
{
    public class LogMessage
    {
        public ModuleName ModuleName { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; } = string.Empty;

        public void Draw()
        {
            ImGui.TextColored(Colors.Grey, $"[{Time}]:");
            ImGui.SameLine();
            ImGui.Text(Message);
        }
    }
}