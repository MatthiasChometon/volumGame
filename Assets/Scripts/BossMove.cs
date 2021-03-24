using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public Vector3 translationH;
    public Vector3 translationV;
    public GameObject boss;
    private bool bossKnowWhereToGo = false;
    private int maxPath = 3;
    private List<Vector3> path = new List<Vector3>();
    private int aleaPath;
    private int pathPosition = 0;
    private bool positionBeforeAnimationActivated = false;
    private Vector3 positionBeforeAnimation;
    public Warrior warrior;
    private int positionInterval = 1;
    private int orientation = 0;

    void Start()
    {
        translationH.y = 54f;
        translationV.x = 54f;
    }

    void Update()
    {
        if (warrior.phase == "move")
        {
            if (!bossKnowWhereToGo)
            {
                pathPosition = 0;
                path = SearchPath();
            }
            if (bossKnowWhereToGo)
            {
                if (path.Count > pathPosition)
                {
                    if (positionBeforeAnimationActivated == false)
                    {
                        positionBeforeAnimation = boss.transform.position;
                        positionBeforeAnimationActivated = true;
                        int orientationWanted = 0;
                        if (path[pathPosition].x == 0)
                        {
                            if (path[pathPosition].y > 0)
                            {
                                orientationWanted = 360;
                            }
                            else
                            {
                                orientationWanted = 180;
                            }
                        }

                        if (path[pathPosition].y == 0)
                        {
                            if (path[pathPosition].x < 0)
                            {
                                orientationWanted = 90;
                            }
                            else
                            {
                                orientationWanted = 270;
                            }
                        }

                        transform.Rotate(0f, 0f, orientationWanted - orientation);
                        orientation = orientationWanted;
                    }
                    if ((boss.transform.position.x > positionBeforeAnimation.x + path[pathPosition].x - positionInterval) && (boss.transform.position.x < positionBeforeAnimation.x + path[pathPosition].x + positionInterval) &&
                        (boss.transform.position.y > positionBeforeAnimation.y + path[pathPosition].y - positionInterval) && (boss.transform.position.y < positionBeforeAnimation.y + path[pathPosition].y + positionInterval) &&
                        (boss.transform.position.z > positionBeforeAnimation.z + path[pathPosition].z - positionInterval) && (boss.transform.position.z < positionBeforeAnimation.z + path[pathPosition].z + positionInterval))
                    {
                        positionBeforeAnimationActivated = false;
                        pathPosition++;
                        warrior.phase = "end phase";
                    }
                    else
                    {
                        transform.Translate(new Vector3(0, 54f, 0) * Time.deltaTime);
                    }

                }

                if (path.Count == pathPosition)
                {
                    bossKnowWhereToGo = false;
                }
            }
        }
    }

    private List<Vector3> SearchPath()
    {
        aleaPath = Random.Range(1, maxPath);
        bossKnowWhereToGo = true;
        var way = new List<Vector3>();

        switch (aleaPath)
        {
            case 1:
                way = new List<Vector3>() { -translationH, -translationV, -translationV, -translationV, translationH, translationH, translationH, translationV, translationV, translationV, -translationH, -translationH };
                break;
            case 2:
                way = new List<Vector3>() { -translationH, translationV, translationV, -translationH, -translationH, -translationV, -translationH, -translationV, -translationV, translationH, -translationV, translationH, translationH, translationV, translationV, translationH };
                break;
            case 3:
                way = new List<Vector3>() { translationH, translationH, translationH, translationV, translationV, -translationH, translationV, -translationH, translationV, -translationH, -translationH, -translationV, -translationV, -translationV, -translationV, translationH };
                break;
        }
        return way;
    }
}