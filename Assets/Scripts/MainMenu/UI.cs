using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject buttonsScreen;
    public GameObject playScreen;
    public GameObject optionsScreen;
    public SoundClass audioPlayer;
    public AudioClip menuChangeClip;
    public ParticleSystem particles;

    void Start() {
        Application.targetFrameRate=60;
        BackButton(false);
        particles.Play();
    }
    // play button action
    public void PlayButton() {
        buttonsScreen.SetActive(false);
        optionsScreen.SetActive(false);
        playScreen.SetActive(true);
        audioPlayer.PlaySound(menuChangeClip);
    }
    //options button action
    public void OptionsButton() {
        buttonsScreen.SetActive(false);
        optionsScreen.SetActive(true);
        playScreen.SetActive(false);
        audioPlayer.PlaySound(menuChangeClip);
    }
    //quit button action
    public void QuitButton() {
        Application.Quit();
    }
    //back button
    public void BackButton(bool clip=true) {
        buttonsScreen.SetActive(true);
        optionsScreen.SetActive(false);
        playScreen.SetActive(false);
        if (clip) {
            audioPlayer.PlaySound(menuChangeClip);   
        }
    }
}
