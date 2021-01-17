using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statBar : MonoBehaviour {
    public Warrior player;
    public Slider sliderHealth;
    public Slider sliderDefense;

    void Start () {
        getStat ();
    }

    void Update () {
        DisplayStat ();
    }

    private void DisplayStat () {
        sliderHealth.value = player.lifePoints;
        sliderDefense.value = player.defensePoints;
    }

    private void getStat () {
        sliderHealth.maxValue = player.lifePoints;
        sliderDefense.maxValue = player.defensePoints;
    }

}