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
    public MissionsList missionsList;
    [HideInInspector]
    public int MissionOnStep = 0;
    public void LoadNewStep()
    {
        if(NewMission != null)
        {
            MissionOnStep++;
            if(NewMission.StepsOnLocation <= MissionOnStep)
            {
                HideMission();
            }
        }
        else
        {
            MissionOnStep = 0;
            if(Random.value > 0.8f)
            {
                Mission s;
                s = missionsList.Missions[Random.Range(0,missionsList.Missions.Count)];
                int i = 0;
                while(s.MissionUnlocked == true && i < missionsList.Missions.Count)
                {
                    s = missionsList.Missions[Random.Range(0,missionsList.Missions.Count)];
                    i++;
                }
                if(s.MissionUnlocked == false)
                {
                    ShowMissionPoint(s);
                }
            }
        }
    }

    public void ShowMissionPoint(Mission newMission)
    {
        newMission.MissionUnlocked = true;
        MissionPoint.SetActive(true);
        NewMission = newMission;
    }
    public void HideMission(){
        NewMission = null;
        MissionPoint.SetActive(false);
        MissionTab.gameObject.SetActive(false);
    }
    public void OnPointDown(){
        ShowMission();
    }
    private void OnMouseDown() {
        if(EnumContainier.SceneStateNow == SceneState.None)
            ShowMission();
    }
    public void ShowMission()
    {
        if(NewMission != null)
        {    
            MissionTab.gameObject.SetActive(true);
            MissionTab.ShowMissionMenu(this);
        }
    }
}
