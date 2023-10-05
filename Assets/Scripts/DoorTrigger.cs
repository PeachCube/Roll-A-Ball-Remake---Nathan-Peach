using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject Door1;
    public GameObject Door2;
    private float startpos1;
    private float startpos2;
    private void Start()
    {
        startpos1 = Door1.transform.position.z;
        startpos2 = Door2.transform.position.z;
    }
    void Update()
    {
      
    }
    IEnumerator OnTriggerEnter(Collider player)
    {
        //do
        //{
        //I know this code sucks but it still works, and I understand how it works, so I don't
        //think I should waste time trying to change it for now.
        //uses a for loop with the float variable "open" to count iterations.
        //translates the doors each iteration.
        //IEnumerator and yield return null so "OnTriggerEnter" activates each frame until the "for" loop expires.
        //once the loop expires, set the trigger to detect the player to inactive.
        for(float open = 0; open <= 120; open = open + 0.25f)
        {
            Door1.transform.Translate(new Vector3(0, 0, 2) * Time.deltaTime);
            Door2.transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);
            yield return null;
        }
            
        //} //while ((Door1.transform.position.z <= startpos1 + 2) && (Door2.transform.position.z >= startpos2 - 2));
        gameObject.SetActive(false);
    }
}
