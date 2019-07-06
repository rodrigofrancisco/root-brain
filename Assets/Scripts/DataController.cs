using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour{

    public QuestionData[] questions;

    // Start is called before the first frame update
    void Start(){
        DontDestroyOnLoad(gameObject);
    }

}
