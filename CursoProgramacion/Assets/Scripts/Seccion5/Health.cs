using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    private int initialHealth;
    public bool invunerability,hasShield;
    public int shield=10;
    private Character chara;



    private void Awake()
    {
        chara = GetComponent<Character>();
    }

    void Start()
    {
        Debug.Log(chara.GetDescription());
        Debug.Log(shield);

        switch (chara.raza)
        {
            case Character.characterRaza.humano:
                health = 100;
                initialHealth = health;
                SetShield(true);
                TakeDamage(25);
                Debug.Log(GetHealthRatio() + " % antes de la cura");
                RecuperarSalud();
                Debug.Log(GetHealthRatio() + " % Despues de la cura");

                break;

            case Character.characterRaza.enano:
                health = 150;
                initialHealth = health;
                MultiAttack(4, 10);
                break;

            case Character.characterRaza.elfo:
                health = 125;
                initialHealth = health;
                CheckInvunerability(true);
                TakeDamage(25);
              
                break;
        }


      



    }

    public void TakeDamage(int damage)
    {
        if (invunerability)
        {
            Debug.Log("Es Invunerable");

        }
        else if (hasShield)
        {
            health = shield - damage;
            Debug.Log("El personaje pierde " + health + " puntos de vida");
        } else
        {
            health -= damage;
            Debug.Log("Character attacked " + damage);
        }
    }


    public  void MultiAttack(int ataques,int damage)
    {
        for(int i =0; i < ataques; i++)
        {
            TakeDamage(damage);
        }

    }

    public float GetHealthRatio()
    {
        return ((float)health / initialHealth)*100;
    }

    public void CheckInvunerability(bool i)
    {
        invunerability = i;
    }


    public void SetShield(bool i)
    {
        hasShield = true;
    }

    public void RecuperarSalud()
    {
        for (int i = health; i < initialHealth; i++)
        {
            health += 1;
        }
            
            
    }
}
