using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;

public abstract class Target : MonoBehaviour
{   
    public Animator anim;
    private float deactivationTime;
    public IEnumerator Successful(GameObject thisGO)
    {
        deactivationTime = 0.5f;
        GameManager.SuccessEvent.Invoke();
        anim = thisGO.GetComponent<Animator>();
        anim.SetBool("Active", false);
        yield return new WaitForSeconds(deactivationTime);
        thisGO.SetActive(false);
    }
}
