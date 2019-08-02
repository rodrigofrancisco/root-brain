using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puma : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<GameSession>().AddToScore();
        hidePuma();
        FindObjectOfType<GamePlay>().changeState();
    }

    public void showPuma()
    {
        GetComponent<Renderer>().enabled = true;
        GetComponent<BoxCollider2D>().enabled = true;
    }

    public void hidePuma()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
