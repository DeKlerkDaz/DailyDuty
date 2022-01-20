﻿using System;
using System.Collections.Generic;
using System.Numerics;
using DailyDuty.DisplaySystem.DisplayModules;
using Dalamud.Interface;
using ImGuiNET;

namespace DailyDuty.DisplaySystem
{
    internal abstract class TabCategory : IDisposable
    {
        protected Dictionary<string, DisplayModule> Modules = new();
        protected uint FrameID;
        public string CategoryName { get; protected set; } = "Unset CategoryName";
        public string TabName { get; protected set; } = "Unset TabName";

        public void Draw()
        {
            ImGui.Text(CategoryName);
            ImGui.Separator();
            ImGui.Spacing();

            ImGui.BeginChild(FrameID.ToString(), ImGuiHelpers.ScaledVector2(435, 350), true);

            foreach (var (name, module) in Modules)
            {
                module.Draw();
            }

            ImGui.EndChildFrame();

            ImGui.Spacing();
        }

        public void Dispose()
        {
            foreach (var (name, module) in Modules)
            {
                module.Dispose();
            }
        }
    }
}