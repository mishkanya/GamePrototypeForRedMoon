using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEditor;

public class CharacterDragAndDropSystem : MonoBehaviour
{
    public SpriteRenderer Avatar;

    //[HideInInspector]
    public Character DragCharacter;
    public LayerMask layerMask;
    private Transform _transform;
    private void Start()
    {
        SetDragCharacter(DragCharacter);
        _transform = transform;
    }
    private void Update() 
    {
        _transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        if(Input.GetMouseButtonUp(0)){
            DropSystem();
            ClearDragCharacter();
        }
        if(Input.GetMouseButtonDown(0))
            {
                GetCharacterOnClick();
            }
    }
    private void DropSystem(){
        if(DragCharacter == null)
            return;
        RaycastHit2D[] hits =
        Physics2D.RaycastAll(transform.position, Vector2.zero,20,layerMask);
        foreach(var a in hits){
            Location location;
            a.transform.TryGetComponent<Location>(out location);
            if(location){
                location.SendCharacterToMission(DragCharacter);
            }
        }
    }
    private void ClearDragCharacter()
    {
        Avatar.sprite = null;
        DragCharacter = null;
    }
    public void SetDragCharacter(Character newCharacter){
        DragCharacter = newCharacter;
        Avatar.sprite = DragCharacter.Avatar;
    }
    private Character GetCharacterOnClick(){
        return null;
    }
}
