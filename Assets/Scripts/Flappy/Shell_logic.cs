using System.Data.Common;
using UnityEngine;

public class Sprite_logic : MonoBehaviour
{
    public Sprite[] sprites;
    public float[] rews;
    private float rew;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int id=Random.Range(0,rews.Length);
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[id];
        rew=rews[id];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
