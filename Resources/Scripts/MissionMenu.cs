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
        EnumContainier.SceneStateNow = SceneState.None;
        MissionName.text = "";
        MissionInfo.text = "";
        NeedingCharacteristics.text = "";
        gameObject.SetActive(false);
    }
    public void ShowMissionMenu(Mission mission){
        EnumContainier.SceneStateNow = SceneState.ShowingMissionMenu;
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
    public void ShowMissionMenu(Location location)
    {
        EnumContainier.SceneStateNow = SceneState.ShowingMissionMenu;
        MissionName.text = location.NewMission.MissionName;
        MissionInfo.text = location.NewMission.TextOfMission;
        NeedingCharacteristics.text = 
            "Сила: " + location.NewMission.NeedingStrength +
            "\nВосприятие: " + location.NewMission.NeedingPerception +
            "\nВыносливость: " + location.NewMission.NeedingEndurance +
            "\nХаризма: " + location.NewMission.NeedingCharisma +
            "\nИнтеллект: " + location.NewMission.NeedingIntelligence +
            "\nЛовкость: " + location.NewMission.NeedingAgility +
            "\nУдача: " + location.NewMission.NeedingLuck + 
            "\nНеобходимая энергия: " + location.NewMission.NeedingEnergy +
            "\n\n\nЗакончится через: " + (location.NewMission.StepsOnLocation - location.MissionOnStep).ToString();
    }
}
