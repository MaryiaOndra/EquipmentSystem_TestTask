using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorSlot : Slot<ArmorEquipment>
{
    [SerializeField]
    private List<ArmorEquipment> _armorEquipments;

    public override List<ArmorEquipment> Equipments => _armorEquipments;

    protected override EquipmentType SlotType => EquipmentType.ARMOR;

    protected override ArmorEquipment GetEquipment(string name)
    {
        var selectedEqupment = _armorEquipments.Find(_eq => _eq.EquipmentName == name);
        return selectedEqupment;
    }

    protected override string GetName(int index)
    {
        string name = _armorEquipments[index].EquipmentName;
        return name;
    }
}
