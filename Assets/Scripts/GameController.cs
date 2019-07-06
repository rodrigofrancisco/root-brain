using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour{

    public TextMeshPro textQuestion;
    public DataController dataController;

    public GameObject[] gotas = new GameObject[3];
    public GameObject gota; //hola

    // Start is called before the first frame update
    void Start(){
        //dataController = FindObjectOfType<DataController>();
        textQuestion.text = dataController.questions[0].questionText;

        Instantiate(gotas[0],new Vector3(-2.52F,4.85F, 0), Quaternion.identity);

        TextMeshPro gotaAnswerOption = gotas[0].GetComponentInChildren<TextMeshPro>();

        Debug.Log(gotaAnswerOption.text);

        gotaAnswerOption.text = dataController.questions[0].answers[0].answerText; 

        Debug.Log(gotaAnswerOption.text);

        gota.GetComponent<GotaBehavior>().isCorrect = true;

        Debug.Log(gota.GetComponent<GotaBehavior>().isCorrect);

    }


}
