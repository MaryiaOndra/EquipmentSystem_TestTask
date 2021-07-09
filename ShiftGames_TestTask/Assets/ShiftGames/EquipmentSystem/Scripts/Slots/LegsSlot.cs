using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsSlot : Slot<LegsEquipment>
{
    [SerializeField]
    private List<LegsEquipment> _legsEquipments;

    public override List<LegsEquipment> Equipments => _legsEquipments;

    protected override EquipmentType SlotType => EquipmentType.LEGS;

    protected override string GetName(int index)
    {
        string name = _legsEquipments[index].EquipmentName;
        return name;
    }

    protected override LegsEquipment GetEquipment(string name)
    {
        var selectedEqupment = _legsEquipments.Find(_eq => _eq.EquipmentName == name);
        return selectedEqupment;
    }
}
