using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSlot : Slot<HeadEquipment>
{
    [SerializeField]
    private List<HeadEquipment> _headEquipments;

    public override List<HeadEquipment> Equipments => _headEquipments;

    protected override EquipmentType SlotType => EquipmentType.HEAD;

    protected override HeadEquipment GetEquipment(string name)
    {
        var selectedEqupment = _headEquipments.Find(_eq => _eq.EquipmentName == name);
        return selectedEqupment;
    }

    protected override string GetName(int index)
    {
        string name = _headEquipments[index].EquipmentName;
        return name;
    }
}
