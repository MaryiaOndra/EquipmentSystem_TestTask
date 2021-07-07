using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterStats")]
public class BaseCharacterStats : ScriptableObject
{
    [Header("BaseStats")]
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

    public int Armor => _armor;
    public int Strenght => _strenght;
    public int Agility => _agility;
    public int MaxSpeed => _maxSpeed;
    public int Convenience => _convenience;
}
