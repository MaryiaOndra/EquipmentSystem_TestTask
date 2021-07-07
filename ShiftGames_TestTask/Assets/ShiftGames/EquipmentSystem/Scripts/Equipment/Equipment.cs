using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : ScriptableObject
{
    [SerializeField]
    private string equipmentName;

    [Header("Stats")]
    [SerializeField]
    private int _armor;

    [SerializeField]
    private int _strenght;

    [SerializeField]
    private int _agility;

    [SerializeField]
    private int _maxSpeed;

    [SerializeField]
    private int _convenience;

    public string EquipmentName => equipmentName;
    public int Armor => _armor;
    public int Strenght => _strenght;
    public int Agility => _agility;
    public int MaxSpeed => _maxSpeed;
    public int Convenience => _convenience;
}
