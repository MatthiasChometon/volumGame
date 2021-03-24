using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statBar : MonoBehaviour {
    public Warrior player;
    public Slider sliderHealth;
    public Slider sliderDefense;
    public Text attack;

    void Start () {
        getStat ();
    }

    void Update () {
        DisplayStat ();
    }

    private void DisplayStat () {
        sliderHealth.value = player.lifePoints;
        sliderDefense.value = player.defensePoints;
        attack.text = player.attackPoints.ToString();
    }

    private void getStat () {
        sliderHealth.maxValue = player.lifePoints;
        sliderDefense.maxValue = 12;
    }

}