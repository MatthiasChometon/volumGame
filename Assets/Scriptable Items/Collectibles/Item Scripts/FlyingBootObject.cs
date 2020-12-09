using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New FlyingBoot Object", menuName = "Inventory System/Items/FlyingBoot")]
public class FlyingBootObject : ItemObject
{
    public float onemoreTurn;
    public void Awake()
    {
        type = ItemType.FlyingBoot;
    }
}
