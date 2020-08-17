using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2movement : MonoBehaviour
{
    public float movespeed = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * movespeed;
        GetComponent <Rigidbody2D>().velocity = new Vector2(0,v);
    }
}
