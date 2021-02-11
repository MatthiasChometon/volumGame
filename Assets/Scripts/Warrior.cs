using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour {
    public string warriorName;
    public float lifePoints;
    public float attackPoints;
    public float defensePoints = 0;
    public bool inContact = false;
    public Warrior ObjectInContact;
    public string type = "";
    private PlayerMove playerMove;
    public string phase = "opponent turn";
    public bool skipTurn = false;

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
        if (this.phase == "my turn" && inContact == true && this.ObjectInContact.type != this.type) {
            this.phase = this.ObjectInContact.takeDamage (attackPoints);
        }
    }

    public string takeDamage (float damage) {
        this.lifePoints -= Mathf.Abs (damage - defensePoints);
        if (this.lifePoints <= 0) {
            return "end game";
        }
        return "end phase";
    }

    public void chooseStrategy () {
        if (type == "boss") {
            if (inContact == true) {
                phase = "my turn";
                attack ();
            } else {
                phase = "move";
            }
        } else {
            if (skipTurn == false) {
                phase = "my turn";
            } else {
                phase = "end phase";
                skipTurn = false;
            }
        }
    }
}