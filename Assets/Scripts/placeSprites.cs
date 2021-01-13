using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeSprites : MonoBehaviour {
    private GameObject[] labyListWall;
    private GameObject[] labyListGround;
    private GameObject[] labyListPlayer;
    private GameObject[] labyListBoss;
    public LabyList labyList;
    public bool casePlaced = false;

    void Start () {
        labyListWall = GameObject.FindGameObjectsWithTag ("wall");
        labyListGround = GameObject.FindGameObjectsWithTag ("ground");
        labyListPlayer = GameObject.FindGameObjectsWithTag ("player");
        labyListBoss = GameObject.FindGameObjectsWithTag ("boss");
        placeCase ();
        labyList.setBMO(labyListGround);
    }

    public void placeCase () {
        foreach (GameObject labyCube in labyListWall) {
            labyCube.transform.position = gainPosition (labyCube.transform.position);
        }
        foreach (GameObject labyCube in labyListGround) {
            labyCube.transform.position = gainPosition (labyCube.transform.position);
        }
        foreach (GameObject labyCube in labyListPlayer) {
            labyCube.transform.position = gainPosition (labyCube.transform.position);
        }
        foreach (GameObject labyCube in labyListBoss) {
            labyCube.transform.position = gainPosition (labyCube.transform.position);
        }
    }

    private Vector3 gainPosition (Vector3 cubePosition) {
        cubePosition.x -= 300;
        cubePosition.y -= 44;

        var cubePositionSX = rectifyPosition (cubePosition, "-", "x");
        var cubePositionAX = rectifyPosition (cubePosition, "+", "x");
        var cubePositionSY = rectifyPosition (cubePosition, "-", "y");
        var cubePositionAY = rectifyPosition (cubePosition, "+", "y");

        if (cubePosition.x - cubePositionSX.x < cubePositionAX.x - cubePosition.x) {
            if (cubePosition.y - cubePositionSY.y < cubePositionAY.y - cubePosition.y) {
                return new Vector3 (cubePositionSX.x + 300, cubePositionSY.y + 44, cubePosition.z);
            } else {
                return new Vector3 (cubePositionSX.x + 300, cubePositionAY.y + 44, cubePosition.z);
            }
        } else {
            if (cubePosition.y - cubePositionSY.y < cubePositionAY.y - cubePosition.y) {
                return new Vector3 (cubePositionAX.x + 300, cubePositionSY.y + 44, cubePosition.z);
            } else {
                return new Vector3 (cubePositionAX.x + 300, cubePositionAY.y + 44, cubePosition.z);
            }
        }

    }

    private Vector3 rectifyPosition (Vector3 cubePosition, string operation, string vector) {
        cubePosition.x = Mathf.RoundToInt (cubePosition.x);
        cubePosition.y = Mathf.RoundToInt (cubePosition.y);

        if (vector == "x" && cubePosition.x % 54 != 0) {
            if (operation == "-") {
                cubePosition.x = cubePosition.x - 1;
            }
            if (operation == "+") {
                cubePosition.x = cubePosition.x + 1;
            }
            return rectifyPosition (cubePosition, operation, vector);
        }

        if (vector == "y" && cubePosition.y % 54 != 0) {
            if (operation == "-") {
                cubePosition.y = cubePosition.y - 1;
            }
            if (operation == "+") {
                cubePosition.y = cubePosition.y + 1;
            }
            return rectifyPosition (cubePosition, operation, vector);
        }

        return cubePosition;
    }
}