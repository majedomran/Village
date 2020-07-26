using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConteroll : MonoBehaviour
{
    // Start is called before the first frame update
    // [serilz]
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
    
    void onMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            mouseOrigin = Input.mousePosition;
        }
        if(Input.GetMouseButton(0))
        {
            // Debug.Log("down");
            CameraController();
        }
        

    }
    void onScrolling(){
        if(Input.GetAxis("Mouse ScrollWheel")!=0){
        Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
        cameraZoom(Input.GetAxis("Mouse ScrollWheel"));
        }
    }
    void CameraController()
    {
        // Debug.Log(Input.mousePosition);
        
        mouseMovment();

    }
    void cameraZoom(float zoom){
        camera.transform.position =new Vector3(camera.transform.position.x,camera.transform.position.y-zoom,camera.transform.position.z+zoom);
    }
    void mouseMovment(){
        Vector3 mouseDif = mouseOrigin - Input.mousePosition;
        Debug.Log(mouseDif/108);
        camera.transform.position = camera.transform.position + mouseDif/108;
        mouseOrigin = Input.mousePosition;
    }
    
}


