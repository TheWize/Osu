using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatorState : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("Play", GameManager.isPlaying);
    }
}
