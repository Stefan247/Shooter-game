using UnityEngine;
using UnityEngine.Audio;

namespace MenuScripts
{
    public class SettingsMenuScript : MonoBehaviour
    {
        public AudioMixer audioMixer;

        private void SetVolume(float volume)
        {
            audioMixer.SetFloat("volumeParameter", volume);
            /*
             *  Not being used yet.
             */
        }
    }
}
