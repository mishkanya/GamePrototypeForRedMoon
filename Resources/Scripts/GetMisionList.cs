using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetMisionList
{
    static private MissionsList _missionsList;
    public static MissionsList GetListOfMissions{
        get
        {
            if(_missionsList == null){
                GameObject.FindGameObjectWithTag("MissionsList");
            }
            return _missionsList;
        }
    }
}
