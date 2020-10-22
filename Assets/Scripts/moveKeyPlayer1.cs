using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveKeyPlayer1 : MonoBehaviour 
{
    public Vector3 translationH;
    public Vector3 translationV;
    public Turn turn;

    void Start () {
        translationH.y = 2f;
        translationV.x = 2f;
    }

    private void Update () {
        if(turn.turnNumber % 3 == 0) {
            if (Input.GetKey ("up")) {
                turn.nextTurn();
                transform.Translate (translationH);
            }
            if (Input.GetKey ("down")) {
                turn.nextTurn();
                transform.Translate (-translationH);
            }
            if (Input.GetKey ("right")) {
                turn.nextTurn();
                transform.Translate (translationV);
            }
            if (Input.GetKey ("left")) {
                turn.nextTurn();
                transform.Translate (-translationV);
            }
        }
    }
}