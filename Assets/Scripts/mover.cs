using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    Game_controler game_controler;

	void Start ()
    {
        game_controler = FindObjectOfType<Game_controler>();
	}
	
	void Update ()
    {
        transform.Translate(Vector3.left * (game_controler.speed * Time.deltaTime));

        if(transform.position.x <-17.0f)
        {
            Destroy(gameObject);
        }
	}
}
