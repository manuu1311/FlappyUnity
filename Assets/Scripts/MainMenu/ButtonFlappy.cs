using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ButtonFlappy : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public ParticleSystem shell1;
    public ParticleSystem shell2;
    public GameObject bird;
    private Coroutine coroutine;
    public void OnPointerEnter(PointerEventData eventData){
        shell1.Play();
        shell2.Play();
        if(coroutine!=null){
            StopCoroutine(coroutine);
        }
        coroutine=StartCoroutine(BirdScaler(1,0.5f));
    }
    public void OnPointerExit(PointerEventData eventData){
        shell1.Stop();
        shell2.Stop();
        shell1.Clear();
        shell2.Clear();
        if(coroutine!=null){
            StopCoroutine(coroutine);
        }
        coroutine=StartCoroutine(BirdScaler(-1,0.5f));
    }
    public void OnPointerClick(PointerEventData eventData) {
        shell1.Stop();
        shell2.Stop();
        shell1.Clear();
        shell2.Clear();
        gameObject.SetActive(false);
    }

    IEnumerator BirdScaler(int sign, float duration) {
        // sign: 1 = fade 0 -> 1
        //       -1 = fade 1 -> 0

        float start = bird.transform.localScale.x;
        float end   = (sign >= 0) ? 3f : 2f;

        float t = 0f;
    
        // set initial value

        while (t < duration)
        {
            t += Time.deltaTime;

            float normalized = Mathf.Clamp01(t / duration);
            float value = Mathf.Lerp(start, end, normalized);

            bird.transform.localScale=new Vector3(value,value,1);

            yield return new WaitForEndOfFrame();
        }

        // ensure final value is exact
        bird.transform.localScale=new Vector3(end,end,1);
    }

}
