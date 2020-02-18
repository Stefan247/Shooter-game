using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float hitPoints = 100f;
    public GameObject deathExplosion;
    private float explosionTime = 0.15f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            hitPoints -= 34f;
            if (hitPoints <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                GameObject expl1 = Instantiate(deathExplosion, transform.position, Quaternion.identity);
                Destroy(expl1, explosionTime);
            }
        }
    }
}
