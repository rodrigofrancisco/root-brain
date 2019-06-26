using UnityEngine;

public class RotateObject : MonoBehaviour {
    public GameObject modelo;
    private float rotSpeed = 200.0f;
    private float rotX;
    private float rotY;

    void OnMouseDrag() {
        rotX = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        rotY = Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;

        modelo.transform.Rotate(Vector3.up, -rotX);
        modelo.transform.Rotate(Vector3.right, -rotY);
    }
}
