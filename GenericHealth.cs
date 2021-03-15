using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericHealth : MonoBehaviour
{
    public FloatValue maxHealth;
    public float currentHealth;


    public GameObject player;



    [Header("IFrame Stuff")]
    public Color flashColor;
    public Color regularcolor;
    public float flashDuration;
    public int numberOfFlashes;
    public Collider2D triggerCollider;
    public SpriteRenderer mySprite;



    // Start is called before the first frame update
    void Start()
    {
       
        currentHealth = maxHealth.RuntimeValue;
    }


    public virtual void Heal(float amountToHeal)
    {
        if (currentHealth > 0)
        {
            currentHealth += amountToHeal;

            if (currentHealth > maxHealth.RuntimeValue)
            {
                currentHealth = maxHealth.RuntimeValue;
            }

        }

    }

    public virtual void FullHeal()
    {
        currentHealth = maxHealth.RuntimeValue;
    }

    public virtual void Damage(float amountToDamage)
    {
        if (amountToDamage > 0)
        {
            currentHealth -= amountToDamage;
            if (currentHealth > 0)
            {
                StartCoroutine(FlashCo());


            }

            if (currentHealth < 0)
            {
                currentHealth = 0;
                player.gameObject.SetActive(false);
                FindObjectOfType<respawnButton>().deadPanel();
            }
        }


    }

    public virtual void InstantDeath()
    {
        currentHealth = 0;
    }






    private IEnumerator FlashCo()
    {
        
        int temp = 0;
        triggerCollider.enabled = false;
        while (temp < numberOfFlashes)
        {
            
            mySprite.color = flashColor;
            yield return new WaitForSeconds(flashDuration);
            mySprite.color = regularcolor;
            yield return new WaitForSeconds(flashDuration);
            temp++;
           
        }
        triggerCollider.enabled = true;

    }

   









}
