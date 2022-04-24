﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyDuty.Data.Components;
using DailyDuty.Enums;
using DailyDuty.Interfaces;
using Dalamud.Interface;
using ImGuiNET;

namespace DailyDuty.Graphical.TabItems.Special
{
    internal class LogDebugTabItem : ITabItem
    {
        public ModuleType ModuleType => ModuleType.LogDebug;

        private readonly InfoBox logOperations = new InfoBox()
        {
            Label = "Log Operations",
            ContentsAction = () =>
            {
                if (ImGui.Button("Purge Log"))
                {
                    Service.LogManager.Log.Messages = new Dictionary<ModuleType, List<LogMessage>>();
                    Service.LogManager.Save();
                }
            }
        };

        private readonly InfoBox logStatus = new InfoBox()
        {
            Label = "Log Status",
            ContentsAction = () =>
            {
                if (Service.LogManager.Log.Messages.Keys.Count == 0)
                {
                    ImGui.Text("No Logs Found");
                }
                else
                {
                    foreach (var key in Service.LogManager.Log.Messages.Keys)
                    {
                        ImGui.Text($"Key: {key} : {Service.LogManager.Log.Messages[key].Count} messages");
                    }
                }
            }
        };

        public void DrawTabItem()
        {
            ImGui.Text("Log Debug Tools");
        }

        public void DrawConfigurationPane()
        {
            ImGuiHelpers.ScaledDummy(10.0f);

            logOperations.DrawCentered(0.80f);

            ImGuiHelpers.ScaledDummy(30.0f);
            logStatus.DrawCentered(0.80f);
            
            ImGuiHelpers.ScaledDummy(10.0f);
        }
    }
}