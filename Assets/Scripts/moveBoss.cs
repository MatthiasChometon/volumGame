using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoss : MonoBehaviour {
    public Vector3 translationH;
    public Vector3 translationV;
    public Turn turn;
    public GameObject boss;
    private bool bossKnowWhereToGo = false;
    private int maxPath = 5;
    private List<Vector3> path = new List<Vector3> ();
    private int aleaPath;
    private int pathPosition = 0;
    private bool positionBeforeAnimationActivated = false;
    private Vector3 positionBeforeAnimation;

    void Start () {
        translationH.y = 2f;
        translationV.x = 2f;
    }

    void Update () {
        if (turn.turnNumber % 3 == 1) {
            if (!bossKnowWhereToGo) {
                pathPosition = 0;
                path = SearchPath ();
            }
            if (bossKnowWhereToGo) {
                if (path.Count > pathPosition) {

                    if (positionBeforeAnimationActivated == false) {
                        positionBeforeAnimation = boss.transform.position;
                        positionBeforeAnimationActivated = true;
                    }

                    if ((System.Math.Round (boss.transform.position.y, 2) == System.Math.Round (positionBeforeAnimation.y + path[pathPosition].y, 2)) && (System.Math.Round (boss.transform.position.x, 2) == System.Math.Round (positionBeforeAnimation.x + path[pathPosition].x, 2)) && (System.Math.Round (boss.transform.position.z, 2) == System.Math.Round (positionBeforeAnimation.z + path[pathPosition].z, 2))) {
                        positionBeforeAnimationActivated = false;
                        pathPosition++;
                        turn.nextTurn ();
                    } else {
                        transform.Translate (path[pathPosition] * Time.deltaTime);
                    }

                }

                if (path.Count == pathPosition) {
                    Debug.Log (bossKnowWhereToGo);
                    bossKnowWhereToGo = false;
                }
            }
        }
    }

    private List<Vector3> SearchPath () {
        aleaPath = Random.Range (1, maxPath);
        bossKnowWhereToGo = true;
        switch (aleaPath) {
            case 1:
                return new List<Vector3> () { translationH, translationV, translationV, -translationH };
            case 2:
                return new List<Vector3> () { translationH, translationV, translationV, -translationH };
            case 3:
                return new List<Vector3> () { translationH, translationV, translationV, -translationH };
            case 4:
                return new List<Vector3> () { translationH, translationV, translationV, -translationH };
        }
        return new List<Vector3> () { translationH, translationV, translationV, -translationH };
    }
}