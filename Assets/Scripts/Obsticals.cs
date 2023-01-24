using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticals : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BirdyJumpY>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }

}
