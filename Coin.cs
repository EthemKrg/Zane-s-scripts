using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PowerUp {

    public Inventory playerInventory;



    void Start()
    {
        powerupSignal.Raise();

    }

    private void LateUpdate()
    {
        powerupSignal.Raise();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {

            SoundManager.PlaySound("coin");
            playerInventory.coins += 1;
            powerupSignal.Raise();
            Destroy(this.gameObject);
        }
    }



}
