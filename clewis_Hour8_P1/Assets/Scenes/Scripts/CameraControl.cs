using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(.05f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 movement = new Vector3(mouseX, mouseY, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
