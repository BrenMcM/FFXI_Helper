using FFXi.Entourage_2.MapAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFXi.Entourage_2.MapAI
{
    public static class WorldMap
    {

        private static MapViewer _MapViewer;
        public static MapViewer MapViewer
        {
            get { return _MapViewer ?? (_MapViewer = new MapViewer()); }
            set { _MapViewer = value; }
        }

        private static Dictionary<string, Map> _maps;        
        public static Dictionary<string, Map> Maps 
        {
            get { return _maps ?? (_maps = new Dictionary<string, Map>()); }
            set { _maps = value; }
        }
        
        public static void AddPointToMap(string mapName, int x, int y, int z)
        {
            Map temp;
            if (Maps.TryGetValue(mapName, out temp))
            {
                Maps[mapName].AddPosition(x, y, z);
            } else
            {
                Maps.Add(mapName, new Map());
                Maps[mapName].AddPosition(x, y, z);
            }
        }

        public static int GetMaxX(string mapName)
        {
            Map temp;
            if (Maps.TryGetValue(mapName, out temp))
            {
                return temp.MapPoints.Select(y => y.Value.X).Max(x => x);
            }
            return -1;
        }

        public static int GetMaxY(string mapName)
        {
            Map temp;
            if (Maps.TryGetValue(mapName, out temp))
            {
                return temp.MapPoints.Select(y => y.Value.Y).Max(x => x);
            }
            return -1;
        }

        public static byte[,] GetMapGrid(string mapName)
        {
            Map temp;
            if (Maps.TryGetValue(mapName, out temp))
            {
                return temp.GetMapGrid2D();
            }
            return null;
        }
    }
}
