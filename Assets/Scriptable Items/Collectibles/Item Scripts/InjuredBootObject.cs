using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New InjuredBoot Object", menuName = "Inventory System/Items/InjuredBoot")]
public class InjuredBootObject : ItemObject
{
    public float onelessTurn;
    public void Awake()
    {
        type = ItemType.InjuredBoot;
    }
}
