using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour {
    public Vector3 translationH;
    public Vector3 translationV;
    public GameObject boss;
    private bool bossKnowWhereToGo = false;
    private int maxPath = 5;
    private List<Vector3> path = new List<Vector3> ();
    private int aleaPath;
    private int pathPosition = 0;
    private bool positionBeforeAnimationActivated = false;
    private Vector3 positionBeforeAnimation;
    public Warrior warrior;
    private int positionInterval = 1;

    void Start () {
        translationH.y = 80f;
        translationV.x = 80f;
    }

    void Update () {
        if (warrior.phase == "move") {
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
                    if (( boss.transform.position.x > positionBeforeAnimation.x + path[pathPosition].x - positionInterval) && (boss.transform.position.x < positionBeforeAnimation.x + path[pathPosition].x + positionInterval) &&
                        ( boss.transform.position.y > positionBeforeAnimation.y + path[pathPosition].y - positionInterval) && (boss.transform.position.y < positionBeforeAnimation.y + path[pathPosition].y + positionInterval) &&
                        ( boss.transform.position.z > positionBeforeAnimation.z + path[pathPosition].z - positionInterval) && (boss.transform.position.z < positionBeforeAnimation.z + path[pathPosition].z + positionInterval))
                    {
                        positionBeforeAnimationActivated = false;
                        pathPosition++;
                        warrior.phase = "end phase";
                    } else {
                        transform.Translate (path[pathPosition] * Time.deltaTime);
                    }

                }

                if (path.Count == pathPosition) {
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