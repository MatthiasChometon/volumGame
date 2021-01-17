using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour {
    protected int bonusOrMalusRange;

    void OnCollisionStay2D (Collision2D collision) {

        if (collision.gameObject.tag == "player") {
            chooseBonusOrMalus(collision);
            Destroy (gameObject);
        }

        if (collision.gameObject.tag == "minotaur") {
            Destroy (gameObject);
        }
    }

    public virtual void chooseBonusOrMalus(Collision2D collision) {}
}