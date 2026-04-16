using UnityEngine;
using System.Collections;

public class SceneChangeManager : MonoBehaviour
{
    public AnimController controller;
    public Fader fader;
    public float fadeTime;
    // play flappy
    public void Flappy() {
        StartCoroutine(FlappySequence());
    }
    IEnumerator FlappySequence() {
        Debug.Log("starting animation");
        controller.StartAnim();
        yield return new WaitForSeconds(2.5f);
        Debug.Log("fading");
        fader.FadeOut(fadeTime);
        yield return new WaitForSeconds(fadeTime+0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Flappy");
    }
}
