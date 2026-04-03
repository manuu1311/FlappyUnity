using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float Score;
    public TextMeshProUGUI score;
    public GameObject playButton;
    public GameObject gameOverImg;
    public Bird_script bird;
    public SoundManager soundManager;

    private void Awake()
    {
        Application.targetFrameRate=60;
        playButton.SetActive(true);
        gameOverImg.SetActive(false);
        Pause();
    }

    public void Play()
    {
        Score=0;
        score.text=Score.ToString();

        gameOverImg.SetActive(false);
        playButton.SetActive(false);
        Time.timeScale=1f;
        bird.enabled=true;
        Vector3 pos = bird.transform.position;
        pos.y = -1.5f;
        bird.transform.position = pos;
        bird.rigidBody.linearVelocity = new Vector2(0, 0);
        obj_mover[] env= FindObjectsByType<obj_mover>();
        for(int i = 0; i < env.Length; i++)
        {
            Destroy(env[i].gameObject);
        }
        soundManager.PlayMusic();
    }
    private void Pause(){
        soundManager.StopMusic();
        Time.timeScale=0f;
        bird.enabled=false;
    }
    public void IncreaseScore(float val)
    {
        Score+=val;
        score.text=Score.ToString();
    }

    public void GameOver()
    {
        gameOverImg.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
