using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    // Parameters
    [SerializeField] Puma[] pumas;
    [SerializeField] GameObject[] lifes;

    // State Variables
    private bool isHide = true;
    private int numberOfLifes;
    private float secondsDiscover = 0;
    private float timeDiscover = 1f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pumas.Length; i++)
        {
            pumas[i].hidePuma();
        }

        numberOfLifes = lifes.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHide)
        {
                secondsDiscover = 0;
                int selectedPuma = UnityEngine.Random.Range(0, pumas.Length);
                pumas[selectedPuma].showPuma();
                changeState();
        }
        else
        {
            secondsDiscover += Time.deltaTime;
            if (secondsDiscover > timeDiscover)
            {
                for (int i = 0; i < pumas.Length; i++)
                {
                    pumas[i].hidePuma();
                }
                changeState();
            }
        }
    }

    public void changeState()
    {
        if (isHide)
            isHide = false;
        else
            isHide = true;
    }

    public void loseLife()
    {
        Destroy(lifes[numberOfLifes]);
        numberOfLifes--;

        if (numberOfLifes < 0)
        {
            FindObjectOfType<LoadScene>().LoadMainScene();
        }
    }

}
