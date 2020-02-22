﻿using System;
using System.Threading.Tasks;
using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerScripts
{
    public class ReceiveDamagePlayer : MonoBehaviour
    {
        public PlayerHealthBar healthBar;
        public GameObject deadPlayer;
        public float hitPoints;
        public float maxHitPoints = 1000; // to be used in the future
        
        private const float EnemyDamage = 20f;
        private const float DeathDelay = 0.9f;
        private const float ExplosionTime = 1f;
        private const int Zero = 0;

        private void Start()
        {
            hitPoints = maxHitPoints;
            healthBar.SetMaxHealth(maxHitPoints);
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                hitPoints -= EnemyDamage;
                healthBar.SetHealth(hitPoints);
            }

        #pragma warning disable 4014
            CheckIfStillAlive();
        #pragma warning restore 4014
        }
    
        private async Task CheckIfStillAlive()
        {
            if (hitPoints <= Zero)
            {
                Destroy(gameObject);
                var expl = Instantiate(deadPlayer, transform.position, Quaternion.identity);
                Destroy(expl, ExplosionTime);
            
                await Task.Delay(TimeSpan.FromSeconds(DeathDelay));
                SceneManager.LoadScene(2); // After death menu
            }
        }
    }
}
