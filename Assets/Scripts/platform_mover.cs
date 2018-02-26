using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_mover : MonoBehaviour
{

    Game_controler game_controler;

	void Start ()
    {
        game_controler = FindObjectOfType<Game_controler>();
	}
	
	void Update ()
    {
        transform.Translate(Vector3.left * (game_controler.speed * Time.deltaTime));

        if (transform.localPosition.x <= -10.5)
        {
            Vector3 newPos = new Vector3(transform.position.x + 39f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
	}
}
