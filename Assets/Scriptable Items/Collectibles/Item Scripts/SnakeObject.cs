using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Snake Object", menuName = "Inventory System/Items/Snake")]
public class SnakeObject : ItemObject
{
    public float doDamage;
    public void Awake()
    {
        type = ItemType.Snake;
    }
    
}