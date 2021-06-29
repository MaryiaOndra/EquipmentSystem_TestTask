using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("NewEquipment/LegsEquipment"), fileName = ("NewLegsEquipment"))]
public class LegsEquipment : Equipment
{
    [Header("Meshes")]
    [PreviewField()]
    [SerializeField]
    Mesh hipsMesh;

    [PreviewField()]
    [SerializeField]
    Mesh rightLegMesh;
    
    [PreviewField()]
    [SerializeField]
    Mesh leftLegMesh;

    public Mesh HipsMesh => hipsMesh;
    public Mesh RightLegMEsh => rightLegMesh;
    public Mesh LeftLegMEsh => leftLegMesh;
}
