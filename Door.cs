using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum DoorType
{
    key,
    enemy,
    button
}
public class Door : Interactable {

    [Header("Door variables")]
    public DoorType thisDoorType;
    public bool open = false;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;

    private void Update()
    {
        if (Input.GetButtonDown("attack"))
        {
            if (playerInRange && thisDoorType == DoorType.key)
            {
                //playerın anahtarı var mı
                if (playerInventory.numberOfKeys > 0)
                    //anahtarı sil
                    playerInventory.numberOfKeys--;
                //eğer varsa open metodunu çağır
                Open();
            }
        }


    }
    public void Open()
    {
        // kapının spritını kapat
        doorSprite.enabled = false;

        //set open to true
        open = true;
        //kapının colliderını kapat
        physicsCollider.enabled = false;

    }
    public void Close()
    {
        // kapının spritını kapat
        doorSprite.enabled = true;

        //set open to true
        open = false;
        //kapının colliderını kapat
        physicsCollider.enabled = true;
    }

}
