using UnityEngine;

public class Sky_animation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float animation_speed=1f;
    private MeshRenderer mesh;
    void Awake()
    {
        mesh=GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mesh.material.mainTextureOffset+=new Vector2(animation_speed*Time.deltaTime,0);
    }
}
