using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_options : MonoBehaviour {

    public string Return;

    public void back()
    {
        Application.LoadLevel(Return);
    }
}
