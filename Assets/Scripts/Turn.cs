using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Turn : MonoBehaviour {
    public int turnNumber;
    public GameObject panelTurnInfo;
    public Text textTurnInfo;
    public GameObject panelEndGameInfo;
    public Text textEndGameInfo;
    public List<Warrior> warriors;
    public ChangeScene changeScene;

    void Start () {
        turnNumber = 0;
        StartCoroutine (displayTurnInfo (warriors[turnNumber].warriorName + " turn"));
    }

    void Update () {

        if (warriors[turnNumber].phase == "opponent turn" && !panelTurnInfo.activeSelf) {
            warriors[turnNumber].chooseStrategy ();
        }

        if (warriors[turnNumber].phase == "end phase") {
            warriors[turnNumber].phase = "opponent turn";
            nextTurn ();
            StartCoroutine (displayTurnInfo (warriors[turnNumber].warriorName + " turn"));
        }

        if (warriors[turnNumber].phase == "end game") {
            string winners = "";
            foreach (Warrior warrior in warriors) {
                if (warrior.lifePoints > 0) {
                    winners += warrior.warriorName + " ";
                }
            }
            Scene scene = SceneManager.GetActiveScene ();
            warriors[turnNumber].phase = "wait";
            StartCoroutine (endGame (winners + " win !", 2));
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

    public IEnumerator endGame (string info, int timeToWait) {
        panelTurnInfo.SetActive (true);
        textTurnInfo.text = info;
        yield return new WaitForSeconds (timeToWait);
        panelTurnInfo.SetActive (false);
        panelEndGameInfo.SetActive (true);
    }
}