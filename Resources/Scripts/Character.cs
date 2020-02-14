using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Character", menuName = "RedMoonPrototype/Character", order = 0)]
public class Character : ScriptableObject 
{
    public string Name = "Character name";
    public Sprite Avatar; 
    [Header("Характеристики персонажа")] //ILoveFallout :D
    [Range(0,10)]
    public int 
    Strength = 0,
    Perception = 0,
    Endurance  = 0,
    Charisma = 0,
    Intelligence  = 0,
    Agility = 0,
    Luck = 0;
    [Multiline(3)]
    public string CharacterLore;
}
