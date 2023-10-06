using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpen : MonoBehaviour
{
    
    public GameObject player;
    public GameObject locked;
    public GameObject trigger;
    void Start()
    {
        trigger.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider player)
    {
        locked.gameObject.SetActive(false);
        trigger.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
