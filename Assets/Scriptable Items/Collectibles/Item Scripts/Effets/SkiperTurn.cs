using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiperTurn : ObjectItem {
    public Warrior warrior;

    public void skip () {
        if (player.phase == "my turn") {
            warrior.skipTurn = true;
            player.phase = "end phase";
            deleteOneFromInventory ("Injured boot");
        }
    }
}