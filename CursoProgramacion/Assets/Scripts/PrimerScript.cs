using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    public int x, y;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SumaVariables());
        ActualizaVariables(2);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private int SumaVariables()
    {
        return x + y;
    }

    private void ActualizaVariables(int f)
    {
        x *= f;
        y *= f;
    }


}
