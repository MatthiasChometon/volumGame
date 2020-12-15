using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {
    private Vector3 translationH;
    private Vector3 translationV;
    public string movementDirection = "";
    public Transform block;

    void Start () {
        int luckWallMovement = Random.Range (1, 3);

        if (luckWallMovement == 1) {
            generateMovementWall ();
        }

    }

    private void generateMovementWall () {
        translationH.y = 2f;
        translationV.x = 2f;

        switch (movementDirection) {
            case "t":
                block.Translate (translationH);
                break;
            case "b":
                block.Translate (-translationH);
                break;
            case "l":
                block.Translate (translationV);
                break;
            case "r":
                block.Translate (translationV);
                break;
        }
    }
}