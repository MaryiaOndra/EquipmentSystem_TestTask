using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Slot : MonoBehaviour
{
    [SerializeField]
    private Dropdown equipDropdown;

    protected Dropdown EquipDropdown => equipDropdown;

    public Action<HeadEquipment> ChangeHeadAction;
    public Action<ArmorEquipment> ChangeArmorAction;
    public Action<LegsEquipment> ChangePantsAction;
    public Action<WeaponEquipment> ChangeWeaponAction;

    private void OnEnable()
    {
        equipDropdown.onValueChanged.AddListener(OnStatsChanger);
    }

    private void OnDisable()
    {
        equipDropdown.onValueChanged.RemoveListener(OnStatsChanger);
    }

    private void Awake()
    {
        FillDropDown();
    }

    private void Start()
    {
        OnStatsChanger(0);
    }

    public abstract void FillDropDown();

    public abstract void OnStatsChanger(int _value);
}
