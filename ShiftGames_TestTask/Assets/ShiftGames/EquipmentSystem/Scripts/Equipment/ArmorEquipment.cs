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
    private Mesh _torsoPlace;

    [PreviewField()]
    [SerializeField]
    private Mesh _upperArmRightPlace;

    [PreviewField()]
    [SerializeField]
    private Mesh _lowerArmRightPlace;

    [PreviewField()]
    [SerializeField]
    private Mesh _upperArmLeftPlace;

    [PreviewField()]
    [SerializeField]
    private Mesh _lowerArmLeftPlace;

    [PreviewField()]
    [SerializeField]
    private Mesh _handRightPlace;

    [PreviewField()]
    [SerializeField]
    private Mesh _handLeftPlace;

    public Mesh TorsoPlace => _torsoPlace;

    public Mesh UpperArmRightPlace => _upperArmRightPlace;

    public Mesh LowerArmRightPlace => _lowerArmRightPlace;

    public Mesh UpperArmLeftPlace => _upperArmLeftPlace;

    public Mesh LowerArmLeftPlace => _lowerArmLeftPlace;

    public Mesh HandRightPlace => _handRightPlace;
    public Mesh HandLeftPlace => _handLeftPlace;
}
