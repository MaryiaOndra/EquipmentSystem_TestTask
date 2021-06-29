using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("NewEquipment/HeadEquipment"), fileName = ("NewHeadEquipment"))]
public class HeadEquipment : Equipment
{
    [PreviewField()]
    [SerializeField]
    Mesh headMesh; 
    [PreviewField()]
    [SerializeField]
    Mesh headAttacjmentMesh;

    public Mesh HeadMesh  => headMesh;
    public Mesh HeadAttacjmentMesh  => headAttacjmentMesh;
}
