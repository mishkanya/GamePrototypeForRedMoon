﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterMenu : MonoBehaviour
{
    public Character CharacterInfo;
    public Image Avatar;

    public TextMeshProUGUI 
    LoreText,
    NameText,
    SPECIALText;
    public void SetCharacterInfo()
    {
        if(CharacterInfo != null){

            NameText.text = CharacterInfo.Name;
            LoreText.text = CharacterInfo.CharacterLore;

            SPECIALText.text = 
            "сила: " + CharacterInfo.Strength +
            "\nВосприятие: " + CharacterInfo.Perception +
            "\nВыносливость: " + CharacterInfo.Endurance +
            "\nХаризма: " + CharacterInfo.Charisma +
            "\nИнтеллект: " + CharacterInfo.Intelligence +
            "\nЛовкость: " + CharacterInfo.Agility +
            "\nУдача: " + CharacterInfo.Luck +
            "\n\n\nХодов осталось:" + CharacterInfo.Steps;
            Avatar.sprite = CharacterInfo.Avatar;
        }
    }
    private void ClearCharacterInfo()
    {
        NameText.text = "";
        LoreText.text = "";
        SPECIALText.text = "";
        Avatar.sprite = null;
    }

    public void Close(){
        ClearCharacterInfo();
        gameObject.SetActive(false);
    }
}