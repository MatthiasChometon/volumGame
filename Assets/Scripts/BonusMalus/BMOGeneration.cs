using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMOGeneration : MonoBehaviour {
    public int luckGeneration = 2;
    public GameObject bonus;
    // public GameObject malus;
    // public GameObject item;
    public Transform origin;
    public bool BMOGenerated = false;
    public GameObject cube;
    public LabyList labyList;

    public void setAleaBMO () {
        int goodNumber = Random.Range (1, luckGeneration);

        if (goodNumber == 1) {
            generateBMO (bonus);
            setEqualBMO (goodNumber);   
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

    public void setEqualBMO (int goodNumber) {
        if (goodNumber == 1 || goodNumber == 2 || goodNumber == 3) {
            foreach (BMOGeneration labyCube in labyList.labylist) {
                if ((labyCube.BMOGenerated == false) && ((origin.position.x - labyList.cubeSize + 0.1) < -(labyCube.cube.transform.position.x)) &&
                    ((origin.position.x + labyList.cubeSize - 0.1) > -(labyCube.cube.transform.position.x)) &&
                    (origin.position.y - labyList.cubeSize + 0.1 < -(labyCube.cube.transform.position.y)) &&
                    (origin.position.y + labyList.cubeSize - 0.1 > -(labyCube.cube.transform.position.y))) {
                    labyCube.generateBMO (bonus);
                }
            }
        }
    }
}