using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private BaseCharacterStats _baseCharacterStats;

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

    private Equipment _oldEquipment;
    private Equipment _newEquipment;

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

    private void ChangeHead(HeadEquipment newEquip)
    {
        headPlace.sharedMesh = newEquip.HeadMesh;
        headCovering.sharedMesh = newEquip.HeadAttacjmentMesh;
        faceHairPlace.sharedMesh = newEquip.FaceHairMesh;
        eyebrowPlace.sharedMesh = newEquip.EyebrowMesh;

        UpdateStats(newEquip);
    }

    private void ChangeTorso(ArmorEquipment newEquip)
    {
        torsoPlace.sharedMesh = newEquip.TorsoPlace;
        upperArmRightPlace.sharedMesh = newEquip.UpperArmRightPlace;
        lowerArmRightPlace.sharedMesh = newEquip.LowerArmRightPlace;
        handRightPlace.sharedMesh = newEquip.HandRightPlace;
        upperArmLeftPlace.sharedMesh = newEquip.UpperArmLeftPlace;
        lowerArmLeftPlace.sharedMesh = newEquip.UpperArmLeftPlace;
        handLeftPlace.sharedMesh = newEquip.HandLeftPlace;

        UpdateStats(newEquip);
    }

    private void ChangePants(LegsEquipment newEquip)
    {
        hipsPlace.sharedMesh = newEquip.HipsMesh;
        leftLeg.sharedMesh = newEquip.LeftLegMEsh;
        rightLeg.sharedMesh = newEquip.RightLegMEsh;

        UpdateStats(newEquip);
    }

    private void ChangeWeapon(WeaponEquipment newEquip)
    {
        Debug.Log("CHANGE WEAPON");
        UpdateStats(newEquip);
    }

    private void UpdateStats(Equipment newEquip)
    {
        _oldEquipment = _newEquipment;
        _newEquipment = newEquip;

        if (_oldEquipment != null)
        {
            Armor -= _oldEquipment.Armor;
            Strenght -= _oldEquipment.Strenght;
            Agility -= _oldEquipment.Agility;
            MaxSpeed -= _oldEquipment.MaxSpeed;
            Convenience -= _oldEquipment.Convenience;
        }

        Armor = _baseCharacterStats.Armor + newEquip.Armor;
        Strenght = _baseCharacterStats.Strenght + newEquip.Strenght;
        Agility = _baseCharacterStats.Agility + newEquip.Agility;
        MaxSpeed = _baseCharacterStats.MaxSpeed + newEquip.MaxSpeed;
        Convenience = _baseCharacterStats.Convenience + newEquip.Convenience;

        UpdateStatsAction.Invoke();
    }
}
