using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("NewEquipment/WeaponEquipment"), fileName = ("NewWeaponEquipment"))]
public class WeaponEquipment : Equipment
{
    [PreviewField()]
    [SerializeField]
    private Mesh _weaponMesh;

    public Mesh WeapomMesh => _weaponMesh;
}
