using UnityEngine;
using CameraScripts;

namespace PlayerScripts
{
    public class ShootingScript : MonoBehaviour
    {
        public Transform firePoint;
        public GameObject bulletPrefab;
        public CameraShake cameraShake;
        public float bulletForce = 20f;

        private float fireSpeed = .2f;
        private float fireRate = .2f;
        private const float Zero = 0f;
        // private float screenShakeMagnitude = 0.1f;
        // private float screenShakeDuration = 0.2f;
         
        private void Update()
        {
            if (Input.GetButtonDown("Fire1")) // if not holding 
            {
                Shoot();
            }

            if (Input.GetMouseButton(0)) // if holding 
            {
                if (fireRate >= fireSpeed)
                {
                    // StartCoroutine(cameraShake.Shake(screenShakeDuration, screenShakeMagnitude));
                    Shoot();
                }
                else
                {
                    fireRate += Time.deltaTime;
                }
            }
        }

        private void Shoot()
        {
            var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            var rigidBody = bullet.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            fireRate = Zero;
        }
    }
}
