using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float MaxAimDistance = 5.0f;
    public float SmoothTime = 0.5f;

    private Camera followCamera;

    // Use this for initialization
    void Start () {
        followCamera = Camera.main;
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 cameraPosition = followCamera.transform.position;

        cameraPosition.x = transform.position.x;
        cameraPosition.z = transform.position.z;

        Vector2 mousePosition = Input.mousePosition;
        mousePosition.x = (mousePosition.x / Screen.width) - 0.5f;
        mousePosition.y = (mousePosition.y / Screen.height) - 0.5f;

        cameraPosition.x += (mousePosition.x * MaxAimDistance);
        cameraPosition.z += (mousePosition.y * MaxAimDistance);

        followCamera.transform.position = Vector3.Lerp (followCamera.transform.position, cameraPosition, SmoothTime * Time.deltaTime);
    }
}
