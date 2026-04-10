using System;
using System.Diagnostics;
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
        StackTrace stackTrace = new StackTrace();
        UnityEngine.Debug.Log(stackTrace.ToString());
        UnityEngine.Debug.Log(clip);
        src.PlayOneShot(clip);
    }
}
