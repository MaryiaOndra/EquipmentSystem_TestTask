using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType {HEAD, TORSO, LEGS, WEAPON }
[CreateAssetMenu(fileName = ("NewEquipment"))]
public class Equipment : ScriptableObject
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

    [Header("Meshes")]
    [SerializeField]
    Mesh mesh;

    public Mesh Mesh => mesh;
    public string EquipmentName => equipmentName;
    public EquipmentType EquipmentType => equipmentType;
    public int Armor => armor;
    public int Strenght => strenght;
    public int Agility => agility;
    public int MaxSpeed => maxSpeed;
    public int Convenience => convenience;
}
