using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectItem : MonoBehaviour {
    public InventoryObject inventory;
    public GameObject objectItem;
    public Text objectCount;
    public Warrior player;

    protected void deleteOneFromInventory (string ItemName) {
        foreach (InventorySlot item in inventory.Container) {
            if (item.item.name == ItemName) {
                item.amount -= 1;
                objectCount.text = item.amount.ToString ();
                if (item.amount == 0) {
                    objectItem.SetActive (false);
                }
            }
        }
    }
}