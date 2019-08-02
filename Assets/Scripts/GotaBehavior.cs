using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GotaBehavior : MonoBehaviour{

    public TextMeshPro answerOp;
    public string answerOpText;
    public bool isCorrect;
    public string tagName;
    public int maxIndexQuestion;
    public int indexQuestion;

    void Start(){
        answerOp.text = answerOpText;
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "Personaje" || col.gameObject.name == "BoxQuestion"){
            GameObject.Find("Personaje").GetComponent<PersonajeLife>().isAlive= false;
            DestroyGotasGroup();

        }
    }
    
    void DestroyGotasGroup(){
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag (tagName);
        for(var i = 0 ; i < gameObjects.Length ; i ++)
            Destroy(gameObjects[i]);  
    }

    void OnMouseDown(){
        if( isCorrect){
            DestroyGotasGroup();
            Text scoreNumber = GameObject.Find("Canvas/ScoreNumber").GetComponent<Text>();
            int actualScore = int.Parse(scoreNumber.text);
            int newScore = actualScore +5;
            scoreNumber.text = newScore.ToString(); 
        }
        if(indexQuestion == maxIndexQuestion){
            GameObject.Find("Personaje").GetComponent<PersonajeLife>().gameOver= true;
        }
    }
}
