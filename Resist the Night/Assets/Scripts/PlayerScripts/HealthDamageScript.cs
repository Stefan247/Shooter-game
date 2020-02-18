using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
public class HealthDamageScript : MonoBehaviour
{
    public float hitPoints = 1000f;
    public float maxHitPoints = 1000f;
    public GameObject deadPlayer;
    private float explosionTime = 1f;

    public async void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            this.hitPoints -= 20f;
        }

        if (this.hitPoints <= 0f)
        {
            Destroy(this.gameObject);
            GameObject expl = Instantiate(deadPlayer, transform.position, Quaternion.identity);
            Destroy(expl, explosionTime);

            await Task.Delay(TimeSpan.FromSeconds(0.9f));
            SceneManager.LoadScene(2);
        }
    }
    
}
