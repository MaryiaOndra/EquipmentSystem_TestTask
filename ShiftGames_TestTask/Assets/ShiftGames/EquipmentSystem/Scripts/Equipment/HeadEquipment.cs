using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("NewEquipment/HeadEquipment"), fileName = ("NewHeadEquipment"))]
public class HeadEquipment : Equipment
{

    [PreviewField()]
    [SerializeField]
    private Mesh headMesh; 

    [PreviewField()]
    [SerializeField]
    private Mesh headAttacjmentMesh;  
    
    [PreviewField()]
    [SerializeField]
    private Mesh faceHairMesh;  
    
    [PreviewField()]
    [SerializeField]
    private Mesh eyebrowMesh;

    public Mesh HeadMesh  => headMesh;
    public Mesh HeadAttacjmentMesh  => headAttacjmentMesh;
    public Mesh FaceHairMesh => faceHairMesh;
    public Mesh EyebrowMesh => eyebrowMesh;
}
