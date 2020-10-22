using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public float turnNumber;

    public void nextTurn()
    {
        turnNumber++;
    }

    void Start()
    {
        turnNumber = 0;
    }

    void Update()
    {
        
    }
}
