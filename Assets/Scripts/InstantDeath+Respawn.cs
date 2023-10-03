using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class InstantDeath : MonoBehaviour
{
    public int deaths = 0;
    public GameObject Player;
    public GameObject spawn;
    
    private void OnTriggerEnter(Collider player)
    {
        //increases death counter by 1
        deaths += 1;
        
        //places the player ball back at the designated spawn position
        player.transform.position = spawn.transform.position;
        
        //sets the velocity of the player ball rigidbody to zero
        Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
