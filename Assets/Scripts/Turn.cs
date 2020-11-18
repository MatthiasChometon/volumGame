using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour {
    public int turnNumber;
    public GameObject panelTurnInfo;
    public Text textTurnInfo;
    public List<Warrior> warriors;

    void Start () {
        turnNumber = 0;
        StartCoroutine (displayTurnInfo (warriors[turnNumber].warriorName + " turn"));
    }

    void Update () {

        if(warriors[turnNumber].phase == "dead") {

        }

        if (warriors[turnNumber].phase == "opponent turn" && !panelTurnInfo.activeSelf) {
            warriors[turnNumber].chooseStrategy ();
        }

        if (warriors[turnNumber].phase == "end phase") {
            warriors[turnNumber].phase = "opponent turn";
            nextTurn ();
            StartCoroutine (displayTurnInfo (warriors[turnNumber].warriorName + " turn"));
        }

    }

    public void nextTurn () {
        if (turnNumber < (warriors.Count - 1)) {
            turnNumber++;
        } else {
            turnNumber = 0;
        }
    }

    public IEnumerator displayTurnInfo (string info) {
        panelTurnInfo.SetActive (true);
        textTurnInfo.text = info;
        yield return new WaitForSeconds (1);
        panelTurnInfo.SetActive (false);
    }
}