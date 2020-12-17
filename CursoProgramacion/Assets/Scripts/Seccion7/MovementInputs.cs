using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInputs : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputsMovement();        
    }


    public void InputsMovement()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }


}
