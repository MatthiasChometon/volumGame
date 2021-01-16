using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour {
    public string warriorName;
    public float lifePoints;
    public float attackPoints;
    public bool inContact = false;
    protected Warrior ObjectInContact;
    public string type = "";
    private PlayerMove playerMove;
    public string phase = "opponent turn";

    void OnCollisionStay2D (Collision2D collision) {
        if (collision.gameObject.tag == "minotaur" || collision.gameObject.tag == "player") {
            this.inContact = true;
            this.ObjectInContact = collision.gameObject.GetComponent<Warrior> ();
        }
    }

    void OnCollisionExit2D (Collision2D collision) {
        this.inContact = false;
    }

    public void attack () {
        if (this.phase == "my turn" && inContact == true) {
            this.ObjectInContact.takeDamage (attackPoints);
            phase = "end phase";
        }
    }

    public void takeDamage (float damage) {
        this.lifePoints -= damage;
        if(this.lifePoints <= 0) {
            phase = "dead";
        }
    }

    public void chooseStrategy () {
        if (type == "boss") {
            if (inContact == true) {
                phase = "my turn";
                attack();
            } else {
                phase = "move";
            }
        } else {
            phase = "my turn";
        }
    }
}