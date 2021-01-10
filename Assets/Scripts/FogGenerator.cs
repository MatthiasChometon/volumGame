using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogGenerator : MonoBehaviour {
    private GameObject[] allGround;
    private GameObject[] allWall;
    private GameObject[] allPlayer;
    private GameObject[] allBmo;
    private GameObject[] allBoss;
    public GameObject ground;
    private Color caseColor;
    public int caseSize = 2;

    void Start () {
        ground.GetComponent<SpriteRenderer> ().color = Color.black;
        allGround = GameObject.FindGameObjectsWithTag ("ground");
        allWall = GameObject.FindGameObjectsWithTag ("wall");
        allBoss = GameObject.FindGameObjectsWithTag ("minotaur");
        allPlayer = GameObject.FindGameObjectsWithTag ("player");
    }

    void Update () {
        allBmo = GameObject.FindGameObjectsWithTag ("bmo");
        MakeFogForObject (allGround);
        MakeFogForObject (allWall);
        MakeFogForObject (allBoss);
        MakeFogForObject (allBmo);
    }

    private void MakeFogForObject (GameObject[] allObject) {
        foreach (GameObject objectToFog in allObject) {
            foreach (GameObject player in allPlayer) {
                objectToFog.GetComponent<SpriteRenderer> ().color = Color.black;
            }

        }
        foreach (GameObject objectToFog in allObject) {
            foreach (GameObject player in allPlayer) {
                if (player.transform.position.x - caseSize <= objectToFog.transform.position.x &&
                    player.transform.position.x + caseSize >= objectToFog.transform.position.x &&
                    player.transform.position.y - caseSize <= objectToFog.transform.position.y &&
                    player.transform.position.y + caseSize >= objectToFog.transform.position.y) {
                    objectToFog.GetComponent<SpriteRenderer> ().color = Color.white;
                }
            }

        }
    }
}