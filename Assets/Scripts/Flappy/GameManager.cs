using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float Score;
    
    
    public void IncreaseScore(float val)
    {
        Score+=val;
        Debug.Log(Score);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
