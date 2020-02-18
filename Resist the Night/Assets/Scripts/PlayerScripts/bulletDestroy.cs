using UnityEngine;

public class bulletDestroy : MonoBehaviour
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
        /*
        if (collision.collider.CompareTag("Bullet"))
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
        */
        /*
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject expl1 = Instantiate(deathExplosion, transform.position, Quaternion.identity);
            Destroy(expl1, explosionTime);
        }
        else
        {
        */
            Destroy(gameObject);
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(expl, explosionTime);
        //}
    }
    
}
