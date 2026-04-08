using TMPro;
using UnityEngine;
using UnityEngine.UI;

//change text in options panel
public class TextOptionChange : MonoBehaviour
{
    public TextMeshProUGUI valueText;

    public void ChangeText(float val){
        valueText.text = val.ToString("0.00");
    }
}
