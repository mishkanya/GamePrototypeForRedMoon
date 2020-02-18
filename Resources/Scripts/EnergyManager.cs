using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnergyManager : MonoBehaviour
{
    public TextMeshProUGUI EnergyInfoText;
    public int EnegryOnStep = 0;
    [SerializeField]
    public int EnergyDefault = 10;
    private void Start() {
        ResetDaylyEnergy();
    }

    public void ChangeEnergyUIInfo()
    {
        if(EnergyInfoText)
            EnergyInfoText.text = $"{EnegryOnStep}/{EnergyDefault}";
    }
    public bool MinusEnergy(int NeedingEnergy){
        if(EnegryOnStep >= NeedingEnergy){
            EnegryOnStep -= NeedingEnergy;
            ChangeEnergyUIInfo();
            return true;
        }
        else{
            return false;
        }
    }
    public void ResetDaylyEnergy(){
        EnegryOnStep = EnergyDefault;
        ChangeEnergyUIInfo();
    }
}
