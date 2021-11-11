using System.Collections.Generic;
using Croisant_Crawler.Data;

namespace Croisant_Crawler
{
    public class Room
    {
        public Vector2Int position { get; }
        
        // Whether this room has connection with room { up, right, down, left }.
        public Connections connections;

        public Room(Vector2Int position, Connections connections = new Connections())
        {
            this.position = position;
            this.connections = connections;
        }

        public Vector2Int[] GetWalkableRooms()
        {
            var result = new List<Vector2Int>(4);

            if (connections[0])
                result.Add(position + Vector2Int.Up);
            if (connections[1])
                result.Add(position + Vector2Int.Right);
            if (connections[2])
                result.Add(position + Vector2Int.Down);
            if (connections[3])
                result.Add(position + Vector2Int.Left);
            
            return result.ToArray();
        }
    }
}