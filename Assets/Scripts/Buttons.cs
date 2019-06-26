using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
    public GameObject[] panelArray;
    public GameObject uiPanel;
    public GameObject triggers;

    public static Buttons instance;

    void Start() {
        instance = this;
    }

    public void HideAll() {
        foreach (var panel in panelArray) {
            panel.SetActive(false);
        }
        uiPanel.SetActive(true);
        triggers.SetActive(true);
    }
}
