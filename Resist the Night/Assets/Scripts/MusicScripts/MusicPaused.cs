using MenuScripts;
using UnityEngine;

namespace MusicScripts
{
    public class MusicPaused : MonoBehaviour
    {
        private AudioSource audioSource;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }
        private void Update()
        {
            if (PauseMenu.IsPaused)
            {
                audioSource.volume = 0;
            }
            else
            {
                audioSource.volume = 1;
            }
        }
    }
}
