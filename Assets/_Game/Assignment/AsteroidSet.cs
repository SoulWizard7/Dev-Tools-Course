using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "AsteroidSet", menuName = "ScriptableObjects/AsteroidSet", order = 0)]
    public class AsteroidSet : ScriptableObject
    {
        public static Dictionary<int, Asteroid> _asteroids = new Dictionary<int, Asteroid>();

        private void Awake()
        {
            Clear();
        }

        public static void Add(int id, Asteroid asteroid)
        {
            _asteroids.Add(id, asteroid);
        }

        public static void Remove(int id)
        {
            Destroy(_asteroids[id].gameObject);
            _asteroids.Remove(id);
        }

        private void Clear()
        {
            _asteroids = new Dictionary<int, Asteroid>();
        }
    }
}