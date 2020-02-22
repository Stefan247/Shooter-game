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
        /*
         * private float screenShakeMagnitude = 0.03f;
         * private float screenShakeDuration = 0.15f;
         */
        private void Update()
        {
            if (!Input.GetButtonDown("Fire1")) return;
            var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            var rigidBody = bullet.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            /*
             * StartCoroutine(cameraShake.Shake(screenShakeDuration, screenShakeMagnitude));
             */
        }
    }
}
