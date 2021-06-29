using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("NewEquipment/TorsoEquipment"),fileName = ("NewTorsoEquipment"))]
public class TorsoEquipment : Equipment
{
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
    Mesh handRightPlace;

    [PreviewField()]
    [SerializeField]
    Mesh upperArmLeftPlace;

    [PreviewField()]
    [SerializeField]
    Mesh lowerArmLeftPlace;

    [PreviewField()]
    [SerializeField]
    Mesh handLeftPlace;

    public Mesh TorsoPlace => torsoPlace;

    public Mesh UpperArmRightPlace => upperArmRightPlace;

    public Mesh LowerArmRightPlace => lowerArmRightPlace;

    public Mesh HandRightPlace => handRightPlace;

    public Mesh UpperArmLeftPlace => UpperArmLeftPlace;

    public Mesh LowerArmLeftPlace => LowerArmLeftPlace;

    public Mesh HandLeftPlace => handLeftPlace;
}
