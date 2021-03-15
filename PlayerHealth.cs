using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : GenericHealth
{
    [SerializeField] private Signal healthSignal;

    public FloatValue Armor;
    private float armor;


    public FloatValue hearthContainer;
    public FloatValue playerHealth;




    private void LateUpdate()
    {
        armor = Armor.RuntimeValue;
        currentHealth = maxHealth.RuntimeValue;
    }


    public override void Damage(float amountToDamage)
    {
        amountToDamage = amountToDamage - armor;
        base.Damage(amountToDamage);
        maxHealth.RuntimeValue = currentHealth;
	SoundManager.PlaySound("hit");
        healthSignal.Raise();
    }
    public override void Heal(float amountToHeal)
    {
        base.Heal(amountToHeal);
        maxHealth.RuntimeValue = currentHealth;
        healthSignal.Raise();


    }

}
