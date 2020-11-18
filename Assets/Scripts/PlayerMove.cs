using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    private Vector3 translationH;
    private Vector3 translationV;
    public string up;
    public string down;
    public string left;
    public string right;
    public Warrior warrior;

    void Start () {
        translationH.y = 80f;
        translationV.x = 80f;
    }

    void Update () {
        if (warrior && warrior.phase == "my turn") {
            if (Input.GetKey (up)) {
                transform.Translate (translationH);
                warrior.phase = "end phase";
            }
            if (Input.GetKey (down)) {
                transform.Translate (-translationH);
                warrior.phase = "end phase";
            }
            if (Input.GetKey (right)) {
                transform.Translate (translationV);
                warrior.phase = "end phase";
            }
            if (Input.GetKey (left)) {
                transform.Translate (-translationV);
                warrior.phase = "end phase";
            }
        }
    }
}