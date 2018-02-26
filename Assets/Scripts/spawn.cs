using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject spawned_object;
    private float spawn_time;
    public Vector2 spawn_time_range;
	
	void Update ()
    {
		if (Time.time > spawn_time)
        {
            Instantiate(spawned_object, transform.position, transform.rotation);
            spawn_time = Random.Range(spawn_time_range.x, spawn_time_range.y) + Time.time;
        }
	}
}
