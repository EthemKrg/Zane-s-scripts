using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestLocations : MonoBehaviour
{
    //this code goes on a game object that represent the
    // tast to be performed by the player at the location
    // of the object. This code can contain any logic as long as when
    // the tas is complete it injects the three statues
    //back into the quest system ( as per in the OnCollisionEnter)
    // currently here.


    public QuestManager qManager;
    public QuestEvent qEvent;
    public QuestButton qButton;


    public GameObject[] colliders;
    private int temp;

    // KILL GÖREVİ ELEMANLARI
    public BoolValue[] hedef_kill;
    private bool kill_bool;

    private int kill_temp;
    private int array_temp;

   // public bool birincidusman;
  //  public bool ikincidusman;


    private bool kill_active = false;



    private void Update()
    {

        temp = (int)(QuestManager.order - 1);

        if (kill_active)
        {
            array_temp = kill_temp - 1;

            kill_bool = hedef_kill[array_temp].RuntimeValue;

            kill_mission();


        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "Player") return;


        temp = (int)(QuestManager.order - 1);



        if (this.gameObject.tag == "collider")
        {

            dewuamzzz();
            return;
        }
        else if  (this.gameObject.tag == "collider"|| this.gameObject.tag == "collider3"  || this.gameObject.tag == "collider4"
              || this.gameObject.tag == "collider7"|| this.gameObject.tag == "collider8"  || this.gameObject.tag == "collider10"
            || this.gameObject.tag == "collider13" || this.gameObject.tag == "collider14" || this.gameObject.tag == "collider16"
            || this.gameObject.tag == "collider18" || this.gameObject.tag == "collider21" || this.gameObject.tag == "collider22"
            || this.gameObject.tag == "collider23" || this.gameObject.tag == "collider24" || this.gameObject.tag == "collider25" 
            || this.gameObject.tag == "collider26" || this.gameObject.tag == "collider27" || this.gameObject.tag == "collider28"
            || this.gameObject.tag == "collider30" || this.gameObject.tag == "collider31" || this.gameObject.tag == "collider32"
            || this.gameObject.tag == "collider36" || this.gameObject.tag == "collider37" || this.gameObject.tag == "collider38"
            || this.gameObject.tag == "collider41" || this.gameObject.tag == "collider51" || this.gameObject.tag == "collider52"
            || this.gameObject.tag == "collider54" || this.gameObject.tag == "collider55" || this.gameObject.tag == "collider56"
            || this.gameObject.tag == "collider57" || this.gameObject.tag == "collider59" || this.gameObject.tag == "collider60"
            || this.gameObject.tag == "collider61" || this.gameObject.tag == "collider63" || this.gameObject.tag == "collider64"
            || this.gameObject.tag == "collider65" || this.gameObject.tag == "collider66" || this.gameObject.tag == "collider67"
            || this.gameObject.tag == "collider68" || this.gameObject.tag == "collider69" || this.gameObject.tag == "collider70" 
            || this.gameObject.tag == "collider71" || this.gameObject.tag == "collider72" || this.gameObject.tag == "collider74"
            || this.gameObject.tag == "collider85" || this.gameObject.tag == "collider86" || this.gameObject.tag == "collider87"
            || this.gameObject.tag == "collider88" || this.gameObject.tag == "collider89" || this.gameObject.tag == "collider92"
            || this.gameObject.tag == "collider94" || this.gameObject.tag == "collider96" || this.gameObject.tag == "collider97"
            || this.gameObject.tag == "collider98" || this.gameObject.tag == "collider100"|| this.gameObject.tag == "collider102" || this.gameObject.tag == "collider58"

            ) { return; }

        else if (this.gameObject.tag == "collider2")
        {
            kill_active = true;
            kill_temp = 1;
            return;
        }
        else if (this.gameObject.tag == "collider11")
        {
            kill_active = true;
            kill_temp = 2;
            return;
        }
        else if (this.gameObject.tag == "collider15")
        {
            kill_active = true;
            kill_temp = 3;
            return;
        }
        else if (this.gameObject.tag == "collider20")
        {
            kill_active = true;
            kill_temp = 4;
            return;
        }
        else if (this.gameObject.tag == "collider29")
        {
            kill_active = true;
            kill_temp = 5;
            return;
        }
        else if (this.gameObject.tag == "collider42")
        {
            kill_active = true;
            kill_temp = 6;
            return;
        }
        else if (this.gameObject.tag == "collider43")
        {
            kill_active = true;
            kill_temp = 7;
            return;
        }
        else if (this.gameObject.tag == "collider44")
        {
            kill_active = true;
            kill_temp = 8;
            return;
        }
        else if (this.gameObject.tag == "collider45")
        {
            kill_active = true;
            kill_temp = 9;
            return;
        }
        else if (this.gameObject.tag == "collider46")
        {
            kill_active = true;
            kill_temp = 10;
            return;
        }
        else if (this.gameObject.tag == "collider47")
        {
            kill_active = true;
            kill_temp = 11;
            return;
        }
        else if (this.gameObject.tag == "collider48")
        {
            kill_active = true;
            kill_temp = 12;
            return;
        }
        else if (this.gameObject.tag == "collider49")
        {
            kill_active = true;
            kill_temp = 13;
            return;
        }
        else if (this.gameObject.tag == "collider50")
        {
            kill_active = true;
            kill_temp = 14;
            return;
        }
        else if (this.gameObject.tag == "collider53")
        {
            kill_active = true;
            kill_temp = 15;
            return;
        }
        else if (this.gameObject.tag == "collider62")
        {
            kill_active = true;
            kill_temp = 16;
            return;
        }
        else if (this.gameObject.tag == "collider65")
        {
            kill_active = true;
            kill_temp = 33;
            return;
        }
        else if (this.gameObject.tag == "collider66")
        {
            kill_active = true;
            kill_temp = 34;
            return;
        }
        else if (this.gameObject.tag == "collider67")
        {
            kill_active = true;
            kill_temp = 35;
            return;
        }
        else if (this.gameObject.tag == "collider73")
        {
            kill_active = true;
            kill_temp = 36;
            return;
        }
        else if (this.gameObject.tag == "collider75")
        {
            kill_active = true;
            kill_temp = 17;
            return;
        }
        else if (this.gameObject.tag == "collider76")
        {
            kill_active = true;
            kill_temp = 18;
            return;
        }
        else if (this.gameObject.tag == "collider77")
        {
            kill_active = true;
            kill_temp = 19;
            return;
        }
        else if (this.gameObject.tag == "collider78")
        {
            kill_active = true;
            kill_temp = 20;
            return;
        }
        else if (this.gameObject.tag == "collider79")
        {
            kill_active = true;
            kill_temp = 21;
            return;
        }
        else if (this.gameObject.tag == "collider80")
        {
            kill_active = true;
            kill_temp = 22;
            return;
        }
        else if (this.gameObject.tag == "collider81")
        {
            kill_active = true;
            kill_temp = 23;
            return;
        }
        else if (this.gameObject.tag == "collider82")
        {
            kill_active = true;
            kill_temp = 24;
            return;
        }
        else if (this.gameObject.tag == "collider83")
        {
            kill_active = true;
            kill_temp = 25;
            return;
        }
        else if (this.gameObject.tag == "collider84")
        {
            kill_active = true;
            kill_temp = 26;
            return;
        }
        else if (this.gameObject.tag == "collider90")
        {
            kill_active = true;
            kill_temp = 27;
            return;
        }
        else if (this.gameObject.tag == "collider91")
        {
            kill_active = true;
            kill_temp = 28;
            return;
        }
        else if (this.gameObject.tag == "collider93")
        {
            kill_active = true;
            kill_temp = 29;
            return;
        }
        else if (this.gameObject.tag == "collider95")
        {
            kill_active = true;
            kill_temp = 30;
            return;
        }
        else if (this.gameObject.tag == "collider99")
        {
            kill_active = true;
            kill_temp = 31;
            return;
        }
        else if (this.gameObject.tag == "collider101")
        {
            kill_active = true;
            kill_temp = 32;
            return;
        }



        dewuamzzz();


    }

    public void Setup(QuestManager qm, QuestEvent qe, QuestButton qb)
    {
        qManager = qm;
        qEvent = qe;
        qButton = qb;
        // stup link between event and button
        qe.button = qButton;
    }


    public void dewuam()
    {
        FindObjectOfType<ViewportScroller>().Scroller();

        qEvent.UpdateQuestEvent(QuestEvent.EventStatus.DONE);
        qButton.UpdateButton(QuestEvent.EventStatus.DONE);
        qManager.UpdateQuestsOnCompletion(qEvent);
        this.gameObject.SetActive(false);

    }

   
    public void dewuamzzz()
    {
        qEvent.UpdateQuestEvent(QuestEvent.EventStatus.DONE);
        qButton.UpdateButton(QuestEvent.EventStatus.DONE);
        qManager.UpdateQuestsOnCompletion(qEvent);
        FindObjectOfType<ViewportScroller>().Scroller();
        this.gameObject.SetActive(false);
        temp = (int)(QuestManager.order - 1);
        colliders[temp].gameObject.SetActive(true);



    }

    private void kill_mission()
    {


        if (kill_temp == 1 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;





        }
        else if (kill_temp == 2 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 3 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 4 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 5 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 6 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 7 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 8 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 9 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 10 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 11 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 12 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 13 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 14 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 15 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 16 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 17 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 18 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 19 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 20 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;



        }
        else if (kill_temp == 21 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 22 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 23 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 24 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 25 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 26 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 27 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 28 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 29 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 30 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 31 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 32 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 33 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 34 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 35 && kill_bool == true)
        {
            kill_active = false;

            dewuam();
            colliders[temp].gameObject.SetActive(true);

            hedef_kill[array_temp].RuntimeValue = kill_bool;
            kill_temp = 0;

        }
        else if (kill_temp == 36 && kill_bool == true)
        {
                kill_active = false;

                dewuam();
                colliders[temp].gameObject.SetActive(true);

                hedef_kill[array_temp].RuntimeValue = kill_bool;
                kill_temp = 0;

        }


        }



}
