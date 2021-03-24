using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : ObjectItem
{
    public Warrior opponent;
    public int Damages = 2;

    public void ReceivedDamages()
    {
        if (player.phase == "my turn")
        {
            opponent.lifePoints -= 2;
            deleteOneFromInventory("Snake");
        }
    }
}
