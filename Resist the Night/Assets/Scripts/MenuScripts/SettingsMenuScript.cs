using UnityEngine;

namespace MenuScripts
{
    public class SettingsMenuScript : MonoBehaviour
    {
        public AudioSource audioSource;

        private void SetVolume(float volume)
        {
            audioSource.volume = volume;
        }
    }
}
