using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{
    [SerializeField]
    private Character _character; 

    private List<Slot<Equipment>> _slots;
    private Stats _stats;

    private void Awake() 
    {
        _slots = new List<Slot<Equipment>>(GetComponentsInChildren<Slot<Equipment>>());
        _stats = GetComponentInChildren<Stats>();

        _slots.ForEach(_s => _s.OnEquipmentChanged = FindEquipment);


    }

    void FindEquipment(EquipmentType eqType, string name ) 
    {
        for (int i = 0; i < _slots.Count; i++)
        {
            List<Equipment> list = _slots[i].Equipments;

            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].EquipmentType == eqType && list[j].EquipmentName == name)
                {
                    Debug.Log(list[j].EquipmentName);
                    _character.ChangeEquipment(list[j]);
                }
            }
        }
    }
}
