using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDaBall : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform spawn;
    private bool hasDropped = false;
    public GameObject shenron;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasDropped == false)
        {
            rb.gravityScale = 1;
            hasDropped = true;
            transform.parent = null;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && hasDropped == true)
        {
            transform.position = spawn.position;
            rb.gravityScale = 0;
            hasDropped = false;
            transform.parent = shenron.transform;
        }
    }
}

