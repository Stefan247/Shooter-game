using UnityEngine;

namespace Enemies
{
    public class EnemySpawnScript : MonoBehaviour
    {
    
        public GameObject crabPrefab;
        public Transform spawnPoint;
        private static float low;
        private static float high;
        private static readonly float spawnDelay= 2f;
    
        void Start()
        {
            low = Random.Range(2f, 5f);
            high = Random.Range(5f, 10f);
            InvokeRepeating("SpawnCrab", spawnDelay, Random.Range(low, high));
        }

        private void SpawnCrab() 
        {
            Instantiate(crabPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
