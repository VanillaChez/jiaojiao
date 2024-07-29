using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Bird : ScriptableObject
{
    public string species; // 鸟的种类  
    public Vector3 position; // 鸟的位置
    public Sprite birdSprite;//鸟的贴图
}
