using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionMenu : MonoBehaviour
{
    public TextMeshProUGUI 
    MissionName,
    MissionInfo,
    NeedingCharacteristics;

    public void Hide(){

        MissionName.text = "";
        MissionInfo.text = "";
        NeedingCharacteristics.text = "";
        gameObject.SetActive(false);
    }
    public void ShowMissionMenu(Mission mission){
        MissionName.text = mission.MissionName;
        MissionInfo.text = mission.TextOfMission;
        NeedingCharacteristics.text = 
            "Сила: " + mission.NeedingStrength +
            "\nВосприятие: " + mission.NeedingPerception +
            "\nВыносливость: " + mission.NeedingEndurance +
            "\nХаризма: " + mission.NeedingCharisma +
            "\nИнтеллект: " + mission.NeedingIntelligence +
            "\nЛовкость: " + mission.NeedingAgility +
            "\nУдача: " + mission.NeedingLuck;
    }
}
