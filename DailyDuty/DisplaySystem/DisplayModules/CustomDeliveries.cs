﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyDuty.ConfigurationSystem;
using Dalamud.Interface;
using ImGuiNET;

namespace DailyDuty.DisplaySystem.DisplayModules
{
    internal class CustomDeliveries : DisplayModule
    {
        private readonly Weekly.CustomDeliveriesSettings settings = Service.Configuration.CustomDeliveriesSettings;

        public CustomDeliveries()
        {
            CategoryString = "Custom Deliveries";
        }

        protected override void DrawContents()
        {
            ImGui.Checkbox("Enabled##CustomDeliveries", ref settings.Enabled);
            ImGui.Spacing();

            if (settings.Enabled)
            {
                ImGui.Indent(15 * ImGuiHelpers.GlobalScale);

                ImGui.Checkbox("Notifications##CustomDeliveries", ref settings.NotificationEnabled);
                ImGui.Spacing();

                ImGui.Indent(-15 * ImGuiHelpers.GlobalScale);
            }

            ImGui.Spacing();
        }

        public override void Dispose()
        {
        }
    }
}