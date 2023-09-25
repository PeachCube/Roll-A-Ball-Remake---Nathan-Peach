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
        Door1.transform.Translate((Door1.transform.position + Vector3.back) * Time.deltaTime);
        Door2.transform.Translate((Door2.transform.position + Vector3.forward) * Time.deltaTime);
    }
}
