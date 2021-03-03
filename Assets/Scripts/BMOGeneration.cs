using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMOGeneration : MonoBehaviour {
    public int luckGeneration = 3;
    public GameObject bonus;
    public GameObject malus;
    public List<GameObject> items;
    public Transform origin;
    public bool BMOGenerated = false;
    public GameObject cube;
    public int cubeSize = 2;
    public Vector3 middle = new Vector3 (476, 261, 0);

    public void setAleaBMO (GameObject[] labyList) {
        int goodNumber = Random.Range (1, luckGeneration);

        for (int i = 0; i < items.Count; i++) {
            var item = items[i];

            if (goodNumber == (i + 3)) {
                generateBMO (item);
                setEqualBMO (item, labyList);
            }
        }

        if (goodNumber == 1) {
            generateBMO (bonus);
            setEqualBMO (bonus, labyList);
        }

        if (goodNumber == 2) {
            generateBMO (malus);
            setEqualBMO (malus, labyList);
        }

    }

    public void generateBMO (GameObject BMO) {
        if (BMOGenerated == false) {
            GameObject instance;
            instance = Instantiate (BMO, new Vector3 (Mathf.RoundToInt (origin.position.x),
                    Mathf.RoundToInt (origin.position.y),
                    Mathf.RoundToInt (origin.position.z) - 3),
                origin.rotation);
        }

        BMOGenerated = true;
    }

    public void setEqualBMO (GameObject bmo, GameObject[] labyList) {
        foreach (GameObject labyCube in labyList) {
            if (labyCube.GetComponent<BMOGeneration> () != null && (labyCube.GetComponent<BMOGeneration> ().BMOGenerated == false) && ((origin.position.x - cubeSize + 1 - middle.x) < -(labyCube.transform.position.x - middle.x)) &&
                ((origin.position.x + cubeSize - 1 - middle.x) > -(labyCube.transform.position.x - middle.x)) &&
                (origin.position.y - cubeSize + 1 - middle.y < -(labyCube.transform.position.y - middle.y)) &&
                (origin.position.y + cubeSize - 1 - middle.y > -(labyCube.transform.position.y - middle.y))) {
                labyCube.GetComponent<BMOGeneration> ().generateBMO (bmo);
            }
        }
    }
}