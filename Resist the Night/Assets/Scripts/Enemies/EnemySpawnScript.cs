using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject crabPrefab;
    public Transform spawnPoint;
    void Start()
    {
        InvokeRepeating("SpawnCrab", 2.0f, Random.Range(5.0f, 10.0f));
    }
    
    public void SpawnCrab() 
    {
        Instantiate(crabPrefab, spawnPoint.position, Quaternion.identity);
    }
}
