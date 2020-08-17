using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.right * Ballmovespeed;

    }
    public Text scorerightText;
    public Text scoreleftText;
    int scoreRight;
    int scoreLeft;
    public float Ballmovespeed = 20f;
    void OnCollisionEnter2D(Collision2D col)
    {
        float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
        {
           
            return (ballPos.y - racketPos.y) / racketHeight;
        }


       

        
        if (col.gameObject.name == "RacketLeft")
        {
           
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

  
            Vector2 dir = new Vector2(1, y).normalized;

           
            GetComponent<Rigidbody2D>().velocity = dir * Ballmovespeed;
        }

       
        if (col.gameObject.name == "RacketRight")
        {
            
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            
            GetComponent<Rigidbody2D>().velocity = dir * Ballmovespeed;
            if (col.gameObject.name == "Wallright")
            {
                
                scoreLeft++;
              
                scoreleftText.text = scoreLeft.ToString();
            }
            if (col.gameObject.name == "Wallleft")
            {
                scoreRight++;
                scorerightText.text = "Wallleft";
            }

        }

       
    }
}
