using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConteroll : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mouseOrigin = new Vector3();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        onMouseDown();
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
    
    void CameraController()
    {
        // Debug.Log(Input.mousePosition);
        Camera camera = Camera.main;
        Vector3 mouseDif = mouseOrigin - Input.mousePosition;
        Debug.Log(mouseDif/108);
        camera.transform.position = camera.transform.position + mouseDif/108;
        mouseOrigin = Input.mousePosition;

    }
    
}


