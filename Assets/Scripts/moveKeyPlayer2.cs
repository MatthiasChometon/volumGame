using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveKeyPlayer2 : MonoBehaviour
{
    public Vector3 translationH;
    public Vector3 translationV;
    public Turn turn;

    void Start () {
        translationH.y = 2f;
        translationV.x = 2f;
    }

    private void Update () {
        if(turn.turnNumber % 3 == 2) {
            if (Input.GetKey ("z")) {
                turn.nextTurn();
                transform.Translate (translationH);
            }
            if (Input.GetKey ("s")) {
                turn.nextTurn();
                transform.Translate (-translationH);
            }
            if (Input.GetKey ("d")) {
                turn.nextTurn();
                transform.Translate (translationV);
            }
            if (Input.GetKey ("q")) {
                turn.nextTurn();
                transform.Translate (-translationV);
            }
        }
    }
}
