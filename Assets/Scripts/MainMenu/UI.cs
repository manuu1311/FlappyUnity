using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject buttonsScreen;
    public GameObject playScreen;
    public GameObject optionsScreen;

    void Start() {
        Application.targetFrameRate=60;
        BackButton();
    }
    // play button action
    public void PlayButton() {
        buttonsScreen.SetActive(false);
        optionsScreen.SetActive(false);
        playScreen.SetActive(true);
    }
    //options button action
    public void OptionsButton() {
        buttonsScreen.SetActive(false);
        optionsScreen.SetActive(true);
        playScreen.SetActive(false);
    }
    //quit button action
    public void QuitButton() {
        Application.Quit();
    }
    //back button
    public void BackButton() {
        buttonsScreen.SetActive(true);
        optionsScreen.SetActive(false);
        playScreen.SetActive(false);
    }
}
