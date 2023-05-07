using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Animator.SetFloat("Speed", Input.GetAxis("Vertical"));
        Animator.SetFloat("Direction", Input.GetAxis("Horizontal"));

    }
}
