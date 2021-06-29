using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("NewEquipment/TorsoEquipment"),fileName = ("NewTorsoEquipment"))]
public class ArmorEquipment : Equipment
{
    [Header("Meshes")]
    [PreviewField()]
    [SerializeField]
    Mesh torsoPlace;

    [PreviewField()]
    [SerializeField]
    Mesh upperArmRightPlace;

    [PreviewField()]
    [SerializeField]
    Mesh lowerArmRightPlace;

    [PreviewField()]
    [SerializeField]
    Mesh upperArmLeftPlace;

    [PreviewField()]
    [SerializeField]
    Mesh lowerArmLeftPlace;

    [PreviewField()]
    [SerializeField]
    Mesh handRightPlace;

    [PreviewField()]
    [SerializeField]
    Mesh handLeftPlace;

    public Mesh TorsoPlace => torsoPlace;

    public Mesh UpperArmRightPlace => upperArmRightPlace;

    public Mesh LowerArmRightPlace => lowerArmRightPlace;

    public Mesh UpperArmLeftPlace => upperArmLeftPlace;

    public Mesh LowerArmLeftPlace => lowerArmLeftPlace;

    public Mesh HandRightPlace => handRightPlace;
    public Mesh HandLeftPlace => handLeftPlace;
}
