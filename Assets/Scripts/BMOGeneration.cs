using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMOGeneration : MonoBehaviour {
    public int luckGeneration = 3;
    public GameObject bonus;
    // public GameObject malus;
    // public GameObject item;
    public Transform origin;
    public bool BMOGenerated = false;
    public GameObject cube;
    public int cubeSize = 2;

    public void setAleaBMO (GameObject[] labyList) {
        int goodNumber = Random.Range (1, luckGeneration);

        if (goodNumber == 1) {
            generateBMO (bonus);
            setEqualBMO (goodNumber, labyList);
        }
        if (goodNumber == 2) {
            // generateBMO(malus);
        }
        if (goodNumber == 3) {
            // generateBMO(item);
        }

    }

    public void generateBMO (GameObject BMO) {
        GameObject instance;
        instance = Instantiate (BMO, new Vector3 (Mathf.RoundToInt (origin.position.x),
                Mathf.RoundToInt (origin.position.y),
                Mathf.RoundToInt (origin.position.z) - 3),
            origin.rotation);
        BMOGenerated = true;
    }

    public void setEqualBMO (int goodNumber, GameObject[] labyList) {
        if (goodNumber == 1 || goodNumber == 2 || goodNumber == 3) {
            foreach (GameObject labyCube in labyList) {
                if ((labyCube.GetComponent<BMOGeneration> ().BMOGenerated == false) && ((origin.position.x - cubeSize + 0.1) < -(labyCube.transform.position.x)) &&
                    ((origin.position.x + cubeSize - 0.1) > -(labyCube.transform.position.x)) &&
                    (origin.position.y - cubeSize + 0.1 < -(labyCube.transform.position.y)) &&
                    (origin.position.y + cubeSize - 0.1 > -(labyCube.transform.position.y))) {
                    labyCube.GetComponent<BMOGeneration> ().generateBMO (bonus);
                }
            }
        }
    }
}