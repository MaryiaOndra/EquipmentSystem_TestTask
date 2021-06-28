using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [Header("HeadEquipment")]
    [SerializeField]
    Dropdown headDropdown;
    [SerializeField]
    List<Equipment> headEquipments;

    List<string> newOptionsNames;

    public Action<Equipment> ChangeItemAction;

    private void OnEnable()
    {
        headDropdown.onValueChanged.AddListener(OnStatsChanger);
    }

    private void OnDisable()
    {
        headDropdown.onValueChanged.RemoveListener(OnStatsChanger);
    }

    private void Awake()
    {
        newOptionsNames = new List<string>();

        for (int i = 0; i < headEquipments.Count; i++)
        {
            newOptionsNames.Add(headEquipments[i].EquipmentName);
        }

        headDropdown.ClearOptions();
        headDropdown.AddOptions(newOptionsNames);
    }

    public void OnStatsChanger(int _value)
    {
        var _selectedName = headDropdown.options[_value].text;
        var _newEquipment = headEquipments.Find(_eq => _eq.EquipmentName == _selectedName);

        ChangeItemAction.Invoke(_newEquipment);
    }
}
