using UnityEngine;

//class that plays sounds in the main menu
public class SoundClass : MonoBehaviour
{
    public AudioClip clickButton;
    public AudioClip playFlappy;
    public AudioSource src;

    public void PlayClick() {
        src.PlayOneShot(clickButton);
    }
    public void PlayFlappyButton() {
        src.PlayOneShot(playFlappy);
    }

    public void PlaySound(AudioClip clip) {
        src.PlayOneShot(clip);
    }
}
