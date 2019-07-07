using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GotaBehavior : MonoBehaviour{

    public TextMeshPro answerOp;
    public string answerOpText;
    public bool isCorrect;
    public string tagName;

    void Start(){
        answerOp.text = answerOpText;
    }

    void OnCollisionEnter2D(Collision2D col){
/*         if(col.gameObject.name == "Personaje" || col.gameObject.name == "BoxQuestion"){
            Debug.Log("Mataste al personaje xd");
            //Game over goes here
        } */
    }
    
    void OnMouseDown(){
        if( isCorrect){
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag (tagName);
     
            for(var i = 0 ; i < gameObjects.Length ; i ++){
                Destroy(gameObjects[i]);
            }
        }
    }
}
