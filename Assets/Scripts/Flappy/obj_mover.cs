using UnityEngine;

public class obj_mover : MonoBehaviour
{
    public float speed=5f;
    private float leftedge;
    public bool active=true;

    private void Start()
    {
        leftedge=Camera.main.ScreenToWorldPoint(Vector3.zero).x-2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(active){
        transform.position+=Vector3.left*speed*Time.deltaTime;
        if (transform.position.x < leftedge)
        {
            Destroy(gameObject);
        }
        }
    }

}
