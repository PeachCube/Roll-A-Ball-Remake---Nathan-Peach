using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollectable : MonoBehaviour
{
    public GameObject player;
    private float max;
    private float min;
    void Start()
    {
        max = gameObject.transform.position.y + 0.45f;
        min = gameObject.transform.position.y;
    }

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0,60,0)*Time.deltaTime);
        //rotates each diamond by 60 degrees in the y-axis * Time.deltaTime every frame
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time*0.35f, max-min)+min, transform.position.z);
        //moves every diamond up and down within a set range. The transform of x and z stays the same, while the y value uses a function to return a fluctuating value based on time.
        //I used a similar script in my Ballshooter remix, but it didn't work correctly, so I salvaged it to reuse it here, and I guess it works now. shrug.
    }
    private void OnTriggerEnter(Collider player)
    {
        gameObject.SetActive(false);
    }
}
