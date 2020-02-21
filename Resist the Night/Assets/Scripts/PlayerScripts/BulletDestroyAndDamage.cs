using UnityEngine;

namespace PlayerScripts
{
    public class BulletDestroyAndDamage : MonoBehaviour
    {
        private float destroyTime = 0.70f;
        private float explosionTime = 0.15f;
        public GameObject explosion;
        public GameObject deathExplosion;
    
        private void Start()
        {
            Destroy(gameObject, destroyTime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(expl, explosionTime);

            if (collision.collider.CompareTag("Bullet"))
            {
                Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
            }
        }
    }
}
