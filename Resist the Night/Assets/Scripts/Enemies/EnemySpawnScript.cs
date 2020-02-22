using UnityEngine;

namespace Enemies
{
    public class EnemySpawnScript : MonoBehaviour
    {
        public GameObject crabPrefab;
        public Transform spawnPoint;

        private const float SpawnDelay = 2f;

        private void Start()
        {
            var low = Random.Range(2f, 5f);
            var high = Random.Range(5f, 10f);
            InvokeRepeating(nameof(SpawnCrab), SpawnDelay, Random.Range(low, high));
        }

        private void SpawnCrab() 
        {
            Instantiate(crabPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
