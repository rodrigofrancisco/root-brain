using UnityEngine;
using UnityEngine.SceneManagement;

public class switchMode : MonoBehaviour
{
    public int sceneIndex;

    public void CargarEscena(){
           
        if(sceneIndex == 0){
            SceneManager.LoadScene(1);
        }
        else{
            SceneManager.LoadScene(0);
        }
        
    }
}