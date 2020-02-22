using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewStepButton : MonoBehaviour, IPointerClickHandler
{
    private EnergyManager _energyManager;
    [HideInInspector]
    public List<Location> AllLocation = new List<Location>();
    private void Start() {
        _energyManager = GameObject.FindGameObjectWithTag("EnergyManager").GetComponent<EnergyManager>();
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
        AllLocation[0].MissionTab.gameObject.SetActive(false);
        _energyManager.ResetDaylyEnergy();
    }
    
}
