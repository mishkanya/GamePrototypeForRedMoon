using UnityEngine;

[CreateAssetMenu(fileName = "Mission", menuName = "RedMoonPrototype/Mission", order = 0)]
public class Mission : ScriptableObject 
{
    public string MissionName;
    [Multiline(8)]
    public string TextOfMission;
    [Header("Коэффициенты характеристик")]

    [Range(0,1)]
    public float BaseChance = 0.5f;

    
    [Range(0,1)]
    public float СoefficientStrength = 0;
    [Range(0,1)]
    public float 
    СoefficientPerception = 0,
    СoefficientEndurance  = 0,
    СoefficientCharisma = 0,
    СoefficientIntelligence  = 0,
    СoefficientAgility = 0,
    СoefficientLuck = 0;    


    [Space(20)]
    public bool MissionUnlocked = true;
    public int 
    NeedingEnergy = 1,
    StepsOnLocation = 3;
    public Mission NextLoreMission;
    public void AddNextLoreMission(MissionsList missionsList){
        if(NextLoreMission != null){
            NextLoreMission.MissionUnlocked = false;
            missionsList.AddNewMission(NextLoreMission);
        }
    }
    public float GetChanceToCompliteMission(Character character){

        float chance = BaseChance * (1 + (character.Strength * СoefficientStrength + character.Perception * СoefficientPerception + character.Endurance * СoefficientEndurance + character.Charisma * СoefficientCharisma + character.Intelligence * СoefficientIntelligence + character.Luck * СoefficientLuck));
        return chance;
    }
}
