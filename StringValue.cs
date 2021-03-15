using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class StringValue : ScriptableObject
{

    public string initialValue;

    public string RuntimeValue;

    /*public static implicit operator StringValue(string v)
    {
        throw new NotImplementedException();
    }*/
}
