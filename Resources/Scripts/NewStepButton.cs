using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewStepButton : MonoBehaviour, IPointerClickHandler
{
    [HideInInspector]
    public List<Location> AllLocation = new List<Location>();
    private void Start() {
        GameObject[] s = GameObject.FindGameObjectsWithTag("Location");
        foreach(GameObject LocationGO in s){
            if(LocationGO.TryGetComponent(out Location location))
            AllLocation.Add(location);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        foreach(Location location in AllLocation){
            location.LoadNewStep();
        }
    }
    
}
