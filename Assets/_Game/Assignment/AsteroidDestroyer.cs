using System;
using DefaultNamespace.GameEvents;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidDestroyer : MonoBehaviour
    {
        [SerializeField] private GameEventVector3 _spawn;
        public void OnAsteroidHitByLaser(int asteroidId)
        {
            Asteroid asteroid = AsteroidSet._asteroids[asteroidId];
            float asteroidSize = asteroid.transform.GetChild(0).localScale.x;

            if (asteroidSize < 0.5)
            {
                AsteroidSet.Remove(asteroidId);
            }
            else
            {
                _spawn.Raise(asteroid.transform.position);
                AsteroidSet.Remove(asteroidId);
            }
        }
    }
}
