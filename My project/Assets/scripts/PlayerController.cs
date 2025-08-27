using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    public float jumpforce;
    public Rigidbody playerRB;
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * vInput * speed *Time.deltaTime);
    }
}