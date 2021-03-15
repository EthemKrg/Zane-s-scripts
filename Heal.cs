using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : PowerUp
{

    public FloatValue playersHealth;
    public FloatValue heartContainers;
    public float amountToIncrease;

    public Inventory playerInventory;





    public void CanBas()
    {
        if (playerInventory.yemis > 0)
        {
            playersHealth.RuntimeValue += amountToIncrease;

            if (playersHealth.RuntimeValue > heartContainers.RuntimeValue * 2f)
            {
                playersHealth.RuntimeValue = heartContainers.RuntimeValue * 2f;
            }
            else
            {
                playerInventory.yemis -= 1;


            }

        }


        powerupSignal.Raise();




    }

}
