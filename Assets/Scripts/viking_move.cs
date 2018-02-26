using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viking_move : MonoBehaviour
{

    public Rigidbody2D viking;
    public float jump;

    public Transform sensor;
    public float sensorpanel;
    public LayerMask mask;
    public bool touchmask;

    void Start()
    {
        viking = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        touchmask = Physics2D.OverlapCircle(sensor.position, sensorpanel, mask);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && touchmask)
        {
            viking.velocity = new Vector2(viking.velocity.x, jump);
        }
    }
}
