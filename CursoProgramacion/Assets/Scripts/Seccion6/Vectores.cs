using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    public Vector3 pos;
    public float factor;
    public Transform esfera;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
        esfera.localScale  = Vector3.one * factor;
        esfera.position = new Vector3(esfera.position.x, pos.y, esfera.position.z);
        esfera.transform.forward = transform.forward;

        Debug.Log(Vector3.Distance(transform.position, esfera.position));
        Debug.Log(pos - esfera.position );


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
