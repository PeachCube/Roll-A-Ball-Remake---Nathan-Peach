using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class InstantDeath : MonoBehaviour
{
    public int deaths = 0;
    public GameObject player;
    public GameObject spawn;
    
    private void OnTriggerEnter(Collider player)
    {
        deaths += 1;
        player.transform.position = spawn.transform.position;
    }
}
