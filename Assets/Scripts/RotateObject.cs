using UnityEngine;

using UnityEngine.SceneManagement;

public class RotateObject : MonoBehaviour {
    public GameObject modelo;

    public int sceneIndex;

    private float rotSpeed = 200.0f;
    private float rotX;
    private float rotY;   

    private float initTime; 
    private float endTime; 

    void OnMouseDown (){      
        initTime = Time.time;
    }
   
    void OnMouseUp (){
        endTime = Time.time;
        if ((endTime-initTime) < 0.15 ){
            SceneManager.LoadScene(sceneIndex);
        }
    }

    void OnMouseDrag() {
        rotX = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        rotY = Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;

        modelo.transform.Rotate(Vector3.up, -rotX);
        modelo.transform.Rotate(Vector3.right, -rotY);
    }
}
