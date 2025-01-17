﻿using DailyDuty.Data;
using DailyDuty.System;
using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Aetherytes;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Game.ClientState.Party;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.Game.Gui.Toast;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;
using Dalamud.Plugin;

namespace DailyDuty
{
    public class Service
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [PluginService] public static DalamudPluginInterface PluginInterface { get; private set; }
        [PluginService] public static ChatGui Chat { get; private set; }
        [PluginService] public static ClientState ClientState { get; private set; }
        [PluginService] public static PartyList PartyList { get; private set; }
        [PluginService] public static CommandManager Commands { get; private set; }
        [PluginService] public static Condition Condition { get; private set; }
        [PluginService] public static DataManager DataManager { get; private set; }
        [PluginService] public static Framework Framework { get; private set; }
        [PluginService] public static ObjectTable ObjectTable { get; private set; }
        [PluginService] public static GameGui GameGui { get; private set; }
        [PluginService] public static AetheryteList AetheryteList { get; private set;}
        [PluginService] public static ToastGui Toast { get; private set; }

        public static TeleportManager TeleportManager { get; set; }
        public static TimerManager TimerManager { get; set; }
        public static ModuleManager ModuleManager { get; set; }
        public static WindowManager WindowManager { get; set; }
        public static AddonManager AddonManager { get; set; }
        public static WindowSystem WindowSystem { get; } = new WindowSystem("DailyDuty");
        public static Configuration Configuration { get; set; }

        public static bool LoggedIn = false;

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}