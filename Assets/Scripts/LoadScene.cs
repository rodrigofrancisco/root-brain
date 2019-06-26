using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public int sceneIndex;

    void OnMouseDown() {
        SceneManager.LoadScene(sceneIndex);
    }

    public void CargarEscena() {
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("asdf");
    }
}