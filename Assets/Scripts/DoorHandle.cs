using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Transform target;
    public Rigidbody doorHandleFIxedJoint_Rb;

    private void FixedUpdate()
    {
        doorHandleFIxedJoint_Rb.MovePosition(target.position);
    }

    private void Start()
    {
        ReleaseHandle();
    }

    public void ReleaseHandle()
    {
        target.position = transform.position;
        target.rotation = transform.rotation;
        doorHandleFIxedJoint_Rb.velocity = Vector3.zero;
        doorHandleFIxedJoint_Rb.angularVelocity = Vector3.zero;
    }
}
