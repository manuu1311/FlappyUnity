using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlappyManager : MonoBehaviour
{
    public void MainMenu() {
        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);   
    }
}
