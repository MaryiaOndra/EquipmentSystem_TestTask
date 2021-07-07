using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : Slot
{
    [SerializeField]
    private List<WeaponEquipment> weaponEquipments;

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

    public override void OnStatsChanger(int value)
    {
        string selectedName = EquipDropdown.options[value].text;
        WeaponEquipment newEquipment = weaponEquipments.Find(_eq => _eq.EquipmentName == selectedName);

        ChangeWeaponAction.Invoke(newEquipment);
    }
}
