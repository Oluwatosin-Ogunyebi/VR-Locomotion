using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandmanagerScript : MonoBehaviour
{
    public Animator handAnimator;

    public InputActionReference gripAction;

    private void Start()
    {
        gripAction.action.started += Action_started;
        gripAction.action.canceled += Action_canceled;
    }

    private void Action_canceled(InputAction.CallbackContext obj)
    {
        Release();
    }

    private void Action_started(InputAction.CallbackContext obj)
    {
        Gripped();
    }

    public void Gripped()
    {
        handAnimator.SetBool("IsGripped", true);
    }

    public void Release()
    {
        handAnimator.SetBool("IsGripped", false);
    }
}
