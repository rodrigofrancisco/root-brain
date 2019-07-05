using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GotaBehavior : MonoBehaviour{

    public GameObject objeto;
    public TextMeshPro gotaText;
    public DataController dataController;
    public int answerIndex;

    void Start(){
        dataController = FindObjectOfType<DataController>();
        gotaText.text = dataController.questions[0].answers[answerIndex].answerText;
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "Personaje" || col.gameObject.name == "BoxQuestion"){
            Debug.Log("Mataste al personaje xd");
            //Game over goes here
        }
    }
    
    void OnMouseDown(){
        if( dataController.questions[0].answers[answerIndex].isCorrect){
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("Gotas");
     
            for(var i = 0 ; i < gameObjects.Length ; i ++){
                Destroy(gameObjects[i]);
            }
        }
            //Destroy(objeto);
    }
}
