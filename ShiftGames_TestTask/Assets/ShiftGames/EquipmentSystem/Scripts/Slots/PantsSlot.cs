using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsSlot : Slot
{
    [SerializeField]
    private List<LegsEquipment> _pantsEquipments;

    public override void FillDropDown()
    {
        List<string> newOptionsNames = new List<string>();

        for (int i = 0; i < _pantsEquipments.Count; i++)
        {
            newOptionsNames.Add(_pantsEquipments[i].EquipmentName);
        }

        EquipDropdown.ClearOptions();
        EquipDropdown.AddOptions(newOptionsNames);
    }

    public override void OnStatsChanger(int value)
    {
        string _selectedName = EquipDropdown.options[value].text;
        LegsEquipment newEquipment = _pantsEquipments.Find(_eq => _eq.EquipmentName == _selectedName);

        ChangePantsAction.Invoke(newEquipment);
    }
}
