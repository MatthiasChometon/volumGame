using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogGenerator : MonoBehaviour {
    private GameObject[] allCase;
    private GameObject[] allPlayer;
    private GameObject[] allBmo;
    private Color caseColor;
    public int caseSize = 2;

    void Start () {
        allCase = GameObject.FindGameObjectsWithTag ("case");
        allPlayer = GameObject.FindGameObjectsWithTag ("player");
    }

    void Update () {
        allBmo = GameObject.FindGameObjectsWithTag ("bmo");
        MakeFogForObject (allCase);
        MakeFogForObject (allBmo);
    }

    private void MakeFogForObject (GameObject[] allObject) {
        foreach (GameObject objectToFog in allObject) {
            foreach (GameObject player in allPlayer) {
                if (player.transform.position.x - caseSize <= objectToFog.transform.position.x &&
                    player.transform.position.x + caseSize >= objectToFog.transform.position.x &&
                    player.transform.position.y - caseSize <= objectToFog.transform.position.y &&
                    player.transform.position.y + caseSize >= objectToFog.transform.position.y) {
                    objectToFog.GetComponent<SpriteRenderer> ().color = Color.white;
                } else {

                    objectToFog.GetComponent<SpriteRenderer> ().color = Color.black;
                }
            }

        }
    }
}