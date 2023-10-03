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
    public float speed = 0;
    public TextMeshProUGUI scoreDisplay;
    private bool jumping = false;
    private int score;
    public GameObject diamond;
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
    private void OnTriggerEnter(Collider diamond)
    {
        score = score + 1;
        SetScoreCount();
    }
    void SetScoreCount()
    {
        scoreDisplay.text = "Score: " + score.ToString();
    }
}
