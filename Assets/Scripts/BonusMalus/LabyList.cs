using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyList : MonoBehaviour {
    public List<BMOGeneration> labylist;
    public int cubeSize = 2;

    void Start () {
        setBMO();
    }

    public void setBMO () {
        foreach (BMOGeneration labyCube in labylist) {
            labyCube.setAleaBMO ();
        }
    }
}