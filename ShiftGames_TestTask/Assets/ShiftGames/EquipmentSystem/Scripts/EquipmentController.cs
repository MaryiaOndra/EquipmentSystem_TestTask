using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{
    [SerializeField]
    private Character _character; 

    [SerializeField]

    private List<Slot<WeaponEquipment>> _slots;

    private Stats _stats;

    public void FillSlotList() 
    {
        _slots = new List<Slot<WeaponEquipment>>(GetComponentsInChildren<Slot<WeaponEquipment>>());
        _stats = GetComponentInChildren<Stats>();

        _slots.ForEach(_s => _s.OnEquipmentChanged = FindEquipment);

        Debug.Log("Slots: " + _slots.Count);
    }

    void FindEquipment<T>(T equip)
    {
        foreach (var slot in _slots)
        {
            if (slot is T)
            {
                Debug.Log("FindEquipment :" + slot.GetType());
            }
        }
    }

        static bool IsGenericTypeOf(Type genericType, Type someType)
        {
            if (someType.IsGenericType
                    && genericType == someType.GetGenericTypeDefinition()) return true;

            return someType.BaseType != null
                    && IsGenericTypeOf(genericType, someType.BaseType);
        }


        //for (int i = 0; i < _slots.Count; i++)
        //{
        //    List<Equipment> list = _slots[i].Equipments;

        //    for (int j = 0; j < list.Count; j++)
        //    {
        //        if (list[j].EquipmentType == eqType && list[j].EquipmentName == name)
        //        {
        //            Debug.Log(list[j].EquipmentName);
        //            _character.ChangeEquipment(list[j]);
        //        }
        //    }
        //}
    
}
