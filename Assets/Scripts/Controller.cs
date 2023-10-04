using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using TMPro;
public class Controller : MonoBehaviour
{
    public float jumpStrength = 10;
    public Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 10;
    public TextMeshProUGUI scoreDisplay;//I tried to have this reference the "ScoreDisplay" gameobject but it doesn't seem to work if both objects are prefabs, so I have to reassign this on each level
    private bool jumping = false;
    private int score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreCount();
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumping == false) 
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            jumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        jumping = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Diamond"))
        {
            score = score + 1;
            SetScoreCount();
        }
    }
    void SetScoreCount()
    {
        scoreDisplay.text = "Score: " + score.ToString();
    }
}
