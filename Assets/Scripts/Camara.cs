using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Camera FPSCamera;
    //public float UbicacionCamera;
    public float HorizontalSpeed;
    public float VerticalSpeed;
    float h;
    float v;
    void Start()
    {
        
    }

    
    void Update()
    {
        h = HorizontalSpeed * Input.GetAxis("Mouse X");
        v = HorizontalSpeed * Input.GetAxis("Mouse Y");
        

        transform.Rotate(0, h, 0);
        FPSCamera.transform.Rotate(-v, 0, 0);

        //if (Input.GetKey(KeyCode.LeftControl))
        //{
          //  FPSCamera.transform.Translate(0, -0.5f, 0);
        //}
        //else
        //{
            //UbicacionCamera = FPSCamera.position;
        //}
    }
}
