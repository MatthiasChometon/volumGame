using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseStat : Stat
{

    public override void chooseBonusOrMalus(Collision2D collision)
    {
        collision.gameObject.GetComponent<Warrior>().attackPoints += 2;
    }
}