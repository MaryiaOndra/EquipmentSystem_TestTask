using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : Slot
{
    [SerializeField]
    List<WeaponEquipment> weaponEquipments;

    public override void FillDropDown()
    {
        List<string> newOptionsNames = new List<string>();

        for (int i = 0; i < weaponEquipments.Count; i++)
        {
            newOptionsNames.Add(weaponEquipments[i].EquipmentName);
        }

        EquipDropdown.ClearOptions();
        EquipDropdown.AddOptions(newOptionsNames);
    }

    public override void OnStatsChanger(int _value)
    {
        var _selectedName = EquipDropdown.options[_value].text;
        var _newEquipment = weaponEquipments.Find(_eq => _eq.EquipmentName == _selectedName);

        ChangeWeaponAction.Invoke(_newEquipment);
    }
}
