using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class OptionsPanel : MonoBehaviour
{
    public UnityEngine.UI.Slider volumeSlider;
    public UnityEngine.UI.Slider fpsSlider;

    void Start(){
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
        fpsSlider.value = PlayerPrefs.GetFloat("FPS", 60f);
    }

    public void OnVolumeChanged(float value){
        AudioListener.volume = value;
        PlayerPrefs.SetFloat("Volume", value); 
    }
        public void OnFPSChange(float value){
            int fps=(int)value;
            Application.targetFrameRate = fps;
            PlayerPrefs.SetFloat("FPS", value);
    }
}
