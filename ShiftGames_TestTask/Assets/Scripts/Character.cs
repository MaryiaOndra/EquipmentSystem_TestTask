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
    [SerializeField]
    SkinnedMeshRenderer faceHairPlace; 
    [SerializeField]
    SkinnedMeshRenderer eyebrowPlace;

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

    public Action<HeadEquipment> UpdateHeadAction;
    public Action<ArmorEquipment> UpdateArmorAction;
    public Action<LegsEquipment> UpdatePantsAction;
    public Action<WeaponEquipment> UpdateWeaponAction;

    private void Awake()
    {
        UpdateHeadAction = ChangeHead;
        UpdateArmorAction = ChangeTorso;
        UpdatePantsAction = ChangePants;
        UpdateWeaponAction = ChangeWeapon;
    }

    void ChangeHead(HeadEquipment _new)
    {
        headPlace.sharedMesh = _new.HeadMesh;
        headCovering.sharedMesh = _new.HeadAttacjmentMesh;
        faceHairPlace.sharedMesh = _new.FaceHairMesh;
        eyebrowPlace.sharedMesh = _new.EyebrowMesh;

        UpdateStats(_new);
    }

    void ChangeTorso(ArmorEquipment _new)
    {
        torsoPlace.sharedMesh = _new.TorsoPlace;
        upperArmRightPlace.sharedMesh = _new.UpperArmRightPlace;
        lowerArmRightPlace.sharedMesh = _new.LowerArmRightPlace;
        handRightPlace.sharedMesh = _new.HandRightPlace;
        upperArmLeftPlace.sharedMesh = _new.UpperArmLeftPlace;
        lowerArmLeftPlace.sharedMesh = _new.UpperArmLeftPlace;
        handLeftPlace.sharedMesh = _new.HandLeftPlace;

        UpdateStats(_new);
    }

    void ChangePants(LegsEquipment _new)
    {
        hipsPlace.sharedMesh = _new.HipsMesh;
        leftLeg.sharedMesh = _new.LeftLegMEsh;
        rightLeg.sharedMesh = _new.RightLegMEsh;

        UpdateStats(_new);
    }

    void ChangeWeapon(WeaponEquipment _new)
    {
        Debug.Log("CHANGE WEAPON");

        UpdateStats(_new);
    }

    void UpdateStats(Equipment _new)
    {
        oldEquipment = newEquipment;
        newEquipment = _new;

        if (oldEquipment != null)
        {
            Armor -= oldEquipment.Armor;
            Strenght -= oldEquipment.Strenght;
            Agility -= oldEquipment.Agility;
            MaxSpeed -= oldEquipment.MaxSpeed;
            Convenience -= oldEquipment.Convenience;
        }

        Armor = baseCharacterStats.Armor + _new.Armor;
        Strenght = baseCharacterStats.Strenght + _new.Strenght;
        Agility = baseCharacterStats.Agility + _new.Agility;
        MaxSpeed = baseCharacterStats.MaxSpeed + _new.MaxSpeed;
        Convenience = baseCharacterStats.Convenience + _new.Convenience;

        UpdateStatsAction.Invoke();
    }
}
