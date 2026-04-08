using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SoundClass audioPlayer;
    public AudioClip clip;
    public void OnPointerEnter(PointerEventData eventData){
        audioPlayer.PlaySound(clip);
    }
}
