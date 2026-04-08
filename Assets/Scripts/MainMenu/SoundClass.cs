using System;
using UnityEngine;

//class that plays sounds in the main menu
public class SoundClass : MonoBehaviour
{
    public AudioClip playFlappy;
    public AudioClip flappyLoad;
    public AudioSource src;

    public void PlayFlappyLoad() {
        src.PlayOneShot(flappyLoad);
    }
    public void PlayFlappyButton() {
        src.PlayOneShot(playFlappy);
    }

    public void PlaySound(AudioClip clip) {
        Debug.Log("er suono");
        src.PlayOneShot(clip);
        Debug.Log("Fine");
    }
}
