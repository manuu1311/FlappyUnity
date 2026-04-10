using UnityEngine;
using System.Collections;

public class SceneChangeManager : MonoBehaviour
{
    public AnimController controller;
    // play flappy
    public void Flappy() {
        StartCoroutine(FlappySequence());
    }
    IEnumerator FlappySequence() {
        controller.StartAnim();
        yield return new WaitForSeconds(4f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Flappy");
    }
}
