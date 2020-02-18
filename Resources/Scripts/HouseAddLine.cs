using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseAddLine : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public Material NormalShader;
    public Material Liner;
    private void Start() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnMouseEnter() {
        if(EnumContainier.SceneStateNow == SceneState.None)
        _spriteRenderer.sharedMaterial = Liner;
    }
    private void OnMouseExit() {
        _spriteRenderer.sharedMaterial = NormalShader;
    }
}
