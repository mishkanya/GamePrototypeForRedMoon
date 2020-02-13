using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class UICharacterView : MonoBehaviour
{
    public Character CharacterInfo;

    public TextMeshProUGUI NameLink;
    public CharacterMenu CharacterMenuUI;

    private Image _image;
    private void Start() {
        _image = GetComponent<Image>();
        
        if(CharacterInfo != null)
            SetNewCharacter(CharacterInfo);
    }
    public void SetNewCharacter(Character newCharacter)
    {
        CharacterInfo = newCharacter;
        if(NameLink)
        {
            NameLink.text = CharacterInfo.Name;
        }
        _image.sprite = CharacterInfo.Avatar;
    }
    public void DeletCharacter(){
        CharacterInfo = null;
        NameLink.text = null;
        _image.sprite = null;
    }
    public void ViewCharacterInfo()
    {
        if(CharacterMenuUI != null)
        {
            CharacterMenuUI.gameObject.SetActive(true);
            CharacterMenuUI.CharacterInfo = this.CharacterInfo;
            CharacterMenuUI.SetCharacterInfo();
        }
    }
}
