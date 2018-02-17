using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{

    public float playerscore = 0;
    public int fontSize;

    void Update()
    {
        playerscore += Time.deltaTime;
    }

    public void IncreaseScore(int amount)
    {
        playerscore += amount;
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + (playerscore * 10));
    }

}
