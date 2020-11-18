using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMOgenerator : MonoBehaviour {
    private int luckGeneration = 2;
    public GameObject bonus;
    // public GameObject malus;
    // public GameObject item;
    public Transform origin;

    void Start () {
        int goodNumber = Random.Range (1, luckGeneration);

        if (goodNumber == 1) {
            Debug.Log("instantiate");
            GameObject instance;
            instance = Instantiate(bonus, new Vector3(Mathf.RoundToInt (origin.position.x),
            Mathf.RoundToInt (origin.position.y), 
            Mathf.RoundToInt (origin.position.z) + 3), 
            origin.rotation);
        }
        if (goodNumber == 2) {

        }
        if (goodNumber == 3) {

        }

    }

}