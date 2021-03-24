using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEffect : ObjectItem
{
    public Warrior warrior;
    public int Healing = 5;
    public void healing()
    {
        if (player.phase == "my turn" && player.lifePointsOrigin != player.lifePoints)
        {
            if(player.lifePointsOrigin < (player.lifePoints + Healing)) {
                player.lifePoints += player.lifePointsOrigin - player.lifePoints;
            } else {
                player.lifePoints += Healing;
            }
            player.phase = "end phase";
            deleteOneFromInventory("Heal");
        }
    }
}
