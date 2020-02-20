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
            "Сила: " + mission.СoefficientStrength +
            "\nВосприятие: " + mission.СoefficientPerception +
            "\nВыносливость: " + mission.СoefficientEndurance +
            "\nХаризма: " + mission.СoefficientCharisma +
            "\nИнтеллект: " + mission.СoefficientIntelligence +
            "\nЛовкость: " + mission.СoefficientAgility +
            "\nУдача: " + mission.СoefficientLuck;
    }
    public void ShowMissionMenu(Location location)
    {
        EnumContainier.SceneStateNow = SceneState.ShowingMissionMenu;
        MissionName.text = location.NewMission.MissionName;
        MissionInfo.text = location.NewMission.TextOfMission;
        NeedingCharacteristics.text = 
            "Сила: " + location.NewMission.СoefficientStrength +
            "\nВосприятие: " + location.NewMission.СoefficientPerception +
            "\nВыносливость: " + location.NewMission.СoefficientEndurance +
            "\nХаризма: " + location.NewMission.СoefficientCharisma +
            "\nИнтеллект: " + location.NewMission.СoefficientIntelligence +
            "\nЛовкость: " + location.NewMission.СoefficientAgility +
            "\nУдача: " + location.NewMission.СoefficientLuck + 
            "\nНеобходимая энергия: " + location.NewMission.NeedingEnergy +
            "\n\n\nЗакончится через: " + (location.NewMission.StepsOnLocation - location.MissionOnStep).ToString();
    }
}
