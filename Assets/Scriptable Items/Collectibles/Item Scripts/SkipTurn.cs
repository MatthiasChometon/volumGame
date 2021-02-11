using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipTurn : MonoBehaviour {
    public Warrior warrior;
    public Warrior player;
    public InventoryObject inventory;
    public GameObject objectItem;
    public Text objectCount;

    public void skip () {
        warrior.skipTurn = true;
        player.phase = "end phase";

        foreach (InventorySlot item in inventory.Container) {
            if (item.item.name == "Injured boot") {
                item.amount -= 1;
                objectCount.text = item.amount.ToString ();
                if (item.amount == 0) {
                    objectItem.SetActive (false);
                }
            }
        }
    }
}