using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollectable : MonoBehaviour
{
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0,60,0)*Time.deltaTime);
        transform.position = new Vector3(0, Mathf.PingPong(Time.time, -1), 0);
    }
    private void OnTriggerEnter(Collider player)
    {
        gameObject.SetActive(false);
    }
}
