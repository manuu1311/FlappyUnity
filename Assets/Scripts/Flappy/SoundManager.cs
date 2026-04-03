using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public AudioClip jumping;
    public AudioClip starSound1;
    public AudioClip starSound2;
    public AudioSource sfx;
    public AudioSource music;
    

    public void StarPickup1() {
        sfx.PlayOneShot(starSound1);
    }

    public void StarPickup2() {
        sfx.PlayOneShot(starSound2);
    }

    public void StopMusic() {
        music.Stop();
    }

    public void PlayMusic() {
        music.Play();
    }

    public void Jump() {
        sfx.PlayOneShot(jumping);
    }
}
