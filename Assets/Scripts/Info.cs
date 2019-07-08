using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour{
    public bool onOffPanel = false;
    public GameObject infoPanel;
    public void ToglePanelInfo(){
        if (onOffPanel){
            onOffPanel = false;
            infoPanel.SetActive(false);
        }
        else {
            onOffPanel = true;
            infoPanel.SetActive(true);
        }    
    }
}
