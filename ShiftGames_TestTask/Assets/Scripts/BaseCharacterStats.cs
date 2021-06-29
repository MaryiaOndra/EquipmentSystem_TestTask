using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterStats")]
public class BaseCharacterStats : ScriptableObject
{
    [Header("BaseStats")]
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

    public int Armor => armor;
    public int Strenght => strenght;
    public int Agility => agility;
    public int MaxSpeed => maxSpeed;
    public int Convenience => convenience;
}
