using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlot : Slot
{
    [SerializeField]
    List<HeadEquipment> headEquipments;

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

    public override void OnStatsChanger(int _value)
    {
        var _selectedName = EquipDropdown.options[_value].text;
        var _newEquipment = headEquipments.Find(_eq => _eq.EquipmentName == _selectedName);

        ChangeHeadAction.Invoke(_newEquipment); 
    }
}
