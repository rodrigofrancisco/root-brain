using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GotaBehavior : MonoBehaviour{

    public bool isCorrect;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "Personaje" || col.gameObject.name == "BoxQuestion"){
            Debug.Log("Mataste al personaje xd");
            //Game over goes here
        }
    }
    
    void OnMouseDown(){
        Debug.Log("Si entra aqui");
        Debug.Log("Correctness from script"+ isCorrect);
        if( isCorrect){
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("Gotas");
     
            for(var i = 0 ; i < gameObjects.Length ; i ++){
                Destroy(gameObjects[i]);
            }
        }
    }
}
