using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    //private Vector3 dir;
    //[SerializeField] private int speed;
    [SerializeField] private int jumpForce;
    Rigidbody rb;
    public bool isGrounded;
    public bool doubleJump = false;

    private int LineToMove = 1;
    public float lineDistance = 4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnJump_()
    {
        if (isGrounded)
        {
            isGrounded = false;
            rb.AddForce(Vector3.up * jumpForce);
            doubleJump = true;
        } else if (doubleJump) {
            rb.AddForce(Vector3.up * jumpForce);
            doubleJump = false;
        }
    }

    void OnLeft_()
    {
        if (LineToMove > 0) transform.Translate(Vector3.left * lineDistance); LineToMove--;
        //Debug.Log("ummm left&");
    }

    void OnRight_()
    {
        if (LineToMove < 2) transform.Translate(Vector3.right * lineDistance); LineToMove++;
        //Debug.Log("heheh right");
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    // Update is called once per frame
    private void Update()
    {

        //Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        //if (LineToMove == 0) targetPosition = Vector3.left * lineDistance;
        //else if (LineToMove == 2) targetPosition = Vector3.right * lineDistance;
        //transform.position = targetPosition;
    }

}