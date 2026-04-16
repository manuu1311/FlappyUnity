using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour
{
    public UnityEngine.UI.Image img;
    void Start() {
        gameObject.SetActive(false);
    }

    public void FadeOut(float t) {
        gameObject.SetActive(true);
        StartCoroutine(FadeSeq(t));
    }

    IEnumerator FadeSeq(float t) {
    Color color = img.color;
    float step=1f/t;

    while (color.a < 1f){
        float alpha = color.a;
        alpha += step * Time.deltaTime; 
        color.a = Mathf.Clamp01(alpha);
        img.color = color;

        yield return null; 
    }
    color.a = 1f;
    img.color = color;
    }
}
