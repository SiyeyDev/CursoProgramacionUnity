using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiudadScript : MonoBehaviour
{
    public string CityName;
    public int madera, piedra, oro;
    public int casas;
    public int poblacion;
    

    public enum tamañoCasas
    {
        pequeño,mediano,grande

    }

    private void Start()
    {
        Debug.Log("Bienvenido a " + CityName);
        ActualizarRecursos(350,200,100);
        //Comprobacion(madera,piedra,oro);
        ConstruirCasa(tamañoCasas.pequeño);
        ConstruirCasa(tamañoCasas.mediano);
        ActualizarRecursos(100, 100, 0);
        ConstruirCasa(tamañoCasas.grande);
        AumentarPoblacion();


    }


    public void ActualizarRecursos(int valorM, int valorP, int valorO)
    {
        madera += valorM;
        piedra += valorP;
        oro += valorO;
    }

    public bool Comprobacion(int m,int p, int o)
    {
        return m <= madera && p <= piedra && o <= oro;
    }

    public void ConstruirCasa(tamañoCasas casa)
    {
        switch (casa)
        {
            case tamañoCasas.pequeño:
                if(Comprobacion(50,0,0))
                {
                    ActualizarRecursos(-50, 0, 0);
                    casas += 1;
                    poblacion++;
                  
                }
                else
                {
                    Debug.Log("No hay suficientes recursos");
                }

                break;

            case tamañoCasas.mediano:
                if (Comprobacion(50, 25, 0))
                {
                    ActualizarRecursos(-50, -25, 0);
                    casas += 1;
                    poblacion+=2;

                }
                else
                {
                    Debug.Log("No hay suficientes recursos");
                }
                break;

            case tamañoCasas.grande:
                if (Comprobacion(50, 50, 25))
                {
                    ActualizarRecursos(-50, -25, -25);
                    casas += 1;
                    poblacion+=3;

                }
                else
                {
                    Debug.Log("No hay suficientes recursos");
                }
                break;
        }
       
       
    }

    public void AumentarPoblacion()
    {
        int contNac = 0;
        for(int i = 0; i <= poblacion; i+=2)
        {
            Debug.Log("Nacimiento");
            contNac++;
        }
        poblacion += contNac;
    }


}
