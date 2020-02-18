using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnumContainier
{
    public static SceneState SceneStateNow = SceneState.None;
}
public enum SceneState
{
    ShowingCharakterMenu,
    None,
    ShowingMissionMenu
}
