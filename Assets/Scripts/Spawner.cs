using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyGun
{
    public class Spawner : MonoBehaviour
    {
        public List<GameObject> obstacle = new List<GameObject>();
        public float spawnInterval;
        public float maxSpawnInterval;

        private void Start()
        {
            spawnInterval = maxSpawnInterval;
        }

        private void Update()
        {
            int randomNumber = Random.Range(0, obstacle.Count);

            if (spawnInterval == maxSpawnInterval)
            {
                Instantiate(obstacle[randomNumber], transform.position, Quaternion.identity);
                spawnInterval = 0;
            }

            spawnInterval++;
        }
    }
}
