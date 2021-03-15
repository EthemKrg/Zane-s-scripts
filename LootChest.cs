using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class LootChest : Interactable {


    public GameObject coinClue;

    public int paraMiktarı;
  //  [Header("Contents")]
   // public item contents;
    public Inventory playerInventory;
    public bool isOpen;
    public BoolValue storedOpen;
    

   // [Header("Signals And Dialog")]
   
 //   public Signal raiseItem;
  //  public GameObject dialogBox;
   // public Text dialogText;

    [Header("Animation")]
    private Animator anim;


    // Use this for initialization
    void Start() {

        anim = GetComponent<Animator>();
        isOpen = storedOpen.RuntimeValue;
        if (isOpen)
        {
            anim.SetBool("opened", true);
        }

    }

    // Update is called once per frame
    void Update() {
        if (CrossPlatformInputManager.GetButtonDown("Weapon Attack") && playerInRange)
        {
            if (!isOpen)
            {
                //sandığı aç
                OpenChest();
            }
            else
            {
                //sandık zaten açık
                ChestAlreadyOpen();
            }
        }

    }

    public void OpenChest()
    {
        //Dialog window on
        //dialogBox.SetActive(true);
        //dialog text = contents text
        //  dialogText.text = contents.itemDescription;
        // add contents to the inventory
        SoundManager.PlaySound("coin");
        SoundManager.PlaySound("chest");

        playerInventory.coins += paraMiktarı;
        StartCoroutine(coinContextCo());  
        //playerInventory.currentItem = contents;
        //Raise the signal to the player to animate
        // raiseItem.Raise();

        //raise the context clue
        context.Raise();
        //set the chest to opened
        isOpen = true;
        anim.SetBool("opened", true);
        storedOpen.RuntimeValue = isOpen;
    }

    public void ChestAlreadyOpen()
    {



            //dialoğu kapa
         //   dialogBox.SetActive(false);
        
            //raise the signal player to stop animating his weird anim
         //   raiseItem.Raise();
        playerInRange = false;

           
        


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = false;

        }
    }



    private IEnumerator coinContextCo()
    {
        coinClue.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        coinClue.SetActive(false);
    }


}
