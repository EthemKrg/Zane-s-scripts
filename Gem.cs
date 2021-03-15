using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : PowerUp {

    public Inventory playerInventory;

    void Start()
    {
        powerupSignal.Raise();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SoundManager.PlaySound("coin");
            playerInventory.coins += 10;
            powerupSignal.Raise();
            Destroy(this.gameObject);
        }
    }


}
