using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    BaseCharacterStats baseCharacterStats;

    #region BODY_PART_PLACEMENT
    [Header("BodyParts")]
    [Header("Head")]
    [SerializeField]
    SkinnedMeshRenderer headCovering;
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
    [SerializeField]
    SkinnedMeshRenderer rightLeg;
    [SerializeField]
    SkinnedMeshRenderer leftLeg;
    #endregion

    Equipment oldEquipment;
    Equipment newEquipment;

    public int Armor { get; private set; }
    public int Strenght { get; private set; }
    public int Agility { get; private set; }
    public int MaxSpeed { get; private set; }
    public int Convenience { get; private set; }

    public Action UpdateStatsAction;
    public Action<Equipment> UpdateEquipmentAction;

    private void Awake()
    {
        UpdateEquipmentAction = ChangeEquipment;
    }

    public void ChangeEquipment(Equipment _new)
    {
        switch (_new.EquipmentType)
        {
            case EquipmentType.HEAD:
                ChangeHelmet((HeadEquipment)_new);
                break;
            case EquipmentType.LEGS:
                ChangePants(_new);
                break;
            case EquipmentType.TORSO:
                ChangeArmor((TorsoEquipment)_new);
                break;
            case EquipmentType.WEAPON:
                ChangeWeapon(_new);
                break;
        }

        oldEquipment = newEquipment;
        newEquipment = _new;

        UpdateStats(oldEquipment, newEquipment);
        UpdateStatsAction.Invoke();
    }

    void UpdateStats(Equipment _old, Equipment _new)
    {
        if (_old != null)
        {
            Armor -= _old.Armor;
            Strenght -= _old.Strenght;
            Agility -= _old.Agility;
            MaxSpeed -= _old.MaxSpeed;
            Convenience -= _old.Convenience;
        }

        Armor = baseCharacterStats.Armor + _new.Armor;
        Strenght = baseCharacterStats.Strenght + _new.Strenght;
        Agility = baseCharacterStats.Agility + _new.Agility;
        MaxSpeed = baseCharacterStats.MaxSpeed + _new.MaxSpeed;
        Convenience = baseCharacterStats.Convenience + _new.Convenience;
    }

    void ChangeHelmet(HeadEquipment _new)
    {
        headPlace.sharedMesh = _new.HeadMesh;
        headCovering.sharedMesh = _new.HeadAttacjmentMesh;
    }

    void ChangeArmor(TorsoEquipment _new)
    {
        torsoPlace.sharedMesh = _new.TorsoPlace;
        upperArmRightPlace.sharedMesh = _new.UpperArmRightPlace;
        lowerArmRightPlace.sharedMesh = _new.LowerArmRightPlace;
        handRightPlace.sharedMesh = _new.HandRightPlace;
        upperArmLeftPlace.sharedMesh = _new.UpperArmLeftPlace;
        lowerArmLeftPlace.sharedMesh = _new.UpperArmLeftPlace;
        handLeftPlace.sharedMesh = _new.HandLeftPlace;
    }

    void ChangePants(Equipment _new)
    {

    }


    void ChangeWeapon(Equipment _new)
    {

    }
}
