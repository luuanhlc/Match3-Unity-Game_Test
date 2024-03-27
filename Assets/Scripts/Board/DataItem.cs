using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item Data", menuName = "Item")]
public class DataItem : ScriptableObject
{
    public List<Sprite> Sprite_Item = new List<Sprite>(); 
}