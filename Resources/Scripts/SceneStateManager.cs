using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStateManager : MonoBehaviour
{
    private void Start() {
        EnumContainier.SceneStateNow = SceneState.None;
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.LeftAlt)){
            print (EnumContainier.SceneStateNow);
        }
    }
}
