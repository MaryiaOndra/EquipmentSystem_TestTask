using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public abstract class Slot<T> : MonoBehaviour
{
    public abstract List<T> Equipments { get; }
    protected abstract EquipmentType SlotType { get; }

    private Dropdown _equipDropdown;
    public Action<EquipmentType, string> OnEquipmentChanged;
   
    //public Action<HeadEquipment> OnHeadChanged;
    //public Action<ArmorEquipment> OnArmorChanged;
    //public Action<WeaponEquipment> OnWeaponChanged;

    private void OnEnable()
    {
        _equipDropdown.onValueChanged.AddListener(OnStatsChanger);
    }

    private void OnDisable()
    {
        _equipDropdown.onValueChanged.RemoveListener(OnStatsChanger);
    }

    private void Awake()
    {
        _equipDropdown = GetComponentInChildren<Dropdown>();

        if(_equipDropdown)
            FillDropDown();
        else
            throw new Exception("Add dropdown");
    }

    //private void Start()
    //{
    //    OnStatsChanger(0);
    //}

    //public abstract void FillDropDown();

    //public abstract void OnStatsChanger(int _value);

    protected abstract string GetName(int index);
    protected abstract T GetEquipment(string name);

    protected void FillDropDown()
    {
        List<string> newOptionsNames = new List<string>();

        for (int i = 0; i < Equipments.Count; i++)
        {
            string newName = GetName(i);
            newOptionsNames.Add(newName);
        }

        _equipDropdown.ClearOptions();
        _equipDropdown.AddOptions(newOptionsNames);
    }

    protected void OnStatsChanger(int value)
    {
        string selectedName = _equipDropdown.options[value].text;
        T newEquipment = GetEquipment(selectedName);
        //OnEquipmentChanged?.Invoke( selectedName);
    }
}
