﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDuty.Data
{
    internal static class DataObjects
    {
        public enum HarvestType
        {
            Logging,
            Harvesting,
            Mining,
            Quarrying
        }

        internal class TreasureMap
        {
            public Dictionary<HarvestType, List<uint>> HarvestData { get; init; } = new();
            public uint ItemID { get; init; }
            public int Level { get; init; }
        }

        internal static readonly List<TreasureMap> MapList = new()
        {
            // timeworn leather map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 137 } },
                    { HarvestType.Harvesting, new() { 153, 137 } },
                    { HarvestType.Mining, new() { 153, 155 } },
                    { HarvestType.Quarrying, new() { 147 } }
                },
                ItemID = 6688,
                Level = 40,
            },

            // timeworn goatskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 155 } },
                    { HarvestType.Harvesting, new() { 139 } },
                    { HarvestType.Mining, new() { 139, 145 } },
                    { HarvestType.Quarrying, new() { 139 } }
                },
                ItemID = 6689,
                Level = 45
            },

            //timeworn toadskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 137, 397, 134, 152, 141 } },
                    { HarvestType.Harvesting, new() { 146 } },
                    { HarvestType.Mining, new() { 147, 397 } },
                    { HarvestType.Quarrying, new() { 138, 152, 135, 140 } }
                },
                ItemID = 6690,
                Level = 50
            },

            // timeworn boarskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 137, 397, 134, 152, 141 } },
                    { HarvestType.Harvesting, new() { 146 } },
                    { HarvestType.Mining, new() { 147, 397 } },
                    { HarvestType.Quarrying, new() { 138, 152, 135, 140 } }
                },
                ItemID = 6691,
                Level = 50
            },

            // timeworn peisteskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 137, 397, 134, 152, 141 } },
                    { HarvestType.Harvesting, new() { 146 } },
                    { HarvestType.Mining, new() { 147, 397 } },
                    { HarvestType.Quarrying, new() { 138, 152, 135, 140 } }
                },
                ItemID = 6692,
                Level = 50
            },

            // timeworn archaeoskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 398 } },
                    { HarvestType.Harvesting, new() { 398, 400, 397 } },
                    { HarvestType.Mining, new() { 398, 397 } },
                    { HarvestType.Quarrying, new() { 397 } }
                },
                ItemID = 12241,
                Level = 55
            },

            // timeworn wyvernskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 400, 401 } },
                    { HarvestType.Harvesting, new() { 398, 400, 399, 401, 397 } },
                    { HarvestType.Mining, new() { 398, 397, 399, 401 } },
                    { HarvestType.Quarrying, new() { 400 } }
                },
                ItemID = 12242,
                Level = 60
            },

            // timeworn dragonskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 400, 401 } },
                    { HarvestType.Harvesting, new() { 398, 400, 399, 401, 397 } },
                    { HarvestType.Mining, new() { 398, 397, 399, 401 } },
                    { HarvestType.Quarrying, new() { 400 } }
                },
                ItemID = 12243,
                Level = 60
            },

            // timeworn gaganaskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 621, 612 } },
                    { HarvestType.Harvesting, new() { 614, 610, 622, 613 } },
                    { HarvestType.Mining, new() { 621, 614 } },
                    { HarvestType.Quarrying, new() { 622 } }
                },
                ItemID = 17835,
                Level = 70
            },

            // timeworn gazelleskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 621, 612 } },
                    { HarvestType.Harvesting, new() { 614, 610, 622, 613 } },
                    { HarvestType.Mining, new() { 621, 614 } },
                    { HarvestType.Quarrying, new() { 622 } }
                },
                ItemID = 17836,
                Level = 70
            },

            // timeworn gliderskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 813, 815 } },
                    { HarvestType.Harvesting, new() { 814, 817, 813 } },
                    { HarvestType.Mining, new() { 813, 817 } },
                    { HarvestType.Quarrying, new() { 814, 815 } }
                },
                ItemID = 26744,
                Level = 80
            },

            // timeworn zonureskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 813, 815 } },
                    { HarvestType.Harvesting, new() { 814, 817, 813 } },
                    { HarvestType.Mining, new() { 813, 817 } },
                    { HarvestType.Quarrying, new() { 814, 815 } }
                },
                ItemID = 26745,
                Level = 80
            },

            // timeworn saigaskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 960, 961 } },
                    { HarvestType.Harvesting, new() { 960, 961 } },
                    { HarvestType.Mining, new() { 960, 961 } },
                    { HarvestType.Quarrying, new() { 960, 961 } },
                },
                ItemID = 36611,
                Level = 90
            },

            // timeworn kumbhiraskin map
            new TreasureMap()
            {
                HarvestData = new()
                {
                    { HarvestType.Logging, new() { 960, 961 } },
                    { HarvestType.Harvesting, new() { 960, 961 } },
                    { HarvestType.Mining, new() { 960, 961 } },
                    { HarvestType.Quarrying, new() { 960, 961 } },
                },
                ItemID = 36612,
                Level = 90
            }
        };
    }
}