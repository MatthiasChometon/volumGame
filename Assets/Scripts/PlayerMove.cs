using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    private Vector3 translationH;
    private Vector3 translationV;
    public Warrior warrior;
    private bool deplacement=false;
    public Getinfo info;
    private Vector3 pos;
    private int count = 1;
    public string player;
    float xpx;
    float ypy;
    float xpr;
    float ypr;
    private bool diagonal = false;

    void Start () {
        translationH.y = 54f;
        translationV.x = 54f;
    }

    void Update () {
        if (warrior && warrior.phase == "my turn") {
            if (Input.GetMouseButtonDown(0)){
                info = GameObject.Find("Main Camera").GetComponent<Getinfo>();
                if (info.isground==true){
                    float xp = GameObject.Find(warrior.name).transform.position.x;
                    float yp = GameObject.Find(warrior.name).transform.position.y;
                    xpx = xp - info.x;
                    ypy = yp - info.y;

                    float z = -2f;
                    if(xpx > -60 && xpx < 60){
                        if(ypy > -60 && ypy < 60){
                            if(((ypy > -60 && ypy < -50)||(ypy >50 && ypy <60))&&((xpx > -60 && xpx < -50)||(xpx >50 && xpx <60))){
                                diagonal = true;
                            }
                            if(diagonal==false){
                                transform.position = new Vector3 (info.x,info.y,z);
                                warrior.phase = "end phase";
                                count++;
                            }
                            diagonal = false;
                        }
                    }
                }
            }
        }
    }
}
