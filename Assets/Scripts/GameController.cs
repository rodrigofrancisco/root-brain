using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour{

    public TextMeshPro textQuestion;
    public DataController dataController;
    public GameObject gotaprefab;
    public GameObject gameOverPanel;
    public GameObject onStartGamePanel;
    //private float timer = 0f;
    //private int timer2 = 0;
    //private int temp = 0;
    //private int questionCouter = 0;
    

    private List<GameObject> _instances = new List<GameObject>();

    void Start(){
        StartCoroutine(DisplayNextQuestion());
    }

/*     void Update(){
        timer += Time.deltaTime;
        timer2 = (int) timer;

        if (timer2 != 0 && timer2 %3 == 0 && timer2 != temp){
            temp = timer2;
            if (questionCouter < dataController.questions.Length){
                CreateDropsAndQuestion(questionCouter);
                questionCouter ++;
            }
        }
    } */


    IEnumerator DisplayNextQuestion(){
        //Tantas preguntas como grupos de 3 gotas
        for (int i = 0 ; i < dataController.questions.Length; i++){ 
            yield return new WaitForSeconds(3);
            onStartGamePanel.SetActive(false);
            bool p = GameObject.Find("Personaje").GetComponent<PersonajeLife>().isAlive;
            if(p) CreateDropsAndQuestion(i);
            else {
                Debug.Log("ya se murio");
                for(int j = 0; j< _instances.Count; j++){
                    Destroy(_instances[j]);
                }
                gameOverPanel.SetActive(true);
            }
        }
    } 

    void CreateDropsAndQuestion(int index){
        
        textQuestion.text = dataController.questions[index].questionText;

        Vector3[] positionGotas= {
            new Vector3(-2.79F,4.36F, 0),
            new Vector3(0.13F,4.36F, 0),
            new Vector3(2.87F,4.36F, 0)
        };

        for(int i = 0 ; i < 3; i++){ // son máximo 3 gotas

            GameObject instance = Instantiate(gotaprefab);

            instance.gameObject.tag="gotas"+index.ToString();

            instance.GetComponent<GotaBehavior>().answerOpText = 
                dataController.questions[index].answers[i].answerText; 

            instance.GetComponent<GotaBehavior>().isCorrect = 
                dataController.questions[index].answers[i].isCorrect;

            instance.GetComponent<GotaBehavior>().tagName = 
                "gotas"+index.ToString();

            instance.GetComponent<GotaBehavior>().maxIndexQuestion = 
                dataController.questions.Length - 1;
            
            instance.GetComponent<GotaBehavior>(). indexQuestion = index;

            instance.transform.position = positionGotas[i];

            instance.transform.rotation = Quaternion.identity;

            _instances.Add(instance);

        }
    }
}
