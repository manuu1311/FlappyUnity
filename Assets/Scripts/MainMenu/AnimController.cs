using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour
{
    public GameObject Flappy;
    public FishAnim[] Fish;
    public Animator anim;
    void Awake() {
        Idle();
    }
    public void Idle() {
        gameObject.SetActive(false);
    }
    public void StartAnim() {
        gameObject.SetActive(true);
        StartCoroutine(Anim());
    }
    IEnumerator Anim(){
        foreach(FishAnim fish in Fish) {
            fish.PlayAnim();
        }
        //anim.SetTrigger("Activate");
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
    }
}
