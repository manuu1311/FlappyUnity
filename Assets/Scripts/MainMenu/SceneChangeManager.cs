using UnityEngine;

public class SceneChangeManager : MonoBehaviour
{
    // play flappy
    public void Flappy() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Flappy");
    }
}
