using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
            ClearDragCharacter();
        }
        if(Input.GetMouseButtonDown(0))
            GetCharacterOnClick();
    }

    private void OnMouseUpAsButton() {
        print("Fuck");
    }
    private void ClearDragCharacter()
    {
        Avatar.sprite = null;
        DragCharacter = null;
    }
    private void SetDragCharacter(Character newCharacter){
        DragCharacter = newCharacter;
        Avatar.sprite = DragCharacter.Avatar;
    }
    private Character GetCharacterOnClick(){
         RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
           Debug.Log(hit.collider.gameObject.name);
        }
        else
        {
           Debug.Log("Did not Hit");
        }
        return null;
    }
}
