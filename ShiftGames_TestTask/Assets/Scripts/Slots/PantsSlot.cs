using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsSlot : Slot
{
    [SerializeField]
    List<LegsEquipment> pantsEquipments;

    public override void FillDropDown()
    {
        List<string> newOptionsNames = new List<string>();

        for (int i = 0; i < pantsEquipments.Count; i++)
        {
            newOptionsNames.Add(pantsEquipments[i].EquipmentName);
        }

        EquipDropdown.ClearOptions();
        EquipDropdown.AddOptions(newOptionsNames);
    }

    public override void OnStatsChanger(int _value)
    {
        var _selectedName = EquipDropdown.options[_value].text;
        var _newEquipment = pantsEquipments.Find(_eq => _eq.EquipmentName == _selectedName);

        ChangePantsAction.Invoke(_newEquipment);
    }
}
