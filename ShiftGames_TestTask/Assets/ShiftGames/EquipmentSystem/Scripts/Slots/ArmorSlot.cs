using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorSlot : Slot
{
    [SerializeField]
    private List<ArmorEquipment> armorEquipments;

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

    public override void OnStatsChanger(int value)
    {
        string selectedName = EquipDropdown.options[value].text;
        ArmorEquipment newEquipment = armorEquipments.Find(_eq => _eq.EquipmentName == selectedName);

        ChangeArmorAction.Invoke(newEquipment);
    }
}
