using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConteroll : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10f;
    [SerializeField] float MovmentSpeed = 1f;
    Vector3 mouseOrigin = new Vector3();
    Camera camera;
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        onMouseDown();
        onScrolling();
    }

    void onMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log('1');
            mouseOrigin = Input.mousePosition;

        }
        if (Input.GetMouseButton(1))
        {
            cameraRotation();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log('0');
            mouseOrigin = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            // Debug.Log("down");
            mouseMovment();
        }
    }
    void cameraRotation()
    {
        Vector3 mouseDif = mouseOrigin - Input.mousePosition;
        transform.Rotate((mouseDif.y/108)*rotationSpeed,(mouseDif.x/108)*rotationSpeed,0);
        mouseOrigin = Input.mousePosition;
        // // Debug.Log(mouseDif);
        // camera.transform.rotation.Set(0,50,0,0);
    }
    void onScrolling()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            // Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
            cameraZoom(Input.GetAxis("Mouse ScrollWheel"));
        }
    }
    void cameraZoom(float zoom)
    {
        camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - zoom, camera.transform.position.z + zoom);
    }
    void mouseMovment()
    {

        Vector3 mouseDif = mouseOrigin - Input.mousePosition;
        // Debug.Log(mouseDif / 108);
        camera.transform.position =new Vector3( camera.transform.position.x + mouseDif.x / 108,camera.transform.position.y,camera.transform.position.z+mouseDif.y/108);
        mouseOrigin = Input.mousePosition;
    }

}


