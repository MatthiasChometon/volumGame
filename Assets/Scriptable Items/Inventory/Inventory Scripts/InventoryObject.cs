﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Inventory", menuName = "Inventory System/Inventory")]

public class InventoryObject : ScriptableObject {
    private GameObject[] objectList;
    public List<InventorySlot> Container = new List<InventorySlot> ();
    public List<InventorySlot> getInventory() {
    return this.Container;
}
    public void AddItem (ItemObject _item, int _amount) {
        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++) {
            if (Container[i].item == _item) {
                Container[i].AddAmount (_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem) {
            Container.Add (new InventorySlot (_item, _amount));
        }
    Debug.Log("bbbb");
    objectList = GameObject.FindGameObjectsWithTag ("object");
        foreach (GameObject item in objectList) {
            item.GetComponent<testInventory> ().testDisplay (Container);
            Debug.Log("untruc");
        }

    }
}

[System.Serializable]
public class InventorySlot {
    public ItemObject item;
    public int amount;
    public InventorySlot (ItemObject _item, int _amount) {
        item = _item;
        amount = _amount;
    }
    public void AddAmount (int value) {
        amount += value;
    }
}