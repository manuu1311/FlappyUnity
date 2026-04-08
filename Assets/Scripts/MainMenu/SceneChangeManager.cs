using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    // play flappy
    public void Flappy() {
        SceneManager.LoadScene("Flappy");
    }
}
