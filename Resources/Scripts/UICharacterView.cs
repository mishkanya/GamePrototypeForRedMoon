﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UICharacterView : MonoBehaviour, IPointerDownHandler
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
        if(EnumContainier.SceneStateNow == SceneState.None)
            if(CharacterMenuUI != null)
            {
                CharacterMenuUI.gameObject.SetActive(true);
                CharacterMenuUI.SetCharacterInfo(this.CharacterInfo);
            }
    }
    public void OnPointerDown(PointerEventData eventData){
        if(CharacterInfo != null)
        {
            CharacterDragAndDropSystem dragAndDropSystem = GameObject.FindGameObjectWithTag("Cursore").GetComponent<CharacterDragAndDropSystem>();
            dragAndDropSystem.SetDragCharacter(CharacterInfo);
        }
    }
}
