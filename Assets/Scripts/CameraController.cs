using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;
    //private Vector3 manualRotation;
    void Start()
    {
        offset = transform.position - Player.transform.position;
        //manualRotation.y = -90;
    }
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset + new Vector3(0,6,-10);
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
           //transform.Rotate((manualRotation), Space.World);
           //transform.Translate(new Vector3(10,0,-10));
        //}
        //if (Input.GetKeyDown(KeyCode.Mouse1))
        //{
           //transform.Rotate((manualRotation) * -1, Space.World);
           //transform.Translate(new Vector3(-10,0,10));
        //}
    }
}
