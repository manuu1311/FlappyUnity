using UnityEngine;
using System.Collections;

[RequireComponent(typeof(UnityEngine.UI.Image))]

//fish animation in main menu
public class FishAnim : MonoBehaviour
{
    public float xspeed=5;
    public float yfirst;
    public float yvelocity;
    private float yvelocityInitial;
    public float xfirst;
    public float rotation;
    private float rotationInitial;
    private float rotationspeed;
    public float scale;
    public ParticleSystem first_splash;
    public ParticleSystem second_splash;
    public SoundClass soundManager;
    public AudioClip splash;
    public AudioClip secondsplash;
    public float timeOffset;
    public float gravity;
    private bool active;
    private RectTransform rt;
    private UnityEngine.UI.Image img;
    void Awake() {
        rotationInitial=rotation;
        float time=2*yvelocity / gravity;
        rotationspeed=-2*rotation/time;
        yvelocityInitial=yvelocity;
        rt = GetComponent<RectTransform>();
        img= GetComponent<UnityEngine.UI.Image>();
    }
    void Start()
    {
        Reset();
    }

    private void Reset() {
        rt.anchoredPosition = new Vector2(xfirst, yfirst);
        //Vector3 pos= new Vector3(xfirst,yfirst,0);
        //transform.position=pos;
        transform.localScale=new Vector3(scale,scale,1);
        transform.rotation=Quaternion.Euler(0,0,rotation);
        active=false;
        img.enabled = false;
        yvelocity=yvelocityInitial;
        rotation=rotationInitial;
    }

    void Update()
    {
        if(active){
            Vector2 pos2=rt.anchoredPosition;
            pos2.x-=xspeed*Time.deltaTime;
            yvelocity-=gravity*Time.deltaTime;
            pos2.y+=yvelocity*Time.deltaTime;
            rt.anchoredPosition = pos2;
            rotation+=rotationspeed*Time.deltaTime;
            transform.rotation=Quaternion.Euler(0,0,rotation);
            first_splash.transform.position+=new Vector3(xspeed*Time.deltaTime,0,0);
            if(pos2.y < yfirst){
                //final state reached
                active=false;
                transform.rotation=Quaternion.Euler(0,0,0);
                second_splash.Play();
                soundManager.PlaySound(secondsplash);
                img.enabled = false;
                //Destroy(gameObject,2f);
            }   
        }
    }
    //start the animation
    public void PlayAnim() {
        Reset();
        first_splash.Play();
        soundManager.PlaySound(splash);
        StartCoroutine(Anim());
    }
    IEnumerator Anim(){
    yield return new WaitForSeconds(timeOffset); // pause 
    active = true;
    GetComponent<UnityEngine.UI.Image>().enabled = true;
}
}
