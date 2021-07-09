using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : Slot<WeaponEquipment>
{
    [SerializeField]
    private List<WeaponEquipment> _weaponEquipments;

    public override List<WeaponEquipment> Equipments => _weaponEquipments;

    protected override EquipmentType SlotType => EquipmentType.WEAPON;

    protected override WeaponEquipment GetEquipment(string name)
    {
        var selectedEqupment = _weaponEquipments.Find(_eq => _eq.EquipmentName == name);
        return selectedEqupment;
    }

    protected override string GetName(int index)
    {
        string name = _weaponEquipments[index].EquipmentName;
        return name;
    }
}
