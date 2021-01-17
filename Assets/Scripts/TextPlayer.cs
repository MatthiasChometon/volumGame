using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPlayer : MonoBehaviour {
    public Warrior battleStat;
    public Text life;
    public Text attack;

    void Update () {
        this.life.text = battleStat.lifePoints.ToString ();
        this.attack.text = battleStat.attackPoints.ToString ();
    }
}