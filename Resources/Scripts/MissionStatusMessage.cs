using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionStatusMessage : MonoBehaviour
{
    public TextMeshProUGUI Message;
    private Image _image;
    public Color GreenColor;
    public Color RedColor;
    public float ChangeOpacitySpeed = 0.5f;
    public TextAsset Table;
    private void Start() {
        _image = GetComponent<Image>();
    }
    public void SendNewNotification(string message, bool missionComplite){
        _image.color = missionComplite? GreenColor : RedColor;
        Message.text = message;
        StartCoroutine(HideStatus());
    }
    private IEnumerator HideStatus(){
        for(float i = _image.color.a; i > 0; i-= Time.fixedDeltaTime * ChangeOpacitySpeed)
        {
            _image.color = new Color(_image.color.r, _image.color.g, _image.color.b, i);
            yield return new WaitForFixedUpdate();
        }
        Message.text = "";
    }
    public void SaveMessage(string newTabliLine){
        if(Table != null){
                
        }
    }
}
