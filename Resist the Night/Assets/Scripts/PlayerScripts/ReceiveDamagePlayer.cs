using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerScripts
{
    public class ReceiveDamagePlayer : MonoBehaviour
    {
    
        private const int ZERO = 0;
        private const float ENEMYDAMAGE = 20f;
        private const float DEATHDELAY = 0.9f;
    
        public GameObject deadPlayer;
    
        public float hitPoints = 1000f;
        public float maxHitPoints = 1000f; // to be used in the future
        private float explosionTime = 1f;
    
        public void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                hitPoints -= ENEMYDAMAGE;
            }

#pragma warning disable 4014
            CheckIfStillAlive();
#pragma warning restore 4014
        }
    
        private async Task CheckIfStillAlive()
        {
            if (hitPoints <= ZERO)
            {
                Destroy(gameObject);
                GameObject expl = Instantiate(deadPlayer, transform.position, Quaternion.identity);
                Destroy(expl, explosionTime);
            
                await Task.Delay(TimeSpan.FromSeconds(DEATHDELAY));
                SceneManager.LoadScene(2); // After death menu
            }
        }
    }
}
