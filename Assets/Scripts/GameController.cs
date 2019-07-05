using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour{

    public TextMeshPro textQuestion;
    public DataController dataController;

    // Start is called before the first frame update
    void Start(){
        dataController = FindObjectOfType<DataController>();
        textQuestion.text = dataController.questions[0].questionText;
    }

}
