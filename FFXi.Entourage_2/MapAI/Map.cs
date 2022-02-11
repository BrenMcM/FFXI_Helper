using System;
using System.Collections.Generic;
using System.Linq;

namespace FFXi.Entourage_2.MapAPI
{
    public class Map
    {
        public string Name { get; set; }
        public event EventHandler NewMapPointAddedEvent;
        public Dictionary<string, MapPoint3D> MapPoints { get; set; }
    
        public Map()
        {
            MapPoints = new Dictionary<string, MapPoint3D>();
        }
        
        public void AddPosition(int x, int y, int z)
        {
            var key = $"{x},{y},{z}";
            MapPoint3D temp;
            if(MapPoints.TryGetValue(key, out temp)) {
                return;
            } else
            {
                MapPoints.Add(key, new MapPoint3D()
                {
                    MapName = Name,
                    X = x, Y = y, Z = z,
                });

                //NewMapPointAddedEvent.Invoke(this, new EventArgs());
            }
        }

        public byte[,] GetMapGrid2D ()
        {
            int maxX = MapPoints.Select(x => (x.Value.X < 0) ? (x.Value.X * -2) + 1 : (x.Value.X * 2) +1).Max(x => x);
            int minX = MapPoints.Select(x => (x.Value.X < 0) ? (x.Value.X * -2) + 1 : (x.Value.X * 2) +1).Min(x => x);

            int maxY = MapPoints.Select(y => (y.Value.Z < 0) ? (y.Value.Z * -2) + 1: (y.Value.Z * 2) +1).Max(y => y);
            int minY = MapPoints.Select(y => (y.Value.Z < 0) ? (y.Value.Z * -2) + 1 : (y.Value.Z * 2) +1).Min(y => y);


            byte[,] gridMap = new byte[maxX, maxY];
            foreach(var p in MapPoints)
            {
                var x = p.Value.X + (maxX / 2) ;
                var y = p.Value.Z + (maxY / 2) ;
                gridMap[x, y] = 1;
            }

            return gridMap;
        }
    }
}
