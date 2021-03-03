using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEffect : ObjectItem
{

    public Warrior warrior;
    public int Healing = 5;

    public void healing(){
        warrior.lifePoints += Healing;
    }
}
