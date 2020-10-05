using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public characterRaza raza;


    public enum characterRaza
    {
        humano,enano,elfo
    }

    public string GetDescription()
    {
        return (characterName + "the " + raza);
    }
}
