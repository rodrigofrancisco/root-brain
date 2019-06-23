using UnityEngine;

public class Trigger : MonoBehaviour {
    public GameObject gamePanel;
    public GameObject uiPanel;
    public GameObject triggers;

    void OnMouseDown() {
        gamePanel.SetActive(true);
        uiPanel.SetActive(false);
        triggers.SetActive(false);
    }
}