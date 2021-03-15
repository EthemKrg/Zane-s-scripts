using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeonRoom : MonoBehaviour
{
    public BoolValue boss;
    public GameObject kapi;




    private void Update()
    {
        if (boss.RuntimeValue == true) 
            kapiKaldirici();
        
    }



     void kapiKaldirici()
    {
        kapi.gameObject.SetActive(false);
    }

}
