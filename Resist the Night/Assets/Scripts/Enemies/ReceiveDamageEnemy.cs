using UnityEngine;

namespace Enemies
{
    public class ReceiveDamageEnemy : MonoBehaviour
    {
        public float hitPoints = 100f;
        public GameObject deathExplosion;
        
        private float explosionTime = 0.15f;
        private const float BulletDamage = 34f;
        private const int Zero = 0;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!collision.collider.CompareTag("Bullet")) return;
            hitPoints -= BulletDamage;
            print(hitPoints);
            CheckIfStillAlive();
        }
    
        private void CheckIfStillAlive()
        {
            if (!(hitPoints <= Zero)) return;
            var expl = Instantiate(deathExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(expl, explosionTime);
        }
    }
}
