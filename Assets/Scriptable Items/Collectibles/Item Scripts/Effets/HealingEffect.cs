using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEffect : ObjectItem
{

    public Warrior warrior;
    public int Healing = 5;

    public void healing(){
        if (player.phase == "my turn")
        {
            warrior.lifePoints += Healing;
            deleteOneFromInventory("Heal");
        }
    }
}
