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
    private int MissionOnStep = 0;
    public void LoadNewStep()
    {
        if(NewMission != null)
        {
            MissionOnStep++;
            if(NewMission.SpepsOnLocation <= MissionOnStep)
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
                s = missionsList.Missions[Random.Range(0,missionsList.Missions.Length)];
                int i = 0;
                while(s.MissionUnlocked == true && i < missionsList.Missions.Length)
                {
                    s = missionsList.Missions[Random.Range(0,missionsList.Missions.Length)];
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
        if(NewMission != null)
        {    
            MissionTab.gameObject.SetActive(true);
            MissionTab.ShowMissionMenu(NewMission);
        }
    }
    private void OnMouseDown() {
        OnPointDown();
    }
}
