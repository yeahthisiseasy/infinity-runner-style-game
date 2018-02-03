using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

    public string level;
    public string options;
    public string Return;

    public void start()
    {
        Application.LoadLevel(level);
        
    }

    public void Options()
    {
        Application.LoadLevel(options);
    }

    public void quit()
    {
        Application.Quit();
    }
}
