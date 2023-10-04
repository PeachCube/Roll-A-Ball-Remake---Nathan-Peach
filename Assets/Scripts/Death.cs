using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.SceneManagement;
public class InstantDeath : MonoBehaviour
{
    public GameObject Player;
    
    IEnumerator OnTriggerEnter(Collider player)
    {
        yield return true;
    }
}
