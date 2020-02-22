using System.Collections;
using UnityEngine;

namespace CameraScripts
{
    public class CameraShake : MonoBehaviour
    {
        private const float Zero = 0f;
        private const float One = 1f;

        public IEnumerator Shake(float duration, float magnitude)
        {
            Vector3 originalPos = transform.localPosition;
            var elapsed = Zero;

            while (elapsed < duration)
            {
                var x = Random.Range(-One, One) * magnitude;
                var y = Random.Range(-One, One) * magnitude;
                
                transform.localPosition = new Vector3(x, y, originalPos.z);
                elapsed += Time.deltaTime;
                
                yield return null;
            }
            transform.localPosition = originalPos;
        }
    }
}
