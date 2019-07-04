using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public int sceneIndex;

    public void CargarEscena() {
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
}