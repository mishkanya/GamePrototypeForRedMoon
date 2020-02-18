using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionsList : MonoBehaviour
{
    
    public List<Mission> Missions = new List<Mission>();
    private void Start() {
        foreach(Mission a in Missions){
            a.MissionUnlocked = false;
        }
    }
    public void AddNewMission(Mission newMis){
        newMis.MissionUnlocked = false;
        Missions.Add(newMis);
    }
}
