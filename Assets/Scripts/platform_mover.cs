using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_mover : MonoBehaviour {

    public float speed;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));

        if (transform.localPosition.x <= -10.5)
        {
            Vector3 newPos = new Vector3(transform.position.x + 39f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
	}
}
