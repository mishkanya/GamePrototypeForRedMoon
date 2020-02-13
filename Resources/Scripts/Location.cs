using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    public string LocationName;
    public Mission NewMission;
    public MissionMenu MissionTab;
    public GameObject MissionPoint;

    public void ShowMissionPoint(Mission newMission)
    {
        MissionPoint.SetActive(true);
        NewMission = newMission;
    }
    public void HideMission(){
        NewMission = null;
        MissionPoint.SetActive(false);
        MissionTab.gameObject.SetActive(false);
    }
    public void OnPointDown(){
        MissionTab.gameObject.SetActive(true);
        MissionTab.ShowMissionMenu(NewMission);
    }
    private void OnMouseDown() {
        OnPointDown();
    }
}
