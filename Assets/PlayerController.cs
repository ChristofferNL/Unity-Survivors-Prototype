using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public float MoveSpeed = 10f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Instance = this;
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rb.velocity = new Vector3(moveInput.x, rb.velocity.y, moveInput.y) * MoveSpeed;
    }
}
