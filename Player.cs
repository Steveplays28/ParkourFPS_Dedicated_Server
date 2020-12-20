using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ParkourFPS_Dedicated_Server
{
    class Player
    {
        public int id;
        public string username;

        public Vector3 position;
        public Quaternion rotation;

        public Player(int _id, string _username, Vector3 _spawnPosition, Quaternion _spawnRotation)
        {
            id = _id;
            username = _username;

            position = _spawnPosition;
            rotation = _spawnRotation;
        }
    }
}
