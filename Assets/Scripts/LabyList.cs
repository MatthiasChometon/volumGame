using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyList : MonoBehaviour {
    private GameObject[] labyList;
    public GameObject bonus;
    public int cubeSize = 2;

    void Start () {
        labyList = GameObject.FindGameObjectsWithTag ("case");
        setBMO ();
    }

    public void setBMO () {
        foreach (GameObject labyCube in labyList) {
            labyCube.GetComponent<BMOGeneration> ().setAleaBMO (this.labyList);
        }
    }
}