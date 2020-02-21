using System;
using UnityEngine;

namespace Enemies
{
    public class ReceiveDamageEnemy : MonoBehaviour
    {
        public float hitPoints = 100f;
        public GameObject deathExplosion;
        private float explosionTime = 0.15f;
        private const float bulletDamage = 34f;
        private const int ZERO = 0;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Bullet"))
            {
                hitPoints -= bulletDamage;
                print(hitPoints);
                CheckIfStillAlive();
            }
        }
    
        private void CheckIfStillAlive()
        {
            if (hitPoints <= ZERO)
            {
                Destroy(gameObject);
                GameObject expl = Instantiate(deathExplosion, transform.position, Quaternion.identity);
                Destroy(expl, explosionTime);
            }
        }
    }
}
