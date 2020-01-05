using System;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float forceMagnitude;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        //double radians = 2.4215435981750; WIP
        //double radians = Math.PI;
        double radians = UnityEngine.Random.Range((float)Math.PI * 0.75f, (float)Math.PI * 1.25f);
        float randomDir = UnityEngine.Random.Range(0f, 1f);
        Debug.Log(randomDir);

        //if (randomDir < 0.5f)
        //{
        //    radians = UnityEngine.Random.Range((float) Math.PI * 1.75f, (float) Math.PI * 2.25f);
        //    Debug.Log("right " + radians);
        //}
        //else
        //{
        //    radians = UnityEngine.Random.Range((float) Math.PI * 0.75f, (float) Math.PI * 1.25f);
        //    Debug.Log("left " + radians);
        //}

        Vector2 direction = new Vector2((float)Math.Cos(radians), (float)Math.Sin(radians));
        direction *= forceMagnitude;

        rigidBody2D.AddForce(direction);
    }
}
