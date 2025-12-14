using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator m_Animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for key presses in the Update function
        if (Input.GetKeyDown(KeyCode.W))
        {
        Debug.Log("Update function is running every frame.");
            // Set the Animator Trigger for the color change animation
            m_Animator.SetTrigger("RotateAnim");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Set the Animator Trigger for the scaling animation
            m_Animator.SetTrigger("Scale");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Set the Animator Trigger for the spinning animation
            m_Animator.SetTrigger("Position");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Set the Animator Trigger for the hover animation
            m_Animator.SetTrigger("ColorChange");
        }
    }
}
