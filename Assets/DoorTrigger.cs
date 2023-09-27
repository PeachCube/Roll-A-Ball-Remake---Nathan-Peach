using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject Door1;
    public GameObject Door2;
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider player)
    {
        Door1.transform.Translate(new Vector3(0,0,1.35f));
        Door2.transform.Translate(new Vector3(0,0,-1.35f));
    }
}
