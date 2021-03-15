using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pot : MonoBehaviour {

    private Animator anim;
    public LootTable thisLoot;

    public bool broken;
    public BoolValue pot_state;

    public bool kristalMI = false;


    void Start () {
        
        broken = pot_state.RuntimeValue;

        if (broken)
        {
            this.gameObject.SetActive(false);

        }
         anim = GetComponent<Animator>();

        
    }
	

        public void Smash()
    {
        if (!broken)
        {
            if(kristalMI == true)
            {
                SoundManager.PlaySound("kristal");

            }
            else
            {
                SoundManager.PlaySound("breakSound");

            }
            anim.SetBool("smash", true);
            StartCoroutine(breakCo());
            broken = true;
            pot_state.RuntimeValue = broken;

        }







    }

    IEnumerator breakCo()
    {
        
        yield return new WaitForSeconds(.3f);
        this.gameObject.SetActive(false);

        if (thisLoot != null)
        {
            PowerUp current = thisLoot.LootsPowerUp();
            Instantiate(current.gameObject, transform.position, Quaternion.identity);
        }
    }
}
