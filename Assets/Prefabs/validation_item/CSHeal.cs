using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSHeal : MonoBehaviour
{
    [SerializeField] GameObject confirmPanel;


    public void onUserClickYesNo(int choice){
        confirmPanel.SetActive (false);

    }

    public void onUserClickStart(){
        confirmPanel.SetActive (true);

    }
}
