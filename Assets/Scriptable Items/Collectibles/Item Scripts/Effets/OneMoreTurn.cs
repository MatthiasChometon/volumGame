using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneMoreTurn : ObjectItem {
    public void GiveOneTurn () {
        if (player.phase == "my turn") {
            player.oneMoreTurn = 3;
            deleteOneFromInventory ("Flying boot");
        }
    }
}