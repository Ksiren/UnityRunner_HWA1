using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;
    [SerializeField] private int speed;
    [SerializeField] private int jumpForce;

    [SerializeField] private PlayerInputs playerInputs;
    Rigidbody rb;

    private int LineToMove = 1;
    public float lineDistance = 4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void OnJump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    // Update is called once per frame
    private void Update()
    {

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (LineToMove == 0) targetPosition = Vector3.left * lineDistance;
        else if (LineToMove == 2) targetPosition = Vector3.right * lineDistance;
        transform.position = targetPosition;
    }

    void FixedUpdate()
    {
        dir.z = speed;
        controller.Move(dir * Time.fixedDeltaTime);
    }
}
