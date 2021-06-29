using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorSlot : Slot
{
    [SerializeField]
    List<ArmorEquipment> armorEquipments;

    public override void FillDropDown()
    {
        List<string> newOptionsNames = new List<string>();

        for (int i = 0; i < armorEquipments.Count; i++)
        {
            newOptionsNames.Add(armorEquipments[i].EquipmentName);
        }

        EquipDropdown.ClearOptions();
        EquipDropdown.AddOptions(newOptionsNames);
    }

    public override void OnStatsChanger(int _value)
    {
        var _selectedName = EquipDropdown.options[_value].text;
        var _newEquipment = armorEquipments.Find(_eq => _eq.EquipmentName == _selectedName);

        ChangeArmorAction.Invoke(_newEquipment);
    }
}
