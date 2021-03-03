using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : ObjectItem
{
    public Warrior opponent;
    public int Damages = 2;

    public void ReceivedDamages(){
        opponent.lifePoints -= 2;
    }
}
