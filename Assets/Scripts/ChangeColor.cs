using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject Player;
    public Color color;

    string change;
    Renderer thisRend;
    public Material Red;
    public Material Blue;
    public Material Green;

    public void Colorchange()
    {
        switch (dropdown.value)
        {
            case 1:
                Player.GetComponent<Renderer>().sharedMaterial = Red;
                break;

            case 2:
                Player.GetComponent<Renderer>().sharedMaterial = Blue;
                break;

            case 3:
                Player.GetComponent<Renderer>().sharedMaterial = Green;
                break;

            default:
                break;
              

        }
    }




}


