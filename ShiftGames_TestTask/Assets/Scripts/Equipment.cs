using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType {HEAD, TORSO, LEGS, WEAPON }
public abstract class Equipment : ScriptableObject
{
    [SerializeField]
    string equipmentName;
    [SerializeField]
    EquipmentType equipmentType;
    [Header("Stats")]
    [SerializeField]
    int armor;
    [SerializeField]
    int strenght;
    [SerializeField]
    int agility;
    [SerializeField]
    int maxSpeed;
    [SerializeField]
    int convenience;

    public string EquipmentName => equipmentName;
    public EquipmentType EquipmentType => equipmentType;
    public int Armor => armor;
    public int Strenght => strenght;
    public int Agility => agility;
    public int MaxSpeed => maxSpeed;
    public int Convenience => convenience;
}
