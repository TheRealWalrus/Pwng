using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10f;

    private Rigidbody2D rigidBody2D;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rigidBody2D.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rigidBody2D.velocity = new Vector2(0, -speed);
        }
        else
        {
            rigidBody2D.velocity = new Vector2();

        }
    }
}
