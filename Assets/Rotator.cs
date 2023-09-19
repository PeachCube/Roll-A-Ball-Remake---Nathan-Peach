using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Rotor());
    }
    IEnumerator Rotor()
    {
        transform.Rotate(new Vector3(0, 0, 90), Space.World);
        yield return new WaitForSeconds(3); 
    }
}
