using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdyJumpY : MonoBehaviour
{
    public float upForce;                    
    private bool YouSuck = false;            

    private Animator FlapFlap;                    
    private Rigidbody2D rb2d;                

    void Start()
    {  
        FlapFlap = GetComponent<Animator>(); 
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {  
        if (YouSuck == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                FlapFlap.SetTrigger("Flap");
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        YouSuck = true;
        FlapFlap.SetTrigger("Die");
        GameControl.instance.BirdDied ();
    }
}
