using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBckGround : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundLength;
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundLength = groundCollider.size.x;
    }
    private void Update()
    {
        if (transform.position.x < -groundLength)
        {
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(groundLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
