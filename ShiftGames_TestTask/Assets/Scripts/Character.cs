using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Armor { get; set; }
    public int Strenght { get; set; }
    public int Agility { get; set; }
    public int MaxSpeed { get; set; }
    public int Convenience { get; set; }

    [SerializeField]
    BaseCharacterStats baseCharacterStats;

    [Header("BodyParts")]
    [Header("Head")]
    [SerializeField]
    SkinnedMeshRenderer headPlace;

    [Header("Torso")]
    [SerializeField]
    SkinnedMeshRenderer torsoPlace;   
    [SerializeField]
    SkinnedMeshRenderer upperArmRightPlace;   
    [SerializeField]
    SkinnedMeshRenderer lowerArmRightPlace;     
    [SerializeField]
    SkinnedMeshRenderer handRightPlace;      
    [SerializeField]
    SkinnedMeshRenderer upperArmLeftPlace;   
    [SerializeField]
    SkinnedMeshRenderer lowerArmLeftPlace;     
    [SerializeField]
    SkinnedMeshRenderer handLeftPlace;    

    [Header("Legs")]
    [SerializeField]
    SkinnedMeshRenderer hipsPlace;


    public Action UpdateStatsAction;
    public Action<Equipment> UpdateEquipmentAction;

    private void Awake()
    {
        UpdateEquipmentAction = ChangeEquipment;

        //Armor = baseCharacterStats.Armor;
        //Strenght = baseCharacterStats.Strenght;
        //Agility = baseCharacterStats.Agility;
        //MaxSpeed = baseCharacterStats.MaxSpeed;
        //Convenience = baseCharacterStats.Convenience;
    }

    public void ChangeEquipment(Equipment _new)
    {
        switch (_new.EquipmentType)
        {
            case EquipmentType.HEAD:
                ChangeHelmet(_new);
                break;
            case EquipmentType.LEGS:
                ChangePants(_new);
                break;
            case EquipmentType.TORSO:
                ChangeArmor(_new);
                break;
            case EquipmentType.WEAPON:
                ChangeWeapon(_new);
                break;
        }

        UpdateStatsAction.Invoke();
    }

    void ChangeHelmet(Equipment _new)
    {
        headPlace.sharedMesh = _new.Mesh;
    }

    void ChangeArmor(Equipment _new)
    {
        torsoPlace.sharedMesh = _new.Mesh;
    }

    void ChangePants(Equipment _new)
    {

    }


    void ChangeWeapon(Equipment _new)
    {

    }
}
