using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicReaction : MonoBehaviour
{
    public FloatValue playerMagic;
    public Signal magicSignal;

   public void use(int amountToIncrease)
    {
        playerMagic.RuntimeValue += amountToIncrease;
        magicSignal.Raise();
    }
}
