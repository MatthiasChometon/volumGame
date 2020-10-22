using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Battle : MonoBehaviour {

    public float lifePoints;
    public float attackPoints;
    public bool inContact = false;
    protected Battle ObjectInContact;

    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "minotaur" || collision.gameObject.tag == "player") {
            this.inContact = true;
            this.ObjectInContact = collision.gameObject.GetComponent<Battle> ();
            this.attack ();
        } else {
            this.inContact = false;
        }
    }

    public void attack () { }

    public void useItem () { }

    public abstract void takeDamage (float damage) { 
        Debug.Log("uo");
    }
}