using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDaMime : MonoBehaviour
{
    public float speed = 5f;
    private bool moveRight = true;

    void Update()
    {
        if (transform.position.x > 6f)
            moveRight = false;
        if (transform.position.x < -6f)
            moveRight = true;
       
        if (moveRight)
           transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        else
           transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }
}


