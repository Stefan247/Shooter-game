using UnityEngine;

namespace Map
{
    public class BoundariesCheck : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!collision.gameObject.CompareTag("Player"))
            {
                Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
            }
        }
    }
}
