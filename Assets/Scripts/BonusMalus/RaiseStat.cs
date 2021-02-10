using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseStat : Stat {

    public override void chooseBonusOrMalus (Collision2D collision) {
        bonusOrMalusRange = Random.Range (1, 2);

        switch (bonusOrMalusRange) {
            case 1:
                collision.gameObject.GetComponent<Warrior> ().attackPoints += 3;
                break;
            case 2:
                collision.gameObject.GetComponent<Warrior> ().defensePoints += 3;
                break;
        }
    }
}