﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : PowerUp {

    public FloatValue playersHealth;
    public FloatValue heartContainers;
    public float amountToIncrease;



    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
           
            playersHealth.RuntimeValue += amountToIncrease;

            if(playersHealth.initialValue > heartContainers.RuntimeValue * 2f)
            {
                playersHealth.initialValue = heartContainers.RuntimeValue * 2f;
            }

            powerupSignal.Raise();
            Destroy(this.gameObject);
        }
    }

}
