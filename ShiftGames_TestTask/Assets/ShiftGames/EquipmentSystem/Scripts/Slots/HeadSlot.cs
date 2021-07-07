using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlot : Slot
{
    [SerializeField]
    private List<HeadEquipment> headEquipments;

    public override void FillDropDown()
    {
        List<string> newOptionsNames = new List<string>();

        for (int i = 0; i < headEquipments.Count; i++)
        {
            newOptionsNames.Add(headEquipments[i].EquipmentName);
        }

        EquipDropdown.ClearOptions();
        EquipDropdown.AddOptions(newOptionsNames);
    }

    public override void OnStatsChanger(int value)
    {
        string selectedName = EquipDropdown.options[value].text;
        var newEquipment = headEquipments.Find(_eq => _eq.EquipmentName == selectedName);

        ChangeHeadAction.Invoke(newEquipment); 
    }
}
