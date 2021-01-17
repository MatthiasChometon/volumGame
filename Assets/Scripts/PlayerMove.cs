using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public Warrior warrior;
    public Getinfo info;
    private Vector3 pos;
    public string player;
    float xpx;
    float ypy;
    private bool diagonal = false;

        void Start()
        {
        }

    void Update () {
        if (warrior && warrior.phase == "my turn") {
                info = GameObject.Find("Main Camera").GetComponent<Getinfo>();
                if (info.isground==true){
                    float xp = GameObject.Find(warrior.name).transform.position.x;
                    float yp = GameObject.Find(warrior.name).transform.position.y;
                    Debug.Log(info.x + " " + info.y + " / " + xp + " " + yp );
                    xpx = xp - info.x;
                    ypy = yp - info.y;

                    float z = -2f;
                    if(xpx > -60 && xpx < 60){
                        if(ypy > -60 && ypy < 60){
                            if(((ypy > -60 && ypy < -50)||(ypy >50 && ypy <60))&&((xpx > -60 && xpx < -50)||(xpx >50 && xpx <60))){
                                diagonal = true;
                            }
                            if(diagonal==false){
                                Debug.Log("info.x: " + xpx+ " info y: " + ypy);
                                transform.position = new Vector3 (info.x,info.y,z);
                                warrior.phase = "end phase";
                                info.isground=false;
                            }
                            diagonal = false;
                        }
                    }
                }
        }
    }
}
