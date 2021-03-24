using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testInventory : MonoBehaviour {
    public string name;
    public GameObject objectItem;
    public Text objectCount;

    public void testDisplay (List<InventorySlot> inventory) {
        Debug.Log(name);
        foreach (InventorySlot item in inventory) {
            if (item.item.name == name) {
                objectItem.SetActive (true);
                objectCount.text = item.amount.ToString();
            }
        }
    }

}