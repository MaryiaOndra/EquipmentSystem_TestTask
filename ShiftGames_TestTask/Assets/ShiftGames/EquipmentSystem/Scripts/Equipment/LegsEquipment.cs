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
    private Mesh _hipsMesh;

    [PreviewField()]
    [SerializeField]
    private Mesh _rightLegMesh;
    
    [PreviewField()]
    [SerializeField]
    private Mesh _leftLegMesh;

    public Mesh HipsMesh => _hipsMesh;
    public Mesh RightLegMEsh => _rightLegMesh;
    public Mesh LeftLegMEsh => _leftLegMesh;
}
