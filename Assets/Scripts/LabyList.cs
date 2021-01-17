using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyList : MonoBehaviour {
    //private GameObject[] labyList;
    public GameObject bonus;
    public int cubeSize = 2;

    public void setBMO (GameObject[] labyList) {
        foreach (GameObject labyCube in labyList) {
            if (labyCube.GetComponent<BMOGeneration> () != null) {
                labyCube.GetComponent<BMOGeneration> ().setAleaBMO (labyList);
            }
        }
    }
}