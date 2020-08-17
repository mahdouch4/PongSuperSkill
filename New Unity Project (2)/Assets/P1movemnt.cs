using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movemnt : MonoBehaviour
{
    public float movespeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        if (Input.GetKey(KeyCode.Z)) { 
      
        transform.position +=  new Vector3(0,1,1) * movespeed * Time.deltaTime;
           
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position +=  new Vector3(0,-1,1) * movespeed * Time.deltaTime;
        }
    }
}
