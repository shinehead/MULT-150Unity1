using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float mX = Input.GetAxis("Horizontal");
        float mY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(mX, 0.0f, mY);
        rb.AddForce(movement * moveSpeed);
    }
}
