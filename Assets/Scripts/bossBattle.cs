using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossBattle : Battle {

    private new void attack () {
        if (inContact == true) {
            this.ObjectInContact.takeDamage(attackPoints);
        }
    }

    private new void useItem () {
        if (inContact == true) {

        }
    }

    private new void takeDamage (float damage) {
        this.lifePoints =- damage;
    }
}