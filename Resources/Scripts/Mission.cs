using UnityEngine;

[CreateAssetMenu(fileName = "Mission", menuName = "RedMoonPrototype/Mission", order = 0)]
public class Mission : ScriptableObject 
{
    public string MissionName;
    [Multiline(8)]
    public string TextOfMission;
    [Header("Необходимые характеристики для выполнения миссии")]
    
    [Range(0,10)]
    public int NeedingStrength = 0;
    [Range(0,10)]
    public int 
    NeedingPerception = 0,
    NeedingEndurance  = 0,
    NeedingCharisma = 0,
    NeedingIntelligence  = 0,
    NeedingAgility = 0,
    NeedingLuck = 0;    
    [Space(20)]
    public bool MissionUnlocked = true;
    public int 
    StepToFinal = 1,
    SpepsOnLocation = 3;
}
